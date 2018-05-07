using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataClasses
{
    public class Output
    {
        public string title { get; set; } = string.Empty;
        private string _type = string.Empty;
        
        public string type
        {
            get
            {
                return _type.ToUpper();
            }

            set
            {
                this._type = value;
            }
        } 
        public string message { get; set; } = string.Empty;
        public float distance { get; set; } = 0.0f;
        public int elements { get; set; } = 0;
        public string status { get; set; } = string.Empty;
        public DateTime startTime { get; set; } = DateTime.Now;
        public DateTime endTime { get; set; }


        public string time
        {
            get
            {
                if (endTime > startTime)
                {
                    string days = (endTime.Day - startTime.Day) > 0 ? string.Format("Days: {0}, ", endTime.Day - startTime.Day) : string.Empty;
                    string hours = (endTime.Hour - startTime.Hour) > 0 ? string.Format("Hours: {0}, ", (endTime.Hour - startTime.Hour)) : string.Empty;
                    string mins = (endTime.Minute - startTime.Minute) > 0 ? string.Format("Minutes: {0}, ", (endTime.Minute - startTime.Minute)) : string.Empty;
                    string secs = (endTime.Second - startTime.Second) > 0 ? string.Format("Seconds: {0}, ", (endTime.Second - startTime.Second)) : string.Empty;
                    string milli = (endTime.Millisecond - startTime.Millisecond) > 0 ? string.Format("Milliseconds: {0}, ", (endTime.Millisecond - startTime.Millisecond)) : string.Empty;

                    return days + hours + mins + secs + milli;
                }
                else
                {
                    return "Time not Measured";
                }
            }
        }

    }
}
