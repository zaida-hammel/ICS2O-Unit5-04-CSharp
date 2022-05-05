using System;

class Program {
    public static void Main(string[] args) 
    {
        int userAge;
        var dayWeek = Console.ReadLine();

        //input 
        Console.WriteLine("Write your age:");
        userAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Write the day of the week it is (Capital first letter):");
        dayWeek = Console.ReadLine();
        
        //process
        if ((dayWeek == "Tuesday" || dayWeek == "Thursday") && (userAge > 12 && userAge < 21))
            Console.WriteLine("You have a student discount! Pay student pricing.");
        else 
            Console.WriteLine("You do not have a student discount! Pay regular pricing.");
        
    }
}