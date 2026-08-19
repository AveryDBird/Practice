class Solution(object):
    def lengthOfLastWord(self, s):
        """
        :type s: str
        :rtype: int
        """
        sSplit = s.split()
        return len(sSplit[-1])
        