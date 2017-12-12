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
            DataSource.WorkersList = new List<Worker>();
            DataSource.EmployersList = new List<Employer>();
            DataSource.ContractsList = new List<Contract>();
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

        public List<Speciality> getSpecsList()
        {
            return DataSource.SpecList;
        }
        #endregion

        #region Worker

        public void addWorker(Worker wo)
        {
            if (!DataSource.WorkersList.Exists(w => w.ID == wo.ID))
              DataSource.WorkersList.Add(wo);
        }

        public void deleteWorker(Worker wo)
        {
            throw new NotImplementedException();
        }

        public void updateWorker(Worker wo, string name)
        {
            throw new NotImplementedException();
        }

        public void updateWorker(Worker wo, Worker newWo)
        {
            throw new NotImplementedException();
        }

        public void updateWorker(Worker wo, int cost, string minmax)
        {
            throw new NotImplementedException();
        }

        public List<Worker> getWorkersList()
        {
            return DataSource.WorkersList;
        }

        #endregion

        #region Employer

        public void addEmployer(Employer emp)
        {
            DataSource.EmployersList.Add(emp);
        }

        public void deleteEmployer(Employer emp)
        {
            throw new NotImplementedException();
        }

        public void updateEmployer(Employer emp, string name)
        {
            throw new NotImplementedException();
        }

        public void updateEmployer(Employer emp, Employer newemp)
        {
            throw new NotImplementedException();
        }

        public void updateEmployer(Employer emp, int cost, string minmax)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Contract
        public void addContract(Contract sp)
        {
            DataSource.ContractsList.Add(sp);
        }

        public void deleteContract(Contract sp)
        {
            throw new NotImplementedException();
        }

        public void updateContract(Contract sp, string name)
        {
            throw new NotImplementedException();
        }

        public void updateContract(Contract sp, Contract newSP)
        {
            throw new NotImplementedException();
        }

        public void updateContract(Contract sp, int cost, string minmax)
        {
            throw new NotImplementedException();
        }

        public List<Contract> getContractsList()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

}
