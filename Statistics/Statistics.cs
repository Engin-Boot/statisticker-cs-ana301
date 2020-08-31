using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats{
       internal Double ave;
       internal Double max;
       internal Double min;
         
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
            Double sum=0.0;
            for(int i=0;i<numbers.Count;i++){
                 
                sum+=numbers[i];
                ans.max=Math.Max(Stats.max,numbers[i]);
                ans.min=Math.Min(Stats.min,numbers[i]);
                
            }
            ans.ave=sum/numbers.Count;
            if(numbers.Count==0)
                ans.min=0.0;
            return ans;
            
        }
    }
}
