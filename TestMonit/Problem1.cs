using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMonit
{
    public class Problem1Model { 
        public string id { get; set; }
        public Boolean deleted { get; set; }
    }
    public class Problem1
    {
        public static void TestFunc()
        {
            List<Problem1Model> dataModel = new List<Problem1Model>();
            dataModel.Add(new Problem1Model { id = "0001", deleted = true});
            dataModel.Add(new Problem1Model { id = "0002", deleted = false });
            dataModel.Add(new Problem1Model { id = "0003", deleted = false });
            dataModel.Add(new Problem1Model { id = "0004", deleted = false });

            var res = FuncProblem1(dataModel);
        }

        public static List<string> FuncProblem1(List<Problem1Model> Datas)
        {
            List<string> result = new List<string>();

            foreach (var data in Datas)
            {
                if (!data.deleted)
                {
                    result.Add(data.id);
                }
            }

            return result;
        }
    }
}
