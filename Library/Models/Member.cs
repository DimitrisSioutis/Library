using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models;

public class Member (string firstname, string lastname)
{
    public string FirstName { get; set; } = firstname ?? string.Empty;
    public string LastName { get; set; } = lastname ?? string.Empty;

    public List<IRentable> rentedObjects = new List<IRentable>();

    public bool Active = true;

}
