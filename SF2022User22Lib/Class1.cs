namespace SF2022User22Lib
{
    public class Calculations
    {
        public string[] AvailablePeriods(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {
            string[] output;
            List<string> list = new List<string>();
            for (TimeSpan i = beginWorkingTime; i <= endWorkingTime; i += TimeSpan.FromMinutes(consultationTime))
            {
                list.Add(i.ToString());
            }
            output = list.ToArray();
            return output;
        }
    }
}