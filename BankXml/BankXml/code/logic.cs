using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankXml.code
{
    class Logic
    {
        const string xmlLocalPath = @"atm.xml";
       // const string xmlServerPath = @"http://www.boi.org.il/he/BankingSupervision/BanksAndBranchLocations/Lists/BoiBankBranchesDocs/atm.xml";
        const string xmlServerPath = @"http://www.jct.ac.il/~coshri/atm.xml";

        private static void DownloadAtmXml()
        {
            const string xmlLocalPath = @"atm.xml";

            WebClient wc = new WebClient();
            try
            {
                string xmlServerPath = @"http://www.boi.org.il/he/BankingSupervision/BanksAndBranchLocations/Lists/BoiBankBranchesDocs/atm.xml";
                wc.DownloadFile(xmlServerPath, xmlLocalPath);

            }
            catch (Exception)
            {
                string xmlServerPath = @"http://www.jct.ac.il/~coshri/atm.xml";
                wc.DownloadFile(xmlServerPath, xmlLocalPath);
            }
            finally
            {
                wc.Dispose();
            }

            //using (WebClient  wc = new WebClient())
            //{
            //    wc.DownloadFile(xmlServerPath, xmlLocalPath);
            //}
        }

        public static IEnumerable<ATM> GetAllAtm()
        {
            DownloadAtmXml();

            //this work also white xmlServerPath
            XElement xml = XElement.Load(xmlLocalPath);

            foreach (var item in xml.Elements())
            {
                yield return new ATM
                {
                    BankCode = int.Parse(item.Element("קוד_בנק").Value),
                    ATMCode = int.Parse(item.Element("קוד_סניף").Value),
                    BankName = item.Element("שם_בנק").Value.Replace('\n', ' ').Trim(),
                    ATMAddress = item.Element("כתובת_ה-ATM").Value.Replace('\n', ' ').Trim(),
                    City = item.Element("ישוב").Value.Replace('\n', ' ').Trim(),
                };
            }

        }
    
        public static IEnumerable<IGrouping<string,ATM>> GetAllAtmGroupByBank()
        {
            return from atm in GetAllAtm()
                   group atm by atm.BankName;
        }

        public static IEnumerable<IGrouping<string, ATM>> GetAllAtmGroupByCity()
        {
            return from atm in GetAllAtm()
                   group atm by atm.City;
        }

        public static IEnumerable<string> GetAllBankNames()
        {
            return (from atm in GetAllAtm()
                   select atm.BankName).Distinct();
        }

        public static IEnumerable<ATM> GetAllBankAtm(string bankName)
        {
            return (from atm in GetAllAtm()
                    where atm.BankName.CompareTo(bankName)==0
                    select atm).Distinct();
        }

        public static IEnumerable<IGrouping<string, IGrouping<string, ATM>>> GetAllAtmGroupByBankAndCity()
        {
            var queryNestedGroups =
                from atm in GetAllAtm().Distinct()
                orderby atm.BankName, atm.City, atm.BankCode // optional for sort list
                group atm by atm.BankName into g  // group by bank name
                from newGroup2 in (from atm2 in g   // foreach bank name grouping now group by city
                                   group atm2 by atm2.City)
                group newGroup2 by g.Key;
            
            return queryNestedGroups;
        }



    
}
}
