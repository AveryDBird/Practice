class Solution(object):
    def addBinary(self, a, b):
        """
        :type a: str
        :type b: str
        :rtype: str
        """
        Output =""
        i = len(a)-1
        j = len(b)-1
        carry =0
        while i>=0 or j>=0 or carry>0:
            if i>=0 :
                if a[i] == '1':
                    carry += 1
                i -=1
            if j>=0 :
                if b[j] == '1':
                    carry += 1
                j -=1
            Output = str(carry%2) + Output
            carry //=2
        return Output