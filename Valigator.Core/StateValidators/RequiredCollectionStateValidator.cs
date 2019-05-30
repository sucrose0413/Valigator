﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Descriptors;
using Valigator.Core.Helpers;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct RequiredCollectionStateValidator<TValue> : IStateValidator<TValue[]>
	{
		public Data<TValue[]> Data => new DataSource<RequiredCollectionStateValidator<TValue>, PassthroughValidator<TValue[]>, TValue[]>(this, default);

		private readonly Data<TValue> _item;

		public RequiredCollectionStateValidator(Data<TValue> item)
			=> _item = item;

		public RequiredCollectionNullableStateValidator<TValue> Nullable()
			=> new RequiredCollectionNullableStateValidator<TValue>();

		IStateDescriptor IStateValidator<TValue[]>.GetDescriptor()
			=> new CollectionStateDescriptor(false, _item.DataDescriptor);

		Result<TValue[], ValidationError> IStateValidator<TValue[]>.Validate(object model, bool isSet, TValue[] value)
			=> isSet
				? (value != null ? _item.VerifyCollection(model, value) : Result.Failure<TValue[], ValidationError>(new ValidationError("")))
				: Result.Failure<TValue[], ValidationError>(new ValidationError(""));

		public static implicit operator Data<TValue[]>(RequiredCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
