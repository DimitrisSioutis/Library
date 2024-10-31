
using Library.Models;

var journal = new Journal("Imerologio","Sioutis","Plaisio Publishing",true,1);
var textbook = new TextBook("Titlos","Sioutis","Plaisio",true,"Sioutis");
var member = new Member("Takis", "Takoulis");


if (member.Active) {
    textbook.Rent(member);
    journal.Rent(member);
};

Console.WriteLine(textbook.Availiable); //false
journal.Return(member);
Console.WriteLine(journal.Availiable); //true

Console.WriteLine(member.GetRentedPubs()); //1

member.Active = false;



