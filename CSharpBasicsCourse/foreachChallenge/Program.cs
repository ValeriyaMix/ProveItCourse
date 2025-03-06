// See https://aka.ms/new-console-template for more information



using foreachChallenge;

List<string> namesList = new List<string>() { "Val Mik", "Doug The", "Jason La" };

//foreach (string name in namesList)
//{
//    Console.WriteLine(name);
//}


List<PersonData> personList = new List<PersonData>()
{
    new PersonData{ FirstName = "Val", LastName = "Mik" },
    new PersonData{ FirstName = "Mike", LastName = "P" },
    new PersonData{ FirstName = "Sam", LastName = "Wilson" },

};

foreach (var person in personList)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}");
}

