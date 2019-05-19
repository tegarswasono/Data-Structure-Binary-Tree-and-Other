using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearchAndBinarySearch2
{
    class BinarySearch
    {
        public bool Search(List<int> nim, int key)
        {
            int min = 0;
            int max = nim.Count - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == nim[mid])
                {
                    return true;
                }
                else if (key < nim[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return false;
        }
        public bool SearchRecursif(List<int> nim, int min, int max, int key)
        {
            if (max<min)
            {
                return false;
            }else
            {
                int mid = (max + min) / 2;
                if (nim[mid]>key)
                {
                    return SearchRecursif(nim, min, mid-1, key);
                }else if (nim[mid]<key)
                {
                    return SearchRecursif(nim, mid+1, max, key);
                }else
                {
                    return true;
                }
            }
        }
    }
}
