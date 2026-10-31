class Solution:
    def checkInclusion(self, s1: str, s2: str) -> bool:
        freq = Counter(s1)

        if len(s1) > len(s2):
            return False

        sLength = len(s1)
        print(freq)
        for i in range(len(s2) - sLength + 1):
            freq2 = Counter(s2[i:i+sLength])

            print(freq2)
            if freq2 == freq:
                return True
        return False
        