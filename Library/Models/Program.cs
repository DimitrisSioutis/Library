
using Library.Models;
using System.ComponentModel.Design;

var journal = new Journal("Imerologio","Sioutis","Plaisio Publishing",true,1);
var textbook = new TextBook("Titlos","Sioutis","Plaisio",true,"Sioutis");
var member = new Member("Takis", "Takopoulos");



if (member.Active) {
    textbook.Rent(member);
    journal.Rent(member);
};

Console.WriteLine(textbook.Availiable);
journal.Return(member);
Console.WriteLine(journal.Availiable);

foreach(IRentable obj in member.rentedObjects)
{
    Console.WriteLine(obj);
}

member.Active = !member.Active;


