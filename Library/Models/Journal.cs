using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models;
public class Journal(string title, string author, string publisher, bool availiable, int issueNo) : 
    Publication(title, author, publisher, availiable)
{
    public int IssueNo { get; set; } = issueNo;
    public DateTime PublicationDate { get; set; } = DateTime.Now;

}

