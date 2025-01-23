using Lab1;

Person ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
Person gina = new Person(2, "Gina", "James", "Green", 18, false);
Person mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
Person mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

Console.WriteLine(gina.DisplayPersonInfo());
Console.WriteLine(mike);
ian.ChangeFavouriteColour();
Console.WriteLine(ian.DisplayPersonInfo());
Console.WriteLine($"{mary.FullName}'s age in 10 years is: {mary.GetAgeInTenYears()}");
Console.WriteLine(" ");

Relation sister = new Relation("Sister");
Console.WriteLine(sister.ShowRelation(gina, mary));

Relation brother = new Relation("Brother");
Console.WriteLine(brother.ShowRelation(ian, mike));
Console.WriteLine(" ");

List<Person> personsList = new List<Person>();
personsList.Add(ian);
personsList.Add(gina);
personsList.Add(mike);
personsList.Add(mary);

double totalAge = 0;
double averageAge = 0;
foreach (Person person in personsList)
{
    totalAge += person.Age;
}
averageAge = totalAge / personsList.Count;
Console.WriteLine($"Average age is: {averageAge}");

Person youngestPerson = personsList[0];
foreach (Person person in personsList)
{
    if (person.Age < youngestPerson.Age)
    {
        youngestPerson = person;
    }
}
Console.WriteLine($"The youngest person is: {youngestPerson.FirstName}");

Person oldestPerson = personsList[0];
foreach (Person person in personsList)
{
    if (person.Age > oldestPerson.Age)
    {
        oldestPerson = person;
    }
}
Console.WriteLine($"The oldest person is: {oldestPerson.FirstName}");
Console.WriteLine(" ");

foreach (Person person in personsList)
{
   if (person.FirstName.StartsWith("M"))
    {
        Console.WriteLine(person);
    }
}
Console.WriteLine(" ");

foreach (Person person in personsList)
{
    if(person.FavouriteColour == "Blue")
    {
        Console.WriteLine(person);
    }
}