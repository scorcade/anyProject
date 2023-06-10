using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leedCode88
{
    internal class _88______Merge_Sorted_Array
    {

    }

    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int pM = m - 1;
            int pN = n-1;
            int PNM = n+m-1;
            int cur=0;

            while(pN > 0 || pM > 0)
            {
                if (pM == -1) { cur = nums2[pN--]; }
                else if (pN==-1){ cur = nums1[pM--]; }
                else if (nums1[pM] > nums2[pN]) { cur = nums1[pM--]; }
                else { cur = nums2[pN--]; }
              
                nums1[PNM--] = cur;
            }
        }
    }
}

