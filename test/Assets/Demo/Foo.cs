using System;
using SQLite;

public class Foo
{
  public int Id { get; set; }
  public string Name { get; set; }

  public override string ToString()
  {
    return $"Foo: {Id}: {Name}";
  }
}