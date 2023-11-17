# Simple HTTP Query (Shq)

<p align="center">
  Query over http with UI library to provide simple interface for querying a database (NOT IT'S NOT A DIRECT SQL QUERY) with security layer.
</p>

<h1 align="center">
  <br>
  <img src="banner.png" alt="shq-logo" width="500">
  <br>
</h1>

## Expectation *Query Mapper* 

On endpoint `api/shq/car` given below query parameter

```
  "color = red AND model = 2023"
```

It should produce below LINQ context

```csharp
  (x => x.color.Contains("red") && x.model = 2023) 
```

Also provides UI library for auto-complete and query building advisor

<br/>

> ℹ️ Not Close To Completion

<br/>

It should be fun to fool around with `lexical analysis`.
