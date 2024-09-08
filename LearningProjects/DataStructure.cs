using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProjects
{
    internal class DataStructure
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] indexes = new int[2];
            Dictionary<int, int> hashSet = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (!hashSet.ContainsKey(diff))
                {
                    hashSet.Add(diff, i);
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (hashSet.ContainsKey(nums[i]) && i != hashSet[nums[i]])
                {
                    indexes = [i, hashSet[nums[i]]];
                    break;
                }
            }
            return indexes;
        }
    }
}
