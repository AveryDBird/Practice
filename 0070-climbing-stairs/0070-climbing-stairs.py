class Solution(object):
    def climbStairs(self, n):
        """
        :type n: int
        :rtype: int
        """
        if n<= 2:
            return n
        listSteps = [0,1,2]
        for i in range (3, n+1):
            listSteps.append(listSteps[i-1] + listSteps[i-2])
        return listSteps[n]
        