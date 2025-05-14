
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

// ************************************  int *************************************
Console.WriteLine("******************int type example***********************");
int age = 30;
Console.WriteLine($"Hello, you are {age} years old.");
// int age = "30"; // This will cause a compile-time error because "30" is a string, not an int



// int is an alisas for System.Int32
// it's a value type stocked on the stack and copied by value
int a = 5;
int b = a;
b = 10; // b is now 10, a is still 5
// int is a value type, so it is copied by value
Console.WriteLine($"a: {a}, b: {b}"); // Output: a: 5, b: 10
// If you pass an int into a method, the method receives a copy of the value

// If you want to modify the original int, you must pass it by reference using ref.



// If you define a class that has an int field:
// The Person object is on the heap.
// But the Age field (an int) is still a value type, so it lives inside the object on the heap, not on the stack.
// But still, it behaves like a value type: changing one object’s Age doesn’t affect another.

var p1 = new Person();
p1.Age = 30;
var p2 = new Person();
p2.Age = 40;

Console.WriteLine($"p1.Age: {p1.Age}, p2.Age: {p2.Age}"); // Output: p1.Age: 30, p2.Age: 40


// ************************************  string *************************************
Console.WriteLine("------------------------------------------------------------------");

Console.WriteLine("******************string type example***********************");
// string is an alias for System.String.
string name = "John"; // it's the same thing System.String name = "Alice";
Console.WriteLine($"Hello, {name}!");



// string name = 42; // ❌ Compile-time error: Cannot implicitly convert type 'int' to 'string'

// System.String is a reference type , System.String is a Class
// Stored on the heap
// Passed by reference
// Supports methods and properties

string s = "Hello";
Console.WriteLine(s.ToUpper()); // Outputs: HELLO
s.Concat(" World"); // This does not change s, because strings are immutable
Console.WriteLine(s); // Outputs: Hello
Console.WriteLine(System.String.Concat(s, " world")); // hello world

Console.WriteLine(s.Length); // Outputs: 5
Console.WriteLine(s.GetType()); // System.String

string fullName = "John" + " " + "Doe"; // Concatenation
Console.WriteLine(fullName); // Outputs: John Doe
string message = string.Concat("Hello", " ", "World"); // Using String.Concat
Console.WriteLine(message); // Outputs: Hello World
var firstName = "John";
var lastName = "Doe";
string sentence = $"{firstName} {lastName}"; // String interpolation
// String interpolation is a way to create strings that include variables or expressions
Console.WriteLine(sentence); // Outputs: John Doe


StringBuilder sb = new StringBuilder();
sb.Append("Hello");
sb.Append(" World");

string result = sb.ToString();
Console.WriteLine(result); // Outputs: Hello World

// strings are immutable, so when you concatenate strings, a new string is created in memory.
// This is not efficient for large strings or many concatenations.
// StringBuilder is mutable, so it can be modified without creating a new object in memory.
// StringBuilder is more efficient for large strings or many concatenations.
// StringBuilder is mutable, so it can be modified without creating a new object in memory.
// StringBuilder is more efficient for large strings or many concatenations.
// StringBuilder is mutable, so it can be modified without creating a new object in memory.
// StringBuilder is more efficient for large strings or many concatenations.
// here you create multiple intermediate strings.
string text = "test";
text += " ";
text += "Text";

Console.WriteLine(text); // Outputs: Hello World

// What happens:
// Each += allocates a new string

// Thousands of strings get created and discarded

// Lots of GC (garbage collection) work

string textConcatinated = "";
for (int i = 0; i < 1000; i++)
{
    textConcatinated += i.ToString();
}

Console.WriteLine(textConcatinated);

// Best Practice: Use StringBuilder

StringBuilder sb2 = new StringBuilder();
for (int i = 0; i < 1000; i++)
{
    sb2.Append(i.ToString());
}
Console.WriteLine(sb2.ToString());

Console.WriteLine(string.Concat("A", "B", "C")); // Outputs: ABC
Console.WriteLine(string.Join(",", "A", "B", "C")); // Outputs: A, B, C

// String Interning
/*
String interning is a memory optimization feature where the CLR stores only one copy of each unique string
literal in a special pool, called the intern pool.
If multiple variables are assigned the same literal value, they all point to the same memory location.
*/

string a1 = "hello";
string b1 = "hello";

Console.WriteLine(object.ReferenceEquals(a1, b1)); // ✅ True

//  Compile-Time vs Runtime Concatenation

