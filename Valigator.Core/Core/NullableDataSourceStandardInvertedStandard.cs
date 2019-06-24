﻿using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct NullableDataSourceStandardInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue>
		where TStateValidator : IStateValidator<Option<TSource>>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
		where TValueValidatorThree : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;
		private readonly TValueValidatorTwo _valueValidatorTwo;
		private readonly TValueValidatorThree _valueValidatorThree;

		private readonly Func<TSource, TValue> _mapper;

		public Data<Option<TSource>> Data => new Data<Option<TSource>>(new NullableDataValidator<TStateValidator, TValueValidatorOne, InvertValidator<TValueValidatorTwo, TValue>, TValueValidatorThree, TSource, TValue>(_stateValidator, _valueValidatorOne, new InvertValidator<TValueValidatorTwo, TValue>(_valueValidatorTwo), _valueValidatorThree, _mapper));

		public NullableDataSourceStandardInvertedStandard(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree, Func<TSource, TValue> mapper)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
			_mapper = mapper;
		}

		internal NullableDataSourceStandardInvertedInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> InvertThree()
			=> new NullableDataSourceStandardInvertedInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree, _mapper);

		public static implicit operator Data<Option<TSource>>(NullableDataSourceStandardInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> dataSource)
			=> dataSource.Data;
	}
}
