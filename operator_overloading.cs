using System;

class Box {
    public int Length { get; set; }
    public int Width { get; set; }
    
    public static Box operator +(Box a, Box b) {
        return new Box {
            Length = a.Length + b.Length,
            Width = a.Width + b.Width
        };
    }
}

class OperatorOverloading {
    static void Main() {
        Box b1 = new Box { Length = 5, Width = 3 };
        Box b2 = new Box { Length = 2, Width = 4 };
        Box b3 = b1 + b2;
        
        Console.WriteLine($"New Box: Length={b3.Length}, Width={b3.Width}");
    }
}
