public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass obj)
    {
        return obj.MyProperty;
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 10; // Implicit conversion from int to MyClass
        int value1 = obj1;  // Implicit conversion from MyClass to int

        Console.WriteLine(value1); // Output: 10

        MyClass obj2 = new MyClass(20);
        int value2 = obj2 + 5; // Implicit conversion of obj2 to int, then addition

        Console.WriteLine(value2); //Output:25
        MyClass obj3 = obj2 + 5; // Implicit conversion of obj2 to int, addition, then implicit conversion to MyClass
        Console.WriteLine(obj3); //Output:25

        MyClass obj4 = obj2 + obj1; // Implicit conversion to ints, addition, implicit conversion to MyClass
        Console.WriteLine(obj4); //Output:30

        // This line throws an exception because implicit conversion from MyClass to int is called twice, producing ambiguity
        int value3 = obj2 + obj1 + 5; 
    }
}