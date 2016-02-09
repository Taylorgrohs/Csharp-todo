using Nancy;
using Todo.Objects;
using System.Collections.Generic;


namespace ToDoList
{
  public class HomeModule : NancyModule
  {
      public HomeModule()
      {
        Get["/"] = _ => View["/add_new_task.cshtml"];
        Get["/view_all_task"] = _ =>
        {
          List<string> allTasks = Tasks.viewTodo();
          return View["view_all_task.cshtml", allTasks];
        };

        Post["/task_added"] = _ =>
        {
          Tasks newTask = new Tasks (Request.Form["new-task"]);
          newTask.AddTodo();
          return View["task_added.cshtml", newTask];
        };
        Post["/tasks_cleared"] = _ => {
          Tasks.ClearAll();
          return View["tasks_cleared.cshtml"];
        };
      }
  }
}
