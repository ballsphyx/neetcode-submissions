class Solution:
    def checkInclusion(self, s1: str, s2: str) -> bool:
        count1 = Counter(s1)

        if len(s1) > len(s2):
            return False
            
        for i in range(len(s2) - len(s1) + 1):
            count2 = Counter(s2[i:i + len(s1)])

            if count1 == count2:
                return True
        return False