public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize MyProperty before accessing it
        MyProperty = 10;
        Console.WriteLine(MyProperty); // Correct: MyProperty is now initialized
    }
}