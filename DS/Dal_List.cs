using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;


namespace DS
{
    public sealed class Dal_List : IDAL
    {
        #region Singleton
        private static readonly Dal_List instance = new Dal_List();
        
        public static Dal_List Instance
        {
            get { return instance; }
        }
        #endregion

        #region Constructors

        static Dal_List()
        {
            DataSource.SpecList = new List<Speciality>();
        }
        private Dal_List() { }

        #endregion

        #region Speciality

        public void addSpec(Speciality sp)
        {
            DataSource.SpecList.Add(sp);
        }

        public void deleteSpec(Speciality sp)
        {
            throw new NotImplementedException();
        }

        public void updateSpec(Speciality sp, Speciality newSP)
        {
            throw new NotImplementedException();
        }

        public void updateSpec(Speciality sp, string name)
        {
            throw new NotImplementedException();
        }

        public void updateSpec(Speciality sp, int cost, string minmax)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
