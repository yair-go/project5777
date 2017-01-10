using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Worker
    {
        private string _id;

        #region Constuctors
        public Worker() { }
        public Worker(string id, string firstName, string lastName, DateTime birthday)
        {
            _id = id;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }

        #endregion

        #region Properties
        public string ID
        {
            get
            {
                return _id;
            }
        }

        public string FirstName
        {
            get; set;  
        }

        public string LastName
        {
            get; set;
        }

        public DateTime Birthday
        {
            get;
        }

        public int Phone
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
        #endregion

        public override string ToString()
        {
            return FirstName + " " + LastName;

        }
    }
}