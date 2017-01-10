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
        List<Speciality> getSpecsList();
        #endregion

        #region Worker
        void addWorker(Worker wo);
        void deleteWorker(Worker wo);
        void updateWorker(Worker wo, string name);
        void updateWorker(Worker wo, Worker newWo);
        void updateWorker(Worker wo, int cost, string minmax);
        List<Worker> getWorkersList();
        #endregion

        #region Employer
        void addEmployer(Employer emp);
        void deleteEmployer(Employer emp);
        void updateEmployer(Employer emp, string name);
        void updateEmployer(Employer emp, Employer newemp);
        void updateEmployer(Employer emp, int cost, string minmax);
        #endregion
    }
}
