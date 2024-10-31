using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models;

public abstract class Publication(string title, string author, string publisher, bool availiable ) : IRentable
{
    public string Title { get; set; } = title;
    public string Author { get; set; } = author;
    public string Publisher {  get; set; } = publisher;
    public DateTime LastUpdate { get; set; } = new DateTime();
    public bool Availiable { get; set; } = availiable;

    public void Rent(Member member)
    {
        if (Availiable) 
        {
            Availiable = false;
            LastUpdate = DateTime.Now;
            member.rentedObjects.Add(this);
        }
    }

    public void Return(Member member)
    {
        if (!Availiable)
        {
            Availiable = false;
            LastUpdate = DateTime.Now;
            member.rentedObjects.Remove(this);
        }
    }
}
