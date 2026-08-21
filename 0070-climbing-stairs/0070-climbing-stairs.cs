public class Solution {
    public int ClimbStairs(int n) {
        if (n<=2)
        {
            return n;
        }
        List<int> list = new List<int>() {0,1,2};
        for(int i =3; i<=n;i++)
        {
            list.Add(list[i-1] + list[i-2]);
        }
        return list[n];

    }
}