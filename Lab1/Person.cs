using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Person
    {
        //private data
        private int personId;
        private string firstName;
        private string lastName;
        private string favouriteColour;
        private int age;
        private bool isWorking;

        //public properties
        public string FavouriteColour 
            {
            get { return favouriteColour; }
            set {favouriteColour = value; }

            }
        //constructor
        public Person(int personId, string firstName, string lastName,string favouriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.FavouriteColour = favouriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }

        // methods
        public string DisplayPersonInfo()
        {
            return $"{personId}: {firstName} {lastName}'s favourite colour is {favouriteColour}";
        }

        public string ChangeFavouriteColour()
        {
            FavouriteColour = "White";
            return FavouriteColour;
        }
        
        public int GetAgeInTenYears()
        {
            return age + 10;
        }

        public override string ToString() 
        {
            return $"PersonID: {personId} \nFirstName: {firstName} \nLastName: {lastName} \nFavouriteColour: {FavouriteColour} \nAge: {age} \nIsWorking{isWorking}";
        }

    } //class
}
