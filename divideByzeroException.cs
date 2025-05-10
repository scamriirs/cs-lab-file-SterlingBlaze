using System;

class DivideByZeroException {
    static void Main() {
        try {
            int a = 10, b = 0;
            Console.WriteLine(a / b);
        }
        catch(System.DivideByZeroException e) {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
