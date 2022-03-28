using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMonit
{
    public class Problem5DataModel 
    {
        public string id { get; set; }
        public string title { get; set; }
        public string parent { get; set; }
        public List<string> children { get; set; }
    }

    public class Problem5TreeModel
    {
        public string id { get; set; }
        public string title { get; set; }
        public Problem5TreeModel parent { get; set; }
        public List<Problem5TreeModel> children { get; set; }
    }

    public class Problem5
    {
        public static List<Problem5TreeModel> FillRecursive(List<Problem5DataModel> Datas, string ParentID = null)
        {
            return Datas.Where(x => x.parent.Equals(ParentID)).Select(item => new Problem5TreeModel
            {
                title = item.title,
                id = item.id,
                children = FillRecursive(Datas, item.id)
            }).ToList();
        }
    }
}
