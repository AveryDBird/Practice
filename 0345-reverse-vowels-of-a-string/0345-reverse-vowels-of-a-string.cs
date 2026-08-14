public class Solution {
    public string ReverseVowels(string s) {
        char[] arr = s.ToCharArray();
        int left = 0;
        int right = s.Length-1;
        string strVowels = "aeiouAEIOU";
        while(left<right)
        {
            if(strVowels.Contains(arr[left]) && strVowels.Contains(arr[right]))
            {
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                right --;
                left ++;
            }
            else if (strVowels.Contains(arr[left]))
            {
                right--;
            }
            else
            {
                left ++;
            }
        }
        return new string(arr);
    }
}