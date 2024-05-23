/*Ejercicio 3. Ingrese al Branch CalculadoraV2 para implementar las mejoras en la
calculadora.. Solicite al usuario un número y muestre por pantalla:
● El valor absoluto de un número
● El cuadrado
● La raíz cuadrada
● El seno
● El Coseno
● La parte entera de un tipo float.
3
Taller de Lenguajes I - 2024
Programador Universitario / Licenciatura en Informática / Ingeniería en Informática
Trabajo Práctico Nro 6
Luego de esto, solicite dos números al usuario y determine:
● El Máximo entre los dos números
● El Mínimo entre los dos números
Para TODOS los casos, no olvide contemplar siempre el caso de que el usuario no
ingrese un número válido.
Suba al repositorio github ambas ramas.*/
using System;

Console.WriteLine("Ingrese el numero: \n");
float numero=float.Parse(Console.ReadLine());
Console.WriteLine("VALOR ABSOLUTO: \n"+Math.Abs(numero));
Console.WriteLine("CUADRADO: \n"+Math.Pow(numero,2));
if(numero>=0){
    Console.WriteLine("RAIZ CUADRADA: \n"+Math.Sqrt(numero));
}
Console.WriteLine("EL SENO: \n"+Math.Sin(numero));
Console.WriteLine("EL COSENO: \n"+Math.Cos(numero));
Console.WriteLine("PARTE ENTERA: \n"+Math.Truncate(numero));

Console.WriteLine("Ingrese el primer numero: \n");
float a=float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: \n");
float b=float.Parse(Console.ReadLine());
if(a<b){
    Console.WriteLine("EL MAXIMO ES: \n"+b);
}else{
    Console.WriteLine("EL MAXIMO ES: \n"+a);
}

