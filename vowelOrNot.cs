using System;

class VowelOrNot {
    static void Main() {
        Console.Write("Enter a character: ");
        char c = Console.ReadLine()[0];
        
        if("aeiouAEIOU".IndexOf(c) >= 0) {
            Console.WriteLine("Vowel");
        }
        else {
            Console.WriteLine("Not a vowel");
        }
    }
}
