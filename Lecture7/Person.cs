using System;

namespace Lecture7
{
    class Person
    {
        //Attributes
        public string name;

        //Constructor
        public Person() {
        }
        public Person(string name)
        {
            this.name = (!string.IsNullOrEmpty(name)) ? name : throw new ArgumentException("Name must not be empty");
        }
        //Destructor
        ~Person()
        {
            name = "";
            Console.WriteLine("Destructor called : the name is now empty");
        }
        //Property
        public string Name
        {
            get => name;
            //set => name = (!string.IsNullOrEmpty(value)) ? value : throw new ArgumentException("Name must not be empty");
        }
        
    }
}
