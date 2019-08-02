// NOTE: GENERATED FILE //
using Functional;
using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class OptionalCollectionNullableStateValidatorExtensions
	{
		public static NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TSource>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this OptionalCollectionNullableStateValidator<TSource> source, Func<OptionalCollectionNullableStateValidator<TSource>, NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TSource>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, CustomValidator<TValue[]>, TValue[], TValue[]> Assert<TValue>(this OptionalCollectionNullableStateValidator<TValue> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue, TValue>, TValue[], TValue[]> Unique<TValue>(this OptionalCollectionNullableStateValidator<TValue> source)
			=> source.Add(new UniqueValidator<TValue, TValue>(selector));

		public static NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TValue[], TValue[]> Unique<TValue, TUniqueKey>(this OptionalCollectionNullableStateValidator<TValue> source, Func<TValue, TUniqueKey> selector)
			=> source.Add(new UniqueValidator<TValue, TUniqueKey>(selector));

		public static NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[], TValue[]> ItemCount<TValue>(this OptionalCollectionNullableStateValidator<TValue> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> ItemCount<TSource, TValue>(this NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> ItemCount<TSource, TValue>(this NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, TSource[], TValue[]>, NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, TSource[], TValue[]>, NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> ItemCount<TSource, TValue, TUniqueKey>(this NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> ItemCount<TSource, TValue, TUniqueKey>(this NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, Func<NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]>, NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, Func<NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]>, NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedStandardStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> Unique<TSource, TValue>(this NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source)
			=> source.Add(new UniqueValidator<TValue, TValue>(selector));

		public static NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> Unique<TSource, TValue>(this NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source)
			=> source.Add(new UniqueValidator<TValue, TValue>(selector));

		public static NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> Unique<TSource, TValue, TUniqueKey>(this NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<TValue, TUniqueKey> selector)
			=> source.Add(new UniqueValidator<TValue, TUniqueKey>(selector));

		public static NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> Unique<TSource, TValue, TUniqueKey>(this NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<TValue, TUniqueKey> selector)
			=> source.Add(new UniqueValidator<TValue, TUniqueKey>(selector));

		public static NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]>, NullableDataSourceStandardStandardStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]>, NullableDataSourceInvertedStandardStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]>, NullableDataSourceStandardInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]>, NullableDataSourceInvertedInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandardStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, Func<NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]>, NullableDataSourceStandardStandardStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]>, NullableDataSourceInvertedStandardStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, Func<NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]>, NullableDataSourceStandardInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]>, NullableDataSourceInvertedInvertedStandard<OptionalCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();
	}
}