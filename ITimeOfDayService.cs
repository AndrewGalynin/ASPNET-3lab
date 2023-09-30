namespace Lab3
{
    public interface ITimeOfDayService
    {
        string GetTimeOfDay();
    }

    public class TimeOfDayService : ITimeOfDayService
    {
        public string GetTimeOfDay()
        {
            var currentHour = DateTime.Now.Hour;

            if (currentHour >= 12 && currentHour <= 17)
            {
                return "День";
            }
            else if (currentHour >= 17 || currentHour < 6)
            {
                return "Вечір";
            }
            else if (currentHour >= 6 && currentHour < 12)
            {
                return "Ранок";
            }
            else
            {
                return "Ніч";
            }
        }
    }
}
