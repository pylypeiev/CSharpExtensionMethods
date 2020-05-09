# C# Extension Methods
My C# Extension methods for collections and simple objects. Enjoy! :collision:

## You can install it via [ NUGET ](https://www.nuget.org/packages/Pylypeiev.Extensions)  :hammer: or make a [ COPY ](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Minimal%20Pack.cs) 

## Table of Contents:
#### Collections extension methods:
- [Array](#array)
- [Dictionary](#dictionary)
- [ICollection](#icollection)
- [IEnumerable](#ienumerable)
- [IList](#ilist)
#### POCO extension methods:
#### XML objects extension methods:


## Collections extension methods:
<a name="array"></a>

### Array extension methods
- [Join](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/ArrayExtensions.cs) -  Concatenates the elements of an object array, using the specified separator between each element
- [Clear](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/ArrayExtensions.cs) - Sets a range of elements in an array to the default value of each element type.

<a name="dictionary"></a>

### Dictionary extension methods
- [AddIfNotContainsKey](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/DictionaryExtensions.cs) - Add an element with provided key to dictionary if this key is not exist yet
- [AddOrUpdate](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/DictionaryExtensions.cs) - Add an element with provided key to dictionary, if this key is exist - update value

<a name="icollection"></a>

### ICollection extension methods
- [IsNullOrEmpty](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/ICollectionExtensions.cs) - Check if collection is null or empty 
- [AddRange](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/ICollectionExtensions.cs) - Adds the elements of the specified Array to the end of the collection
- [AddIfNotContains](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/ICollectionExtensions.cs) - Add an element to the end of the collection if this value is not exist yet
- [RemoveRange](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/ICollectionExtensions.cs) - Removes a range of elements from collection


<a name="ienumerable"></a>

### IEnumerable extension methods
- [ForEach](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Performs the specified action on each element of the IEnumerable
- [Join](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Concatenates the elements of an IEnumerable, using the specified separator between each element
- [AreAllSame](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Check if all elements in IEnumerable are equals
- [Append](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Add the object top the end of IEnumerable
- [Prepend](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Add the object at the beginning of IEnumerable
- [IsEmpty](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Check if IEnumerable is empty
- [IsNotEmpty](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Check if IEnumerable is not empty 
- [IsNullOrEmpty](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Check if IEnumerable is null or empty
- [Concatenate<string>](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IEnumerableExtensions.cs) - Concatenates the elements of an IEnumerable<string> to 1 string

<a name="ilist"></a>

### IList extension methods
 - [Clone](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IListExtensions.cs) - Clone an collection to new IList
 - [Push](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IListExtensions.cs) - Adds an object to the collection and return this collection for fluent api
 - [ChunkBy](https://github.com/pylypeiev/CSharpExtensionMethods/blob/master/Pylypeiev.Extensions/Collections%20extensions/IListExtensions.cs) - Chunk a list to smaller lists with a maximum capacity of the chunk size

## POCO extension methods:
## XML objects extension methods:
