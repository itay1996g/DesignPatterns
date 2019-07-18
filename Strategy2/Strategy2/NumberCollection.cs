using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2
{
    public class NumberCollection
    {
        protected ISort sort;
        protected IList<int> list = new List<int>();

        public NumberCollection()
        {
            
        }
        public void Add(int num)
        {
            list.Add(num);
        }

        public void Remove(int num)
        {
            list.Remove(num);
        }

        public void Sort()
        {
            if (list.Count > 10)
            {
                sort = new Quicksort();
                sort.Sort(this.list);
            }
                if (list.Count <= 10)
            {
                sort = new Mergesort();
                sort.Sort(this.list);
            }
                
        }
    }
}
