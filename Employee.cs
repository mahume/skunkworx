namespace SkunkWorx
{
  class Employee
  {
    private string FirstName;
    private string LastName;
    private int Id;
    private string PhotoURL;

    public Employee(string firstName, string lastName, int id, string photoUrl)
    {
      FirstName = firstName;
      LastName = lastName;
      Id = id;
      PhotoURL = photoUrl;
    }
    public string GetName()
    {
      return $"{FirstName} {LastName}";
    }
    public int GetId()
    {
      return Id;
    }
    public string GetPhotoURL()
    {
      return PhotoURL;
    }
  }
}