Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
//EJERCICIO 1
Console.WriteLine("Ingrese el numero a invertir");
int num = int.Parse(Console.ReadLine());
int reversed = 0;
while (num > 0)
{
    int digit = num % 10;
    reversed = reversed * 10 + digit;
    num /= 10;
}
Console.WriteLine("El número invertido es: " + reversed);

