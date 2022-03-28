using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMonit
{
    public class Problem4UserModel
    {
        public int user_id { get; set; }
        public string email{ get; set; }
    }

    public class Problem4ProductModel
    {
        public int buyer { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
    }

    public class Problem4MapModel
    {
        public Problem4UserModel buyer { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
    }
    public class Problem4
    {
        public static List<Problem4MapModel> FuncProblem4(List<Problem4UserModel> Users, List<Problem4ProductModel> Products)
        {
            List<Problem4MapModel> result = new List<Problem4MapModel>();

            foreach (var prod in Products)
            {
                Problem4MapModel row = new Problem4MapModel();
                row.name = prod.name;
                row.price = prod.price;
                var user = Users.Where(x => x.user_id == prod.buyer).FirstOrDefault();
                if (user != null)
                {
                    row.buyer = user;
                }

                result.Add(row);
            }

            return result;
        }
    }
}
