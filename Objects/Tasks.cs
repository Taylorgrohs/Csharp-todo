using System;
using System.Collections.Generic;

namespace Todo.Objects
{
  public class Tasks
  {
    private string Description;
    private static List<string> todo = new List<string>{};


    public Tasks(string newDescription)
    {
      SetDescription(newDescription);
    }

    public void SetDescription(string newDescription)
    {
      Description = newDescription;
    }

    public string GetDescription()
    {
      return Description;
    }

    public void AddTodo()
    {
      todo.Add(GetDescription());
    }

    public static List<string> viewTodo()
    {
      return todo;
    }
    public static void ClearAll()
    {
      todo.Clear();
    }
  }
}
