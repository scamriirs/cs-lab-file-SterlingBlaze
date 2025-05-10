using System;

class Person {
    public Person() {
        Console.WriteLine("Default constructor called");
    }
}

class DefaultConstructor {
    static void Main() {
        Person p = new Person();
    }
}
