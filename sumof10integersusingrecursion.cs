using System;

class Sumof10NumberUsingRecursion {
    static int Sum(int n) {
        if(n == 1) return 1;
        return n + Sum(n-1);
    }
    
    static void Main() {
        Console.WriteLine("Sum of first 10 numbers: " + Sum(10));
    }
}
