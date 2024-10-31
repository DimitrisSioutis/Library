using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models;

public interface IRentable
{
    public DateTime LastUpdate { get; set; }

    public bool Availiable { get; set; }

    public void Rent(Member member);

    public void Return(Member member);
 
}
