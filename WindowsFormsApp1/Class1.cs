using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public class Class1:  Interface1
    {
        public int nombre = 0;

        DateTime time = DateTime.Now;
        DataTable table = new DataTable();

        public Class1()
        { 
          
        }

        public Class1(int age)
        {
            this.Age = age; 
        }


        public int Age { get; set; }

        public void AddAge()
        {
            ++this.Age;
        }

        public string Gretting(string name)
        {
            throw new NotImplementedException();
        }
    }

    public class Class2 : Class1
    {
        public Class2(int age): base(age)
        {
            int valor = Class11.getvalor();
        }
    }


    }
