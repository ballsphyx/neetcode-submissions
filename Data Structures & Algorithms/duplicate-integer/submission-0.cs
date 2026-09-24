public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> numSet = new HashSet<int>();

        foreach(int num in nums)
        {
            bool wasAdded = numSet.Add(num);
            if (!wasAdded) return true;
        }
        return false;
    }
}