using ConsoleApp13;

BaseClass<string> baseclass = new();
baseclass.Add("Person");
baseclass.Clear();

baseclass.Add("Salam");
Console.WriteLine(baseclass.customContains("Salam"));

baseclass.Add("Seymur");
Console.WriteLine(baseclass.FirstIndexOf("Seymur"));

baseclass.Add("Salam");
baseclass.Add("Salam1");
baseclass.Add("Salam2");
baseclass.Add("Salam1");
baseclass.Add("Salam");
baseclass.Add("Salam3");
baseclass.customRemove("Salam1");
baseclass.ShowAll();

