using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Relation
    {
        string[] relationships = { "Brother", "Sister", "Mother", "Father" };
        private string RelationshipType;
        private Person relatedPerson;
        //constructor
        public Relation(string relationshipType) 
        {
            //foreach (string relationship in relationships)
            //{
            //    if (relationship == relationshipType)
            //    {
            //        RelationshipType = relationshipType;
            //    }
            //}
            //if (relationshipType not in relationship){
            //    RelationshipType = "Unrelated";
            //}
            if (relationships.Contains(relationshipType))
            {
                RelationshipType = relationshipType;
            }
            else
            {
                RelationshipType = "Unrelated";
            }
        } //constructor

        public string ShowRelation(Person pers1, Person pers2)
        {
            return $"Relationship between {pers1.FirstName} and {pers2.FirstName} is: {RelationshipType}hood";
        }
    } //class
}
