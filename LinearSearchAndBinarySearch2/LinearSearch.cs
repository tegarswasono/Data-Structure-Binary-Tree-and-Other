using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearchAndBinarySearch2
{
    class LinearSearch
    {
        public bool search(List<int> nim, int key)
        {
            foreach (var a in nim)
            {
                if (a==key)
                {
                    return true;
                }
            }
            return false;
        }
        public bool searchRecurtion(List<int> nim, int size, int key)
        {
            if (size<0)
            {
                return false;
            }else if(nim[size]==key)
            {
                return true;
            }else
            {
                return searchRecurtion(nim, size-1, key);
            }
        }
    }
}
