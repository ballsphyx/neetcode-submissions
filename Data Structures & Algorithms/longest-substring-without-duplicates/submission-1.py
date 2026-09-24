class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        seen = set()
        left, right = 0, 0
        res = 0

        while right < len(s):
            while s[right] in seen:
                seen.remove(s[left])
                left += 1
            seen.add(s[right])
            res = max(res, right - left + 1)
            right += 1
        print(seen)
        return res
