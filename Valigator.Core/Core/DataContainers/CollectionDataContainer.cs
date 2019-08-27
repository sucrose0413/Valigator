﻿using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.DataContainers
{
	internal class CollectionDataContainer<TCollectionStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue> : IDataContainer<TValue[]>, IAcceptCollectionValue<TValue[], TValue>
		where TCollectionStateValidator : ICollectionStateValidator<TValue[], TValue>
		where TValueValidatorOne : IValueValidator<TValue[]>
		where TValueValidatorTwo : IValueValidator<TValue[]>
		where TValueValidatorThree : IValueValidator<TValue[]>
	{
		private readonly TCollectionStateValidator _stateValidator;

		private readonly TValueValidatorOne _valueValidatorOne;

		private readonly TValueValidatorTwo _valueValidatorTwo;

		private readonly TValueValidatorThree _valueValidatorThree;

		public DataDescriptor DataDescriptor => DataDescriptor.Create(_stateValidator, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree);

		public CollectionDataContainer(TCollectionStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
		}

		public Data<TValue[]> WithValue(Data<TValue[]> data, Option<Option<TValue>[]> value)
			=> data.WithValidatedValue(value, _stateValidator);

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, TValue[] value)
			=> this.IsValid(model, value, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree);

		Option<ValidationError[]> IDataContainer<TValue[]>.GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
