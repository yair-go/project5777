using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Employer
    {
        int _id;

        public Employer()
        {
            _id = 0;
        }
        public Employer(int id, string name)
        {
            _id = id;
            Name = name;

        }

        #region Properties
        public int ID
        {
            get
            {
                return _id;
            }
        }
        public string Name
        { get; set; }
        #endregion
    }
}