using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats{
       public Double ave;
       public Double max;
       public Double min;
         
       public Stats(Double ave,Double max,Double min){
       this.ave=ave;
       this.max=max;
       this.min=min;
       }
    }
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<Double> numbers) {
            //Implement statistics here
            Stats ans=new Stats(0.0,0.0,Single.MaxValue);
            Double sum=0.0;
            for(int i=0;i<numbers.Count;i++){
                 
                sum+=numbers[i];
                ans.max=Math.Max(ans.max,numbers[i]);
                ans.min=Math.Min(ans.min,numbers[i]);
                
            }
            ans.ave=sum/numbers.Count;
            if(numbers.Count==0)
                ans.min=0.0;
            return ans;
            
        }
    }
}
