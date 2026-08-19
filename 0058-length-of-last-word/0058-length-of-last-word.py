class Solution:
    def lengthOfLastWord(self, s: str) -> int:
        sSplit = s.split()
        return len(sSplit[-1])
        