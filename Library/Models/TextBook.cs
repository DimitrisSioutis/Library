using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models;

public class TextBook(string title, string author, string publisher, bool availiable, string editor)
    : Publication(title, author, publisher, availiable)
{
    public string Editor { get; set; } = editor; 
}
