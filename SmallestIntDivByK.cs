public class Solution {
    public int SmallestRepunitDivByK(int K) {
        
        if(K%2 == 0 && K%5 == 0)
        {
            return -1;
        }
        
        int prev_reminder = 0;
        for(int i=1;i<=K;i++)
        {
            prev_reminder = (prev_reminder*10+1)%K;
            
            if(prev_reminder == 0)
            {
                return i;
            }
        }
        
        return -1;    }
}