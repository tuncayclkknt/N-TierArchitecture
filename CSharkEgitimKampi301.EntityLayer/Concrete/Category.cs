using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharkEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CatagoryId { get; }//primary key and autoincreasing
        public string CatagoryName { get; set; }
        public bool CatagoryStatus { get; set; }

    }
}
/*
 Fielad - Variable - Property

int x; ---> Field
public int x {get; set;} --> Property
int x; (in an method) --> Variable

 */
