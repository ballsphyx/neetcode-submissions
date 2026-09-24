public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        var frequency = new Dictionary<char, int>();
        var frequency2 = new Dictionary<char, int>();

        foreach(char letter in s)
        {
            if (frequency.ContainsKey(letter))
                frequency[letter]++;
            else
                frequency[letter] = 1;
        }

        foreach(char letters in t)
        {
            if (frequency2.ContainsKey(letters))
                frequency2[letters]++;
            else
                frequency2[letters] = 1;
        }

        bool areEqual = frequency.Count == frequency2.Count &&
                 frequency.All(kvp => frequency2.TryGetValue(kvp.Key, out var val) && val == kvp.Value);
        
        return areEqual;
    }
}
