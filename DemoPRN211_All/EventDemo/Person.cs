using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Person
    {
        public delegate void EventHandler(string n1,string n2);
        public event EventHandler NameChanged; 
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                //Khi set lai name thi su kien se xay ra
                if(NameChanged!=null)
                {
                    NameChanged(Name, value);
                }
                    
                _name = value;
            }
        }

    }
}
