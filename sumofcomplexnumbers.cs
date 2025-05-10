using System;

class Complex {
    public double Real { get; set; }
    public double Imaginary { get; set; }
    
    public static Complex operator +(Complex a, Complex b) {
        return new Complex {
            Real = a.Real + b.Real,
            Imaginary = a.Imaginary + b.Imaginary
        };
    }
}

class SumComplexNumberusingPlus {
    static void Main() {
        Complex c1 = new Complex { Real = 2.5, Imaginary = 3.1 };
        Complex c2 = new Complex { Real = 1.4, Imaginary = 0.8 };
        Complex sum = c1 + c2;
        
        Console.WriteLine($"Sum: {sum.Real} + {sum.Imaginary}i");
    }
}
