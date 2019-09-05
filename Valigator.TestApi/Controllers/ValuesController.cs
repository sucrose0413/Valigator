﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Functional;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Valigator;
using Valigator.Core.ValueDescriptors;

namespace Valigator.TestApi.Controllers
{
	public class Model
	{
		public Data<Option<int>> One { get; set; } = Data.Defaulted<int>(-1).Nullable().Not(o => o.InRange(greaterThanOrEqualTo: 0, lessThanOrEqualTo: 2));

		public Data<Option<int[]>> Two { get; set; } = Data.Collection<int>(f => f.Not(o => o.GreaterThan(10))).DefaultedToEmpty().Nullable().Not(o => o.ItemCount(maximumItems: 10)).Not(o => o.Unique()).Assert("", _ => true);

		public Data<Stuff[]> Three { get; set; } = Data.Collection<Stuff>().Defaulted(() => new[] { new Stuff(), new Stuff() });

		public Data<DateTime> Test { get; set; } = Data.Required<DateTime>().InRange(DateTime.Now);
	}

	public class Stuff
	{
		public Data<int> A { get; set; } = Data.Defaulted<int>(5).LessThan(0);
	}

	public class TestAttribute : ValidateAttribute, IValidateType<int>
	{
		public Data<int> GetData() => Data.Defaulted<int>(7).InRange(greaterThan: 5, lessThan: 10);
	}

	public class ComplexObject
	{
		public int Value { get; set; }
	}

	public class TestValidateModelBinderAttribute : ValidateModelBinderAttribute, IValidateType<ComplexObject>
	{
		public override Task<BindResult> BindModel(ModelBindingContext bindingContext)
		{
			var value = bindingContext?.ValueProvider?.GetValue(bindingContext.FieldName).TryFirst() ?? Option.None<string>();

			var result = value
				.Match
				(
					set => TryParseInt(set)
						.Match
						(
							success => BindResult.CreateSet(Option.Some<object>(success)),
							BindResult.CreateFailed
						),
					BindResult.CreateUnSet
				);

			return Task.FromResult(result);
		}

		private Result<Option<object>, ValidationError[]> TryParseInt(string str)
			=> Int32
				.TryParse(str, out var value)
				? Result.Success<Option<object>, ValidationError[]>(Option.Some<object>(value))
				: Result.Failure<Option<object>, ValidationError[]>(new[] { new ValidationError("Failed to parse.", new CustomDescriptor("")) });

		public Data<ComplexObject> GetData() => Data.Required<ComplexObject>().MappedFrom<int>(i => new ComplexObject() { Value = i }, o => o.InRange(greaterThan: 5, lessThan: 10));
	}

	[Route("api/[controller]")]
	//[ApiController]
	public class ValuesController : ControllerBase
	{
		// GET api/values
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		[HttpGet("test/{value}")]
		public ActionResult<string> Get([Test]int value, [Test]int stuff)
		{
			return "value";
		}

		[HttpPost("testBinder/{id}")]
		public ActionResult<string> TestValidateModelBinder([FromRoute, TestValidateModelBinder]ComplexObject id)
		{
			return $"Value: {id.Value}";
		}


		// POST api/values
		[HttpPost]
		public void Post([FromBody]Model value)
		{
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
