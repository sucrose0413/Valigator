﻿using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.DataContainers
{
	internal class NullableDataContainer<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue> : IDataContainer<Option<TValue>>, IAcceptValue<Option<TValue>, TValue>
		where TStateValidator : IStateValidator<Option<TValue>, TValue>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
		where TValueValidatorThree : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;

		private readonly TValueValidatorOne _valueValidatorOne;

		private readonly TValueValidatorTwo _valueValidatorTwo;

		private readonly TValueValidatorThree _valueValidatorThree;

		public DataDescriptor DataDescriptor => DataDescriptor.Create(_stateValidator, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree);

		public NullableDataContainer(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
		}

		public Data<Option<TValue>> WithValue(Data<Option<TValue>> data, Option<TValue> value)
			=> data.WithValidatedValue(value, _stateValidator);

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, Option<TValue> value)
			=> this.IsValid(model, value, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree);

		Option<ValidationError[]> IDataContainer<Option<TValue>>.GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
