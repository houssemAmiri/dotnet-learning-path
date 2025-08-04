### 🔸 Async/Await + Task (1.5 hours)

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