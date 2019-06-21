using System.Collections.Generic;
using System.Linq;
using LINQRnD.Model;

namespace LINQRnD
{
    public class LINQQuerySyntax
    {
        private List<PersonalInfo> listData = JSONReader.GetAll();

        public List<PersonalInfo> SelectAll()
        {
            var result = (from listObj in listData
                          select listObj).ToList();
            return result;
        }
        public List<PersonalInfo> WhereCon()
        {
            var result = (from listObj in listData
                          where listObj.Amoungt > 0 && listObj.FirstName.Contains("first")
                          select listObj).ToList();
            return result;
        }

        public List<PersonalInfo> OrderBy()
        {
            //by default because ascending
            var result1 = (from listObj in listData
                           select listObj).ToList();

            var result2 = (from listObj in listData
                           orderby listObj.FirstName descending
                           select listObj).ToList();

            //Using extension method
            var InAscOrder = listData.OrderBy(s => s.LastName);
            var InDescOrder = listData.OrderByDescending(s => s.LastName);

            //Multiple sorting
            var orderByResult = from listObj in listData
                                orderby listObj.FirstName, listObj.LastName
                                select new { listObj.FirstName, listObj.LastName };


            return result1;
        }

        public List<PersonalInfo> ThenBy()
        {
            var thenByResult = listData.OrderBy(s => s.FirstName).ThenBy(s => s.Amoungt);
            var thenByDescResult = listData.OrderBy(s => s.FirstName).ThenByDescending(s => s.Amoungt).ToList();
            return thenByDescResult;
        }

        public void GroupBy()
        {
            var groupedResult = (from listObj in listData
                                 group listObj by listObj.Amoungt).ToList();
        }
    }
}