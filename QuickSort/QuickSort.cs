using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    static class QuickSort
    {
        private static int partition(List<ListItem> list, int start, int end)
        {
            ListItem pivot = list[end];
            int small = start;
            ListItem tmp;
            for (int i = start; i < end; i++)
            {
                if (String.Compare(list[i].Name,
                    pivot.Name, 
                    StringComparison.CurrentCultureIgnoreCase) < 0)
                {
                    tmp = list[i];
                    list[i] = list[small];
                    list[small] = tmp;
                    small++;
                }
            }
            tmp = list[end];
            list[end] = list[small];
            list[small] = tmp;
            return small;
        }
        private static void quick_sort_helper(List<ListItem> 
                                              list, int start, int end)
        {
            if(start >= end) 
            {
                return; 
            }
            
            int pivot = partition(list, start, end);
            quick_sort_helper(list, start, pivot - 1);
            quick_sort_helper(list, pivot + 1, end);
        }

        public static void quick_sort(List<ListItem> list)
        {
            quick_sort_helper(list, 0, list.Count - 1);
        }
    }
}
