using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DS
{
    public sealed class DalFactory
    {
        private static readonly DalFactory instance = new DalFactory();

        static DalFactory() { }
        private DalFactory() { }

        public static DalFactory Instance
        {
            get { return instance; }
        }

        public static IDAL getDAL(string typeDL)
            {
                switch (typeDL)
                {
                    case "List": return Dal_List.Instance;
                    //  case "XML": return DL_XML.Instance;
                    default: return null;
                }
            }

     }
}

