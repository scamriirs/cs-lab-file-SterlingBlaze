using System;

class WeekdayOrWeekend {
    static void Main() {
        Console.Write("Enter day (1-7): ");
        int day = int.Parse(Console.ReadLine());
        
        if(day >= 1 && day <= 5) {
            Console.WriteLine("Weekday");
        }
        else if(day == 6 || day == 7) {
            Console.WriteLine("Weekend");
        }
        else {
            Console.WriteLine("Invalid day");
        }
    }
}
