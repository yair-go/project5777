using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Speciality
    {
        private static int _sid;

        private  int _id;

        public Speciality()
        {
            _sid++;
        }

        public Speciality(Enums.Discipline discp, string name,int minRate, int maxRate)
        {
            _sid++;
            _id = _sid;
            Discipline = discp;
            Name = name;
            MinRate = minRate;
            MaxRate = maxRate;
        }

        #region Properties
        public int ID { 
            get { return _id; }
        }
       
        public Enums.Discipline Discipline
        { get; set; }

        public string Name
        { get; set; }

        public int MinRate
        { get; set; }

        public int MaxRate
        { get; set; }

        #endregion
    }

}