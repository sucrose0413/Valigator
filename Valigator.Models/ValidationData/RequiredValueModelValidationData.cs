﻿using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Models.ValidationData
{
	public class RequiredValueModelValidationData<TModel, TValue> : IValidationData<RequiredValueModelValidationData<TModel, TValue>, TValue>, IInvertableValidationData<RequiredValueModelValidationData<TModel, TValue>, TValue>, IModelValidationData<RequiredValueModelValidationData<TModel, TValue>, TModel, TValue>, IInvertableModelValidationData<RequiredValueModelValidationData<TModel, TValue>, TModel, TValue>
	{
		private readonly ValidationData<ModelValue<TModel, TValue>> _validationData;

		public RequiredValueModelValidationData(ValidationData<ModelValue<TModel, TValue>> validationData)
			=> _validationData = validationData;

		public RequiredValueModelValidationData<TModel, TValue> WithValidator(IValidator<TValue> value)
			=> new RequiredValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredValueModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new RequiredValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredValueModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, TValue> value)
			=> new RequiredValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredValueModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, TValue> value)
			=> new RequiredValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public Result<TValue, ValidationError[]> Coerce(Optional<Option<TValue>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<TValue, ValidationError[]>(item);

				return Result.Failure<TValue, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Failure<TValue, ValidationError[]>(new[] { new ValidationError("Unset values not allowed.") });
		}

		public Result<Unit, ValidationError[]> Validate(TModel model, TValue value)
			=> _validationData.Process(ModelValue.Create(model, value));
	}
}
