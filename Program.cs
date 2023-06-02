Searches objSearch = new Searches();
int[] iArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
int key = 2222;
var outPut = objSearch.BinarySearch(iArray, key);
Console.WriteLine($"output value = {outPut}");

int[] arrUnSorted = { 800, 11, 50, 771, 649, 770, 240, 9 };
objSearch.BubbleSort2(arrUnSorted);
Console.ReadLine();

int numberFact = 5;
var fact = objSearch.Factorial(numberFact);
Console.WriteLine($"Factorial of {numberFact} =  {fact.ToString()}");

Console.ReadLine();

Maths objMath = new Maths();
int sum = objMath.Add(3, 5);
Console.WriteLine("Hello, World!");
Console.WriteLine($"Sum={sum}");
Console.WriteLine("Done.");
int[] inputArray = { 1, 2, 3, 4, 5, 6, 7, 7, 8 };
