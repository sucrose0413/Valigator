﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Valigator.Text.Json
{
	public class ValigatorConverter<TObject> : JsonConverter<TObject>
		where TObject : class
	{
		private static Dictionary<string, ValigatorJsonPropertyHandler<TObject>> CreatePropertyHandlers(TObject obj)
		{
			var result = new Dictionary<string, ValigatorJsonPropertyHandler<TObject>>();

			foreach (var property in typeof(TObject).GetProperties(BindingFlags.Public | BindingFlags.Instance))
				result.Add(property.Name, ValigatorJsonPropertyHandler<TObject>.Create(obj, property));

			return result;
		}

		private static Dictionary<string, ValigatorJsonPropertyHandler<TObject>> _getPropertyHandlers;
		private static Dictionary<string, ValigatorJsonPropertyHandler<TObject>> GetPropertyHandlers(TObject obj)
			=> _getPropertyHandlers ??= CreatePropertyHandlers(obj);

		private readonly bool _useNewInstances;

		public ValigatorConverter(ValigatorModelConstructionBehaviour instanceConstructionBehaviour)
		{
			switch (instanceConstructionBehaviour)
			{
				case ValigatorModelConstructionBehaviour.NewInstance:
					_useNewInstances = true;
					break;
				case ValigatorModelConstructionBehaviour.CloneCached:
					_useNewInstances = false;
					break;
				default:
					throw new Exception();
			}
		}

		public override TObject Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var obj = GetObjectInstance();

			while (true)
			{
				if (!reader.Read())
					throw new Exception();

				if (reader.TokenType == JsonTokenType.EndObject)
					break;

				if (reader.TokenType != JsonTokenType.PropertyName)
					throw new Exception();

				var propertyName = reader.GetString();

				if (!reader.Read())
					throw new Exception();

				if (GetPropertyHandlers(obj).TryGetValue(propertyName, out var propertyHandler))
					propertyHandler.ReadProperty(ref reader, options, obj);
				else
					JsonSerializer.Deserialize(ref reader, typeof(object), options);
			}

			return obj;
		}

		private TObject GetObjectInstance()
			=> _useNewInstances
				? Model.CreateNew<TObject>()
				: Model.CreateClone<TObject>();

		public override void Write(Utf8JsonWriter writer, TObject value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			foreach (var handler in GetPropertyHandlers(value))
				handler.Value.WriteProperty(writer, options, value);

			writer.WriteEndObject();
		}
	}
}
