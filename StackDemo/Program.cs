Stack<string> stackDemo = new Stack<string>();

PushDemo(stackDemo);

PopDemo(stackDemo);

PeekDemo(stackDemo);

ContainsDemo(stackDemo);

CountDemo(stackDemo);

static void PushDemo(Stack<string> stackDemo)
{
    stackDemo.Push("Melon");
    stackDemo.Push("Banana");
    stackDemo.Push("Kiwi");

    Console.WriteLine("Elements in the Stack:");

    foreach (var item in stackDemo) Console.WriteLine(item);
 
    Console.WriteLine("------------------------------");
}

static void PopDemo(Stack<string> stackDemo)
{
    var poppedElement = stackDemo.Pop();

    Console.WriteLine($"Popped element: {poppedElement}");

    Console.WriteLine("\nElements in the Stack after Pop operation:");
    
    foreach (var item in stackDemo) Console.WriteLine(item);

    Console.WriteLine("------------------------------");
}

static void PeekDemo(Stack<string> stackDemo)
{
    var topElement = stackDemo.Peek();

    Console.WriteLine($"Top element: {topElement}");
    
    Console.WriteLine("------------------------------");
}

static void ContainsDemo(Stack<string> stackDemo)
{
    var containsBanana = stackDemo.Contains("Banana");
    var containsApple = stackDemo.Contains("Apple");

    Console.WriteLine($"Stack contains Banana: {containsBanana}");
    Console.WriteLine($"Stack contains Apple: {containsApple}");

    Console.WriteLine("------------------------------");
}

static void CountDemo(Stack<string> stackDemo)
{
    var numberOfElements = stackDemo.Count;

    Console.WriteLine($"Number of elements in the Stack: {numberOfElements}");

    Console.WriteLine("------------------------------");
}