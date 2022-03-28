using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMonit
{
    public class Problem2Model
    {
        public string id { get; set; }
        public string color { get; set; }
        public string label { get; set; }
    }
    public class Problem2
    {
        public static void TestFunc()
        {
            Dictionary<string, bool> selects = new Dictionary<string, bool>();
            selects.Add("VALUE_1", true);
            selects.Add("VALUE_2", false);

            List<Problem2Model> dataModel = new List<Problem2Model>();
            dataModel.Add(new Problem2Model { id = "VALUE_1", color = "#32a852", label= "Permata" });
            dataModel.Add(new Problem2Model { id = "VALUE_2", color = "#f67c12", label = "BCA" });


            var res = FuncProblem2(selects, dataModel);
        }

        public static List<Problem2Model> FuncProblem2(Dictionary<string,Boolean> Selects,List<Problem2Model> Datas)
        {
            List<Problem2Model> result = new List<Problem2Model>();

            foreach (var data in Datas)
            {
                if (Selects.ContainsKey(data.id) && Selects[data.id] == true)
                {
                    result.Add(data);
                }
            }

            return result;
        }
    }
}
