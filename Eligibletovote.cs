using System;

class EligibleToVoteOrNot2 {
    static void Main() {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        
        string result = age >= 18 ? "Eligible" : "Not eligible";
        Console.WriteLine(result + " to vote");
    }
}
