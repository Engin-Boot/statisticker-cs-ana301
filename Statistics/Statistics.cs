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
            Stats ans=new Stats(Double.NaN,Double.NaN,Double.NaN);
            if(numbers.Count==0)
                return ans;
            
            ans.min=Single.MaxValue;
            ans.max=-1;
            
            Double sum=0.0;
            int reject=0;
            
            for(int i=0;i<numbers.Count;i++){
                reject+=check(numebrs,i)
                sum+=numbers[i];
                ans.max=Math.Max(ans.max,numbers[i]);
                ans.min=Math.Min(ans.min,numbers[i]);
                
            }
            ans.ave=sum/(numbers.Count-reject);
            
            return ans;
            
        }
        public static int check(List<Double> numbers,int i){
        
                if(Double.IsNaN(numbers[i])){
                    return 1;
                    
                }
            
                return 0;
        }
    }
}