// Compile-Time Concatenation
// The compiler can optimize string literals that are known at compile time.
// This means that if you concatenate string literals, the compiler can create a single string at compile time.
// Because the compiler evaluates this at compile time, it becomes "hello" — which is interned.
string a2 = "hel" + "lo"; // known at compile time
string b2 = "hello";

Console.WriteLine(object.ReferenceEquals(a2, b2)); // ✅ True
// Runtime Concatenation
// The compiler cannot optimize string concatenation that involves variables or expressions.
string part = "hel";
string a3 = part + "lo"; // not known at compile time
string b3 = "hello";
Console.WriteLine(object.ReferenceEquals(a3, b3)); // ❌ False
// In this case, a3 is not interned because it is created at runtime.
// So, a3 and b3 point to different memory locations.
// String interning only applies to string literals, not to strings created at runtime.

string part1 = "hel";
string a4 = part1 + "lo"; // not known at compile time
string b4 = "hello";
string a4Interned = string.Intern(a4); // Interning a4
Console.WriteLine(object.ReferenceEquals(a4Interned, b4)); // ✅ True
// Now a4Interned points to the same memory location as b4.
// String interning is a memory optimization technique used by the CLR to save memory and improve performance.
// It applies only to string literals, not to strings created at runtime.
/*

✅ Pros:
Memory optimization: identical strings are stored once.

Fast equality: object.ReferenceEquals(a, b) is faster than a == b.

❌ Cons:
Interned strings stay alive for the life of the app → can cause memory leaks if abused.

Only useful when there are lots of duplicate strings.


📊 Performance Tip
Use interning only when:

- You're working with tons of repeated string values (e.g., log levels, tags, status codes).

- You need fast reference equality checks.

Avoid interning:

- Large unique strings

- Long-lived systems where memory must be tightly managed


*/

// How Can You “Change” a String?


string ss = "abc";
ss = ss.Replace("a", "F"); // This creates a new string
Console.WriteLine(ss); // Outputs: Fbc


Console.WriteLine("------------------------------------------------------------------");


Console.WriteLine("******************List<T>***********************");


List<int> numbers = new List<int>();
Console.WriteLine(numbers.Capacity); // Outputs: 0
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.AddRange(new int[] { 4, 5, 6 }); // AddRange adds multiple elements at once
numbers.Insert(0, 0); // Insert adds an element at a specific index
numbers.Remove(2); // Remove removes the first occurrence of the specified value
numbers.RemoveAt(0); // RemoveAt removes the element at the specified index
numbers.Clear(); // Clear removes all elements from the list
numbers.Add(1);
bool exists = numbers.Contains(1); // Contains checks if the list contains the specified value
Console.WriteLine(exists); // Outputs: True
numbers.Sort(); // Sort sorts the elements in ascending order
numbers.Reverse(); // Reverse reverses the order of the elements
numbers.Sort((x, y) => x.CompareTo(y)); // Sort with a custom comparison function
Console.WriteLine(numbers.Capacity); // Outputs: 8

// numbers.Add("hello"); // ❌ Compile-time error: Argument type 'string' doesn't match 'int'

Console.WriteLine($"count: {numbers.Count}"); // Outputs: 1

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

List<string> names = new List<string>();
names.Add("Alice");
names.Add("Bob");
names.Add("Charlie");
// names.Add(42); // ❌ Compile-time error: Argument type 'int' doesn't match 'string'
Console.WriteLine(names.Count); // Outputs: 3
foreach (var nameElement in names)
{
    Console.WriteLine(nameElement);
}




List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5 };
List<string> names2 = new List<string> { "Alice", "Bob", "Charlie" };

List<Person> people = new List<Person>();
people.Add(new Person { Age = 30 });
people.Add(new Person { Age = 40 });
people.Add(new Person { Age = 50 });
foreach (var person in people)
{
    Console.WriteLine(person.Age);
}


/*

✅ Avoid Remove in Loops
Removing items inside a loop leads to index shifting.

Use list.RemoveAll() for bulk removal.

*/


numbers.RemoveAll(x => x > 3); // Remove all elements greater than 3

/*
✅ Use Sort and BinarySearch for Efficient Searches
If your list is sorted, you can use binary search:

*/


numbers.Sort(); // Sort the list first
int index = numbers.BinarySearch(3); // Binary search for the value 3
Console.WriteLine(index); // Outputs: index of the value 3 or -1 if not found






// classes here
class Person
{
    public int Age;
}