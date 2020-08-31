using System;
using System.Collections.Generic;

namespace Statistics
{
    class Stats{
       internal float ave;
       internal float max;
       internal float min;
        
       Stats(){
       ave=0.0;
       max=0.0;
       min=Single.MaxValue;
       }
    }
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here
            Stats ans=new Stats();
            float sum=0.0;
            for(int i=0;i<numbers.Length;i++){
                 
                sum+=numbers[i];
                ans.max=Math.max(max,numbers[i]);
                ans.min=Math.min(min,numbers[i]);
                
            }
            ans.ave=sum/numbers.Length;
            if(numbers.Length==0)
                ans.min=0.0;
            return ans;
            
        }
    }
}
