public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        bool DoesExist = true;
        HashSet<int> numbers = new HashSet<int>();
        
        for (int i=0; i<nums.Length; i++)
        {
            if (numbers.Contains(nums[i]))
                return true;
            else 
                numbers.Add(nums[i]);
        }
        
        return false;
    }
}