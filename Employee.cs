namespace SkunkWorx
{
  class Employee
  {
    public string FirstName;
    public string LastName;
    public int Id;
    public string PhotoURL;

    public Employee(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
    }
    public string GetName()
    {
      return $"{this.FirstName} {this.LastName}";
    }
  }
}