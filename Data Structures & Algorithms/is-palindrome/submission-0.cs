public class Solution {
    public bool IsPalindrome(string s)
{
    int left = 0, right = s.Length - 1;

    while (left < right)
    {
        // move left forward until it lands on an alphanumeric char
        while (left < right && !char.IsLetterOrDigit(s[left]))
            left++;

        // move right backward until it lands on an alphanumeric char
        while (left < right && !char.IsLetterOrDigit(s[right]))
            right--;

        // compare, case-insensitive
        if (char.ToLower(s[left]) != char.ToLower(s[right]))
            return false;

        left++;
        right--;
    }

    return true;
}
}
