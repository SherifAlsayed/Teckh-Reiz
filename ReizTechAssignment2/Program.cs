using System;

namespace ReizTechAssignment2
{
        class program
        {

            static int calcAngle()
             {
            Console.WriteLine("Please enter the hour number");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Minutes Number");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------");
            if (x < 0 || y < 0 ||
                 x > 12 || y > 60)
                 Console.Write("Wrong input");
                
                  if (x == 12)
                      x = 0;           
            int hour_angle = (int)(0.5 * (x * 60 + y));
            int minute_angle = (int)(6 * y);

            int angle = Math.Abs(hour_angle - minute_angle);

            angle = Math.Min(360 - angle, angle);

            return angle;
             }

        public static void Main()
        {
            Console.WriteLine($"The Angle is : {calcAngle()} ");
        }
    }
}
