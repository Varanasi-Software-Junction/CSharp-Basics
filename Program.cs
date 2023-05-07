namespace DateValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2020, month = 4, day = 9;
            if (year < 1)
            {
                Console.WriteLine("Invalid Year");
                return;
            }
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Invalid Month");
                return;
            }
            if (day < 1)
            {
                Console.WriteLine("Invalid Day");
                return;
            }
            int noofdays;
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                noofdays = 31;
            else
            if (month == 4 || month == 6 || month == 9 || month == 11)
                noofdays = 30;
            else
            {
                if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                    noofdays = 29;
                else
                    noofdays = 28;
            }
            if (day > noofdays)
            {
                Console.WriteLine("Invalid Day");
                return;
            }
            Console.WriteLine("Date is Valid");

        }
    }
}