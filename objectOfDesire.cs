#using System;

namespace DatingProfile
{
    class Profile
    {
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        public Profile(
          string name,
          int age,
          string city,
          string country,
          string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[0];
        }

        public string ViewProfile()
        {
            string bio = $"Name: {name}\nAge : {age}\nCity : {city}\nCountry : {country}\nPronouns : {pronouns}";

            bio += "\nHobbies : \n";
            foreach (string hobby in hobbies)
            {
                bio += $"- {hobby}\n";
            }

            return bio;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }

    }
}


// a C# program modelling the set up of a matchmaking application. 

using System;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
            sam.SetHobbies(new string[]
            {
       "listening to audiobooks and podcasts",
       "playing rec sports like bowling and kickball",
       "writing a novel",
       "reading advice columns"
            });
            Console.WriteLine(sam.ViewProfile());
        }
    }
}
