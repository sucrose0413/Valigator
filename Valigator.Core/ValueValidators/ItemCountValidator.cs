﻿using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core.ValueValidators
{
	public struct ItemCountValidator<TValue> : IValueValidator<TValue[]>
	{
		private readonly Option<int> _minimumItems;
		private readonly Option<int> _maximumItems;

		public ItemCountValidator(int? minimumItems, int? maximumItems)
		{
			if (!minimumItems.HasValue && !maximumItems.HasValue)
				throw new ArgumentException("Either a minimum or a maximum item count must be set.");

			_minimumItems = Option.FromNullable(minimumItems);
			_maximumItems = Option.FromNullable(maximumItems);
		}

		IValueDescriptor IValueValidator<TValue[]>.GetDescriptor()
			=> new StringLengthDescriptor(_minimumItems, _maximumItems);

		bool IValueValidator<TValue[]>.IsValid(TValue[] value)
		{
			if (_minimumItems.TryGetValue(out var minimum) && value.Length < minimum)
				return false;

			if (_maximumItems.TryGetValue(out var maximum) && value.Length > maximum)
				return false;

			return true;
		}

		ValidationError IValueValidator<TValue[]>.GetError(TValue[] value, bool inverted)
			=> new ValidationError("");
	}
}
