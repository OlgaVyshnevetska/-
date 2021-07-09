using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    public class WorkDayCalculator : IWorkDayCalculator
    {
        public DateTime Calculate(DateTime startDate, int dayCount, WeekEnd[] weekEnds)
        {
            DateTime temp = startDate;
            for(int i = 0; i < dayCount; i++)
            {
                if(weekEnds == null)
                {
                    temp = temp.AddDays(1);
                }
                else
                {
                    for(int j = 0; j < weekEnds.Length; j++)
                    {
                        if(temp == weekEnds[j].StartDate)
                        {
                            temp = weekEnds[j].EndDate;
                            temp = temp.AddDays(1);
                        }
                        else
                        {
                            temp = temp.AddDays(1);
                        }
                    }
                }
            }
            DateTime result = temp;
            return result;
            //throw new NotImplementedException();
        }
    }
}
