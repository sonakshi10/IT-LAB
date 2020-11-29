using System;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int day_counter = 0;
            int[] days_in_month = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int day, month, year;
            string dateString = "";
            Console.WriteLine("Enter date (DD:MM:YY:hh:mm:ss) : ");
            dateString = Console.ReadLine();
            Console.WriteLine("Enter ticks (range from 10000000 - 999999999999) : ");
            string ticks = Console.ReadLine();
            long convertedTicks;
            Int64.TryParse(ticks, out convertedTicks);
            convertedTicks /= 10000000;
            string[] s = dateString.Split(":");
            long second;
            Int64.TryParse(s[5], out second);
            second = second + convertedTicks;
            long minute;
            Int64.TryParse(s[4], out minute);
            minute = minute + (second / 60);
            long hour;
            Int64.TryParse(s[3], out hour);
            hour = hour + (minute / 60);
            int hourCarry = (int)(hour / 24);
            hour = hour % 24;
            minute = minute % 60;
            second = second % 60;
            Console.WriteLine("{0} {1} {2}", hour, minute, second);

            
            Int32.TryParse(s[0], out day);
            Int32.TryParse(s[1], out month);
            Int32.TryParse(s[2], out year);
            
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                days_in_month[2] = 29;
            }
            else
            {
                days_in_month[2] = 28;
            }
            int i;
            for (i = 0; i < hourCarry; i++)
            {
                day += 1; day_counter++;
                if (day > days_in_month[month])
                {
                    day = 1;
                    month += 1;
                    if (month > 12)
                    {
                        month = 1;
                        year += 1;
                        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                        {
                            days_in_month[2] = 29;
                        }
                        else
                        {
                            days_in_month[2] = 28;
                        }
                    }
                }
            }
            Console.WriteLine("{0} {1} {2}", day, month, year);
        }
    }
}
