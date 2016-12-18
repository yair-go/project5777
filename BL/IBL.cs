using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace BL
{
    interface IBL
    {
        #region Speciality
        void addSpec(Speciality sp);
        void deleteSpec(Speciality sp);
        void updateSpec(Speciality sp, string name);
        void updateSpec(Speciality sp, Speciality newSP);
        void updateSpec(Speciality sp, int cost, string minmax);
        #endregion
    }
}
