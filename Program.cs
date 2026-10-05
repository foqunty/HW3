Console.Write("Enter Celcius temperature: ");
double celsius = double.Parse(Console.ReadLine()!);
double fahrenheit= (celsius*9/5)+32;
double kelvin = celsius + 273.15;
Console.WriteLine($"Fahrenheit: {fahrenheit:F2}F");
Console.WriteLine($"Kelvin: {kelvin:F2}K\n");







Console.Write("Enter 3 digits number: ");
int num = int.Parse(Console.ReadLine()!);
int digit1 = num /100;
int digit2 = (num /10) % 10;
int digit3 = num % 10;
Console.WriteLine($"Hundreds: {digit1}");
Console.WriteLine($"Tens: {digit2}");
Console.WriteLine($"Units: {digit3}\n");






Console.Write("Enter first grade: ");
float grade1 = float.Parse(Console.ReadLine()!);
Console.Write("Enter second grade: ");
float grade2 = float.Parse(Console.ReadLine()!);
Console.Write("Enter third grade: ");
float grade3 = float.Parse(Console.ReadLine()!);
float sum = grade1+grade2+grade3;
float average = sum/3;
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {average:F2}");
if(average >=60){
    Console.WriteLine("Passed");
}
else{
    Console.WriteLine("Failed");
}
Console.WriteLine("\n");

