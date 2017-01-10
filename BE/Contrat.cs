using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Contract
    {
        private static int _sid;

        private int _id;

        #region Consturctors

        public Contract()
        {
            _sid++;
        }

        public Contract(Employer e, Worker w)
        {
            EmployerID = e.ID;
            WorkerID = w.ID;
        }
        #endregion

        #region Properties
        public int ID
        {
            get
            {
                return _id;
            }
        }

        public int EmployerID
        {
            get; set;
        }

        public string WorkerID
        {
            get; set;
        }
        #endregion



        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}