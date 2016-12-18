using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using DS;

namespace BL
{
    public class MyBL : IBL
    {
        #region Singleton
        private static readonly MyBL instance = new MyBL();

        public static MyBL Instance
        {
            get { return instance; }
        }
        #endregion

        static IDAL MyDal;

        #region Constructor

        private MyBL() { }
        static MyBL()
        {
            MyDal = DalFactory.getDAL("List");
        }

        #endregion

        #region Speciality

        public void addSpec(Speciality sp)
        {
            MyDal.addSpec(sp);
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
        #endregion
    }
}
