public class Solution {
    public bool IsAnagram(string s, string t) {
    if (s.Length != t.Length) return false;
    var frequency = new Dictionary<char, int>();

    for (int i = 0; i < s.Length; i++)
    {
        frequency[s[i]] = frequency.GetValueOrDefault(s[i], 0) + 1;
        frequency[t[i]] = frequency.GetValueOrDefault(t[i], 0) - 1;
    }

    return frequency.Values.All(count => count == 0);
}
}
