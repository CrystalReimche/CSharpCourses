using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Employees
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public Employees (string _firstName, string _lastName, int _id)
        {
            this.FirstName = _firstName;
            this.LastName = _lastName;
            this.ID = _id;
            
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"{FirstName} {LastName} has an id of {ID}.";
        }

    }
}
