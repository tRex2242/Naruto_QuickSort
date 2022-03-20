using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    static class BinSearch
    {
        static public int binary_seach(List<ListItem> list, string key)
        {
            int left = -1;
            int right = list.Count;
            while(left < right - 1)
            {
                int mid = (left + right) / 2;
                if(list[mid].Name.ToLower() == key.ToLower())
                {
                    return mid;
                }
                else if(String.Compare( list[mid].Name,
                    key, 
                    StringComparison.CurrentCultureIgnoreCase)< 0)
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }
            return -1;
        }
    }
}
