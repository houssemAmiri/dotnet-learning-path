### 🔸  OOP in C# (2 hours)

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

### 🔸  Properties & Auto-Properties (30 min)

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
