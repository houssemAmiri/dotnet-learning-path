## ⚡ Step 0: Crash Course in C# (1–2 Days)

### 🎯 Goal:

Quickly build **fluency in C# syntax and idioms** using your JS/TS experience as a foundation. Focus only on concepts essential for real-world .NET backend development.

---

## 🗂️ Plan Overview

| Topic                                      | Time    | Format               | Outcome                      |
| ------------------------------------------ | ------- | -------------------- | ---------------------------- |
| 1. C# Syntax Deep Dive (w/ JS Comparisons) | 3 hrs   | Code + Cheat Sheets  | Fluent syntax mapping        |
| 2. Classes, Interfaces, and OOP            | 2 hrs   | Code + Practice      | Solid OOP foundation         |
| 3. Async/Await and Tasks                   | 1.5 hrs | Code + Comparison    | Confident with async in .NET |
| 4. LINQ Basics                             | 2 hrs   | Practice + Analogies | Master collection querying   |
| 5. EF Core Primer (Entity Modeling)        | 2 hrs   | Docs + Code          | Prepared for Step 1          |
| 6. .NET CLI Basics                         | 1 hr    | Practice             | Tooling ready                |

---

## 📅 DAY 1: C# Core Syntax + OOP Patterns

---

### 🔸 1. C# Syntax for JS/TS Developers (3 hours)

**🧠 Focus On:**

- Strong typing (`int`, `string`, `List<T>`, `bool`)
- Value types vs reference types
- Properties and automatic getters/setters
- `using` (like `import`) and namespaces
- Type inference with `var`
- Control flow (`if`, `switch`, `for`, `foreach`)
- Nullable types: `int?`, `string?`

**👨‍💻 Exercise:**

| JS/TS                      | Equivalent in C#                         |
| -------------------------- | ---------------------------------------- |
| `let x = 5;`               | `int x = 5;`                             |
| `const items = [1, 2, 3];` | `var items = new List<int> { 1, 2, 3 };` |
| `function greet(name) {}`  | `void Greet(string name) {}`             |
| `export default`           | `public class ...` + `namespace`         |
| `?.`                       | `?.` (same!)                             |
| `??`                       | `??` (same!)                             |

**Resources:**

- ✅ [C# for JS Developers Cheat Sheet](https://www.linkedin.com/pulse/c-javascript-developers-cheat-sheet-milosz-misiewicz/)
- ✅ [Tour of C#](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/)

---

### 🔸 2. OOP in C# (2 hours)

**🧠 Focus On:**

- `class`, `interface`, `abstract`, `inheritance`
- Access modifiers: `public`, `private`, `protected`
- Method overloading vs overriding
- Constructors and initialization
- Generics: `List<T>`, `Dictionary<TKey, TValue>`

**👨‍💻 Exercise:**

Create an example:

```csharp
public interface IAnimal {
    void Speak();
}

public class Dog : IAnimal {
    public void Speak() => Console.WriteLine("Woof!");
}
```

- Implement classes
- Inject interfaces
- Override methods

---

### 🔸 3. Properties & Auto-Properties (30 min)

```csharp
public class User {
    public string Name { get; set; }
    public int Age { get; private set; }

    public User(string name, int age) {
        Name = name;
        Age = age;
    }
}
```

- Compare to TS: `class User { constructor(public name: string) {} }`
- Learn when to use `get; private set;` for immutability

---

## 📅 DAY 2: Async, LINQ, and EF Core Basics

---

### 🔸 4. Async/Await + Task (1.5 hours)

**🧠 Focus On:**

- `Task` and `Task<T>` = like `Promise`
- `async/await` in C#
- Exception handling: `try/catch/finally`
- `HttpClient` usage

**👨‍💻 Example:**

```csharp
public async Task<string> FetchDataAsync() {
    var client = new HttpClient();
    return await client.GetStringAsync("https://api.example.com/data");
}
```

**Compare to JS:**

```ts
async function fetchData() {
  const res = await fetch("...");
}
```

---

### 🔸 5. LINQ (Language Integrated Query) (2 hours)

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

---

### 🔸 6. Entity Framework Core Preview (2 hours)

**🧠 Focus On:**

- What is an ORM?
- What is DbContext and DbSet?
- Migration vs Seeding vs CRUD
- EF Core annotations: `[Key]`, `[Required]`, `[ForeignKey]`

**👨‍💻 Example:**

```csharp
public class AppDbContext : DbContext {
    public DbSet<TaskItem> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=tasks.db");
}
```

**Tools:**

```bash
dotnet ef migrations add Init
dotnet ef database update
```

**Don’t build a full app yet — just explore how models + DbContext interact.**

---

### 🔸 7. .NET CLI Basics (1 hour)

**🧠 Learn:**

- `dotnet new console -n AppName`
- `dotnet build`, `dotnet run`, `dotnet add package`
- What’s in a `.csproj` file
- NuGet packages (like npm)

---

## 🎓 Day 2 Wrap-Up Challenge

Rebuild this in C#:

```ts
const todos = ["Task 1", "Task 2", "Task 3"];
todos.forEach((todo, i) => {
  console.log(`${i + 1}: ${todo}`);
});
```

➡️ In C#:

```csharp
var todos = new List<string> { "Task 1", "Task 2", "Task 3" };
for (int i = 0; i < todos.Count; i++)
    Console.WriteLine($"{i + 1}: {todos[i]}");
```

---

## 🧪 Optional Practice Resources

- [dotnetfiddle.net](https://dotnetfiddle.net/) — Play with snippets in browser
- [CodeWars – C#](https://www.codewars.com/collections/c-tutorial-for-js-devs) — Short katas
- [Interactive C# Tutorial](https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/) — Try C# in-browser

---
