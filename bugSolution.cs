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
        MyClass obj1 = 10; 
        int value1 = obj1; 

        Console.WriteLine(value1); 

        MyClass obj2 = new MyClass(20);
        int value2 = obj2 + 5; 

        Console.WriteLine(value2); 
        MyClass obj3 = obj2 + 5; 
        Console.WriteLine(obj3); 

        MyClass obj4 = obj2 + obj1; 
        Console.WriteLine(obj4); 

        // Solution: Explicitly cast to int to resolve ambiguity
        int value3 = (int)obj2 + (int)obj1 + 5; 
        Console.WriteLine(value3); // Output: 35
    }
}