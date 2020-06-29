using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetConsole
{
    class Person
    {
        //Property called Name
        public string Name { get; set; }
        public string Address { get; set; }

        //Default constructor
        public Person()
        {

        }

        ////Constructor with a string parameter
        public Person(string name)
        {
            //This will set the property Name with the value passed
            //in from the constructor
            this.Name = name;
        }
        
        public Person(string name, string address)
        {
            //This will set the property Name with the value passed
            //in from the constructor
            this.Name = name;
            this.Address = address;
        }
    }
}
