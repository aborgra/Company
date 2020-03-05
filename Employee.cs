using System;

namespace classes {
  public class Employee {

    // Some readonly properties (let's talk about gets, baby)
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Title { get; set; }

    public DateTime StartDate { get; } = DateTime.Now;

    public Employee (string firstName, string lastName, string title) {
      FirstName = firstName;
      LastName = lastName;
      Title = title;
    }
  }
}