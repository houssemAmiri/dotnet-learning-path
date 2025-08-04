### 🔸  LINQ (Language Integrated Query) (2 hours)

**🧠 Focus On:**

- Think of LINQ as `map/filter/reduce` for .NET
- Works on arrays, lists, databases

**👨‍💻 Example:**

```csharp
var tasks = new List<string> { "Do laundry", "Write code", "Eat" };
var shortTasks = tasks.Where(t => t.Length < 10).ToList();
```

- Learn: `.Where()`, `.Select()`, `.Any()`, `.FirstOrDefault()`
- LINQ to objects vs LINQ to entities (you’ll use both)

**Resources:**

- ✅ [LINQ for JS Devs](https://blog.submain.com/linq-for-javascript-developers/)