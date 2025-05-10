using System;

class EligibleToVoteOrNot {
    static void Main() {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        
        if(age >= 18) {
            Console.WriteLine("You are eligible to vote");
        }
        else {
            Console.WriteLine("You are not eligible to vote");
        }
    }
}
