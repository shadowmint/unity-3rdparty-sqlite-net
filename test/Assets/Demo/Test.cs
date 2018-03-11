using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
  public Text Log;

  // Use this for initialization
  void Start()
  {
    Trace("Opening connection");
    var db = new SQLiteConnection(":memory:");

    Trace("Applying migrations");
    db.Execute("CREATE TABLE Foo (ID INT PRIMARY KEY     NOT NULL, NAME           TEXT    NOT NULL)");

    Trace("Inserting record");
    var Id = db.Insert(new Foo()
    {
      Name = "Hello World",
    });

    Trace("Getting record");
    var mapping = new TableMapping(typeof(Foo));
    var result = db.Query(mapping, "select * from Foo where Name = 'Hello World'", 1);

    Trace(result.FirstOrDefault()?.ToString());
  }

  private void Trace(string message)
  {
    Log.text += "\n" + message;
  }
}