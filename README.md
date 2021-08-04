<p align="center"> 
# C# Extension Methods
My C# Extension methods for collections and POCO objects. Enjoy! :collision:
</p>

## You can install all of them via [ NUGET ](https://www.nuget.org/packages/Pylypeiev.Extensions)  :hammer: 
[![NuGet version](https://badge.fury.io/nu/Pylypeiev.Extensions.svg)](https://badge.fury.io/nu/Pylypeiev.Extensions)
### or get [ minimal pack ](https://github.com/pylypeiev/CSharpExtensionMethods.MinimalPack)
[![NuGet version](https://badge.fury.io/nu/Pylypeiev.Extensions.MinimalPack.svg)](https://badge.fury.io/nu/Pylypeiev.Extensions.MinimalPack)


## Table of Contents:
#### Collections extension methods (Namespace - Pylypeiev.Extensions):
- [Array](#array)
- [Dictionary](#dictionary)
- [ICollection](#icollection)
- [IEnumerable](#ienumerable)
- [IList](#ilist)

#### POCO extension methods (Namespace - Pylypeiev.Extensions):
- [bool](#bool)
- [ByteArray](#byte)
- [DateTime](#datetime)
- [decimal](#decimal)
- [double](#double)
- [float](#float)
- [int](#int)
- [long](#long)
- [object](#object)
- [string](#string)
- [char](#char)
- [Exception](#exception)

#### XML extension methods (Namespace - Pylypeiev.Extensions.Xml):
- [XML](#xml)

## Collections extension methods (Namespace - Pylypeiev.Extensions):
<a name="array"></a>

### Array extension methods:
- [Clear](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/ArrayExtensions.cs) - Sets a range of elements in an array to the default value of each element type.
- [Join](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/ArrayExtensions.cs) -  Concatenates the elements of an object array, using the specified separator between each element
- [ToArrayString](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/ArrayExtensions.cs) - A simple string representation of an array(regular, 2d, jagged)
<a name="dictionary"></a>

### Dictionary extension methods:
- [AddIfNotContainsKey](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/DictionaryExtensions.cs) - Add an element with provided key to dictionary if this key is not exist yet
- [AddOrUpdate](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/DictionaryExtensions.cs) - Add an element with provided key to dictionary, if this key is exist - update value
- [ToTuple](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/DictionaryExtensions.cs) - Convert this dictionary to list of Tuples, where item1 is key and item2 is a value from this dictionary
- [GetValueOrDefault](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/DictionaryExtensions.cs) - Get an element with provided key if this key is exist, otherwise default value

<a name="icollection"></a>

### ICollection extension methods:
- [AddIfNotContains](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/ICollectionExtensions.cs) - Add an element to the end of the collection if this value is not exist yet
- [AddRange](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/ICollectionExtensions.cs) - Adds the elements of the specified Array to the end of the collection
- [IsNullOrEmpty](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/ICollectionExtensions.cs) - Check if collection is null or empty 
- [RemoveRange](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/ICollectionExtensions.cs) - Removes a range of elements from collection


<a name="ienumerable"></a>

### IEnumerable extension methods:
- [Append](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Add the object top the end of IEnumerable
- [AreAllSame](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Check if all elements in IEnumerable are equals
- [Concatenate<string>](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Concatenates the elements of an IEnumerable<string> to 1 string
- [ForEach](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Performs the specified action on each element of the IEnumerable
- [IsEmpty](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Check if IEnumerable is empty
- [IsNotEmpty](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Check if IEnumerable is not empty 
- [IsNullOrEmpty](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Check if IEnumerable is null or empty
- [Join](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Concatenates the elements of an IEnumerable, using the specified separator between each element
- [Prepend](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Add the object at the beginning of IEnumerable
- [Shuffle](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Shuffle IEnumerable
- [PickRandom](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Pick N random elements from IEnumerable
- [ThisOrEmpty](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Safe foreach and more, returns an empty Enumerable if source is null
<a name="ilist"></a>

### IList extension methods:
 - [ChunkBy](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IListExtensions.cs) - Chunk a list to smaller lists with a maximum capacity of the chunk size
 - [Clone](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IListExtensions.cs) - Clone an collection to new IList
 - [Push](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IListExtensions.cs) - Adds an object to the collection and return this collection for fluent api
 - [GetPermutations](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IListExtensions.cs) - Get all permutations for this List

## POCO extension methods (Namespace - Pylypeiev.Extensions):

<a name="bool"></a>

### bool extension methods:
- [ToYesNo](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Bool/BoolExtensions.cs) - convert a boolean value to string representation

<a name="byte"></a>

### ByteArray extension methods:
- [ToBase64String](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/ByteArray/ByteArrayExtensions.cs) - Converts an byte array to its equivalent string representation that is encoded with base-64.

<a name="datetime"></a>

### DateTime extension methods:
- [Between](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/DateTime/DateTimeExtensions.cs) - Check if date is between 2 dates. Inclusive
- [CalculateAge](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/DateTime/DateTimeExtensions.cs) - > Calculate age
- [GetTime](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/DateTime/DateTimeExtensions.cs) - Get time in numbers format
- [IsFuture](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/DateTime/DateTimeExtensions.cs) - Check if this date is future
- [IsPast](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/DateTime/DateTimeExtensions.cs) - Check if this date is past
- [IsDefault](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/DateTime/DateTimeExtensions.cs) - Check if this DateTime is default, empty value

<a name="decimal"></a>

### decimal extension methods:
- [Abs](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Decimal/DecimalExtensions.cs) - Returns the absolute value of this number
- [Ceiling](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Decimal/DecimalExtensions.cs) - Returns the smallest integral value that is greater than or equal to the specified number
- [Floor](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Decimal/DecimalExtensions.cs) - Returns the largest integral value that is greater than or equal to the specified number
- [GetPercentage](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Decimal/DecimalExtensions.cs) - Calculate percentage from this number
- [IsBetween](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Decimal/DecimalExtensions.cs) - Check if this number is between 2 numbers
- [Max](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Decimal/DecimalExtensions.cs) - Returns the larger of two numbers
- [Min](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Decimal/DecimalExtensions.cs) - Returns the smaller of two numbers
- [Round](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Decimal/DecimalExtensions.cs) - Rounds a decimal value to the nearest integral value
- [Plus](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Decimal/DecimalExtensions.cs) - Add a number to this number
- [Minus](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Decimal/DecimalExtensions.cs) - Subtract a number from this number
- [DivideBy](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Decimal/DecimalExtensions.cs) - Divide this number by given number
- [MultiplyBy](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Decimal/DecimalExtensions.cs) - Multiply this number by given number

<a name="double"></a>

### double extension methods:
- [Abs](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Double/DoubleExtensions.cs) - Returns the absolute value of this number
- [Ceiling](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Double/DoubleExtensions.cs) - Returns the smallest integral value that is greater than or equal to the specified number
- [Floor](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Double/DoubleExtensions.cs) - Returns the largest integral value that is greater than or equal to the specified number
- [GetPercentage](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Double/DoubleExtensions.cs) - Calculate percentage from this number
- [IsBetween](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Double/DoubleExtensions.cs) - Check if this number is between 2 numbers
- [Max](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Double/DoubleExtensions.cs) - Returns the larger of two numbers
- [Min](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Double/DoubleExtensions.cs) - Returns the smaller of two numbers
- [Round](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Double/DoubleExtensions.cs) - Rounds a decimal value to the nearest integral value
- [Plus](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Double/DoubleExtensions.cs) - Add a number to this number
- [Minus](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Double/DoubleExtensions.cs) - Subtract a number from this number
- [DivideBy](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Double/DoubleExtensions.cs) - Divide this number by given number
- [MultiplyBy](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Double/DoubleExtensions.cs) - Multiply this number by given number

<a name="float"></a>

### float extension methods:
- [Abs](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Float/FloatExtensions.cs) - Returns the absolute value of this number
- [GetPercentage](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Float/FloatExtensions.cs) - Calculate percentage from this number
- [IsBetween](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Float/FloatExtensions.cs) - Check if this number is between 2 numbers
- [Max](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Float/FloatExtensions.cs) - Returns the larger of two numbers
- [Min](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Float/FloatExtensions.cs) - Returns the smaller of two numbers
- [Plus](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Float/FloatExtensions.cs) - Add a number to this number
- [Minus](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Float/FloatExtensions.cs) - Subtract a number from this number
- [DivideBy](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Float/FloatExtensions.cs) - Divide this number by given number
- [MultiplyBy](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Float/FloatExtensions.cs) - Multiply this number by given number

<a name="int"></a>

### int extension methods:
- [GetPercentage](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Int/IntExtensions.cs) - Calculate percentage from this number
- [IsBetween](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Int/IntExtensions.cs) - Check if this number is between 2 numbers
- [Max](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Int/IntExtensions.cs) - Returns the larger of two numbers
- [Min](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Int/IntExtensions.cs) - Returns the smaller of two numbers
- [ToFileSize](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Int/IntExtensions.cs) - Format file size in KB/MB/GB/TB/PB/EB
- [Plus](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Int/IntExtensions.cs) - Add a number to this number
- [Minus](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Int/IntExtensions.cs) - Subtract a number from this number
- [DivideBy](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Int/IntExtensions.cs) - Divide this number by given number
- [MultiplyBy](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Int/IntExtensions.cs) - Multiply this number by given number

<a name="long"></a>

### long extension methods:
- [GetPercentage](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Long/LongExtensions.cs) - Calculate percentage from this number
- [IsBetween](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Long/LongExtensions.cs) - Check if this number is between 2 numbers
- [Max](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Long/LongExtensions.cs) - Returns the larger of two numbers
- [Min](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Long/LongExtensions.cs) - Returns the smaller of two numbers
- [ToFileSize](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Long/LongExtensions.cs) - Format file size in KB/MB/GB/TB/PB/EB
- [Plus](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Long/LongExtensions.cs) - Add a number to this number
- [Minus](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Long/LongExtensions.cs) - Subtract a number from this number
- [DivideBy](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Long/LongExtensions.cs) - Divide this number by given number
- [MultiplyBy](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Long/LongExtensions.cs) - Multiply this number by given number


<a name="object"></a>

### object extension methods:
- [GetPropertiesWithValues](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Object/ObjectExtensions.cs) - Get properties and values of this object using reflection
- [IfNotNull](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Object/ObjectGeneralExtensions.cs) - Perform action/function on the object if it not null 
- [IsDefaultValue](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Object/ObjectGeneralExtensions.cs) - Check if object equals to its a default value
- [IsIn](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Object/ObjectGeneralExtensions.cs) - Determines if an object is contained in a sequence
- [IsNotNull](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Object/ObjectGeneralExtensions.cs) - Check if object is NOT null
- [IsNull](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Object/ObjectGeneralExtensions.cs) - Check if object is null
- [ToStringSafe](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Object/ObjectGeneralExtensions.cs) - like ToString of the object, but not crushes if the object is null 
- [Try](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Object/ObjectGeneralExtensions.cs) - Try to perform action/function on object
- [Yield](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Object/ObjectGeneralExtensions.cs) - Wraps this object instance into an IEnumerable, consisting of a single item
- [DeepCopy](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Object/ObjectGeneralExtensions.cs) - Deep copy of object using BinaryFormatter

<a name="string"></a>

### string extension methods:
- [ToDateTime](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringParsingExtensions.cs) - Convert to DateTime
- [ToDecimal](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringParsingExtensions.cs) - Convert to decimal
- [ToDouble](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringParsingExtensions.cs) - Convert to double
- [ToFloat](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringParsingExtensions.cs) - Convert to float
- [ToInt](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringParsingExtensions.cs) - Convert to int
- [ToLong](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringParsingExtensions.cs) - Convert to long
- [ToByteArray](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringParsingExtensions.cs) - Converts a string into an byte array
- [DecodeBase64](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringEncodingExtensions.cs) - Decodes a string encoded in base-64
- [EncodeBase64](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringEncodingExtensions.cs) - Encodes a string to its equivalent string representation that is encoded in base-64
- [ToMd5](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringEncodingExtensions.cs) - Computes MD5 hash of a string.
- [RemoveFirst](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringOperationsExtensions.cs) - Remove the number of characters at the start of this string
- [RemoveFirstCharacter](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringOperationsExtensions.cs) - Remove the first character of this string
- [RemoveLast](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringOperationsExtensions.cs) - Remove the number of characters at the end of this string
- [RemoveLastCharacter](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringOperationsExtensions.cs) - Remove the last character of this string
- [Reverse](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringOperationsExtensions.cs) - Reverse the sequence of characters in this string
- [SplitCamelCase](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringOperationsExtensions.cs) - Split CamelCase words
- [SurroundWith](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringOperationsExtensions.cs) - Surround this string with some string
- [ToTitleCase](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringOperationsExtensions.cs) - Converts the specified string to title case
- [TrimSafe](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringOperationsExtensions.cs) - Performs a trim only if the item is not null
- [ToLowerSafe](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringOperationsExtensions.cs) - Performs ToLower() only if input is not null
- [ToLowerInvariantSafe](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringOperationsExtensions.cs) - Performs ToLowerInvariant() only if input is not null
- [ToUpperSafe](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringOperationsExtensions.cs) - Performs ToUpper() only if input is not null
- [ToUpperInvariantSafe](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringOperationsExtensions.cs) - Performs ToUpperInvariant() only if input is not null
- [EndsWithIgnoreCase](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringSearchingExtensions.cs) - Determines whether the end of this string matches the specified string
- [EqualsIgnoreCase](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringSearchingExtensions.cs) - Determines whether two specified strings have the same value
- [IfNullThen](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringSearchingExtensions.cs) - Determines if the string is null or whitespace if yes returns nullAlternateValue
- [IsAlpha](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringSearchingExtensions.cs) - Determines if this string contains only English letters 
- [IsAlphaNumeric](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringSearchingExtensions.cs) - Determines if this string contains only English letters and digits
- [IsNullOrEmpty](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringSearchingExtensions.cs) - Indicates whether this string is null or an empty string
- [IsNullOrWhiteSpace](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringSearchingExtensions.cs) - Indicates whether this string is null, empty, or consists only of white-space characters 
- [IsNumeric](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringSearchingExtensions.cs) - Determines if this string contains only digits
- [IsPalindrome](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringSearchingExtensions.cs) - Check if this string is a palindrome
- [IsValidEmail](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringSearchingExtensions.cs) - Determines if this string is a valid email address
- [IsValidIP](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringSearchingExtensions.cs) - Determines if this string is a valid IP address
- [NthIndexOf](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringSearchingExtensions.cs) - Reports the index of matched string regards to occurrenceNum
- [OccurrenceNum](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringSearchingExtensions.cs) - Reports the numbers of matches in this string
- [StartsWithIgnoreCase](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringSearchingExtensions.cs) - Determines whether the beginning of this string matches the specified string
- [ContainsInvariantSafe](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringSearchingExtensions.cs) - String.Contains with StringComparison parameter 
- [SaveAs](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/String/StringIOExtensions.cs) - write string to file

<a name="char"></a>

### char extension methods:
- [EqualsIgnoreCase](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Char/CharExtensions.cs) - Determines whether two specified chars have the same value

<a name="exception"></a>

### Exception extension methods:
- [GetInnermostException](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Exception/ExceptionExtensions.cs) - Get the innermost exception from this exception
- [GetInnerExceptions](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Objects%20Extensions/Exception/ExceptionExtensions.cs) - Get list of inner exceptions from this exception

<a name="xml"></a>

## XML objects extension methods (Namespace - Pylypeiev.Extensions.Xml):
- [XmlSerialize](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/XML%20Extensions/XmlExtensions.cs) - Serialize object to XML
- [TryXmlDeserialize](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/XML%20Extensions/XmlExtensions.cs) - Try to deserialize xml
### XmlDocument extension methods:
- [ToXDocument](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/XML%20Extensions/XmlExtensions.cs) - Convert XmlDocument to XDocument  
- [ToStream](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/XML%20Extensions/XmlExtensions.cs) - Convert XmlDocument to Stream  
### Xml.Linq extension methods:
- [ToXmlDocument](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/XML%20Extensions/XmlExtensions.cs) - Convert XDocument/XElement to XmlDocument 
