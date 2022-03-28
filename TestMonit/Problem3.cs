using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMonit
{
    public class Problem3Model
    {
        public string id { get; set; }
        public string bankCode { get; set; }
        public string name { get; set; }
    }
    public class Problem3
    {
        public static List<Problem3Model> FuncProblem3(List<string> IDs, List<Problem3Model> Datas)
        {
            List<Problem3Model> result = new List<Problem3Model>();

            foreach (var data in Datas)
            { 
                if(IDs.Contains(data.id))
                {
                    result.Add(data);
                }
            }

            return result;
        }

    }
}
