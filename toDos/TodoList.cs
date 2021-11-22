using System;

namespace SavingInterface
{
  class TodoList : IDisplayable, IResetable
  {
    public string[] Todos
    { get; private set; }

    private int nextOpenIndex;

    public TodoList()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }

    public void Add(string todo)
    {
      Todos[nextOpenIndex] = todo;
      nextOpenIndex++;
    }
    //Define a method that satisfies the interface requirements
    public void Display()
    {
      foreach (string s in Todos)
      Console.WriteLine(s);
    }
    
    //Define a method to satisfy the interface.
    public void Reset()
    {
      Todos = new string[5];
      nextOpenIndex = 0;    
    }
  }
}