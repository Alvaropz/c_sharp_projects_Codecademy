using System;

namespace DatingProfile
{ 
  class Profile {
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    public Profile(string name, int age, string city, string country, string pronouns="they/them"){
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      this.hobbies = new string[0];
      }

      public string ViewProfile()
      {
        string bio = $"Hi! My name is {this.name}, I'm {this.age} years old and I live in {this.city}, {this.country}. You can refere to me as '{this.pronouns}'.";
        if (this.hobbies.Length > 0) {
          string myhobbies = string.Join(", ", this.hobbies);
          bio += $" My hobbies are {myhobbies}.";
        }
        return bio;
      }

      public void SetHobbies(string[] hobbies)
      {
        this.hobbies = hobbies;
      }
  }
}
