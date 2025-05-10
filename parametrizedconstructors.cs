using System;

class Student {
    public Student(string name, int age) {
        Console.WriteLine($"Student created: {name}, {age} years old");
    }
}

class ParameterizedConstructor {
    static void Main() {
        Student s = new Student("Alice", 20);
    }
}
