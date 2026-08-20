public class Solution {
    public string AddBinary(string a, string b) {
        string strOut ="";
        int i=a.Length -1;
        int j =b.Length -1;
        int carry = 0;

        while(i>=0 || j>=0 || carry>0)
        {
            if(i>=0 && a[i--] =='1')
            {carry++;}
            if(j>=0 && b[j--] =='1')
            {carry++;}
            strOut = (carry%2)+strOut;
            carry/=2;

        }
        return strOut;
    }
}