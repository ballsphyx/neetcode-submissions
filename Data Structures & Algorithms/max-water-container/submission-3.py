class Solution:
    def maxArea(self, heights: List[int]) -> int:
        seen = []

        left, right = 0, len(heights) - 1

        while left < right:
            width = abs(left - right)
            height = min(heights[left], heights[right])
            maxWater = width * height
            seen.append(maxWater)
            if heights[left] < heights[right]:
                left += 1
            else:
                right -= 1 
        return max(seen)
        