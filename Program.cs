bool otra=true;
while(otra==true){
Console.WriteLine("CALCULADORA: \n 1-SUMA \n 2-RESTA \n 3-MULTIPLICACION \n 4-DIVISION");
int opcion=int.Parse(Console.ReadLine());
while (opcion <1 || opcion >4 ){
    Console.WriteLine("Ingrese una opcion valida (1-2-3-4)");
    opcion=int.Parse(Console.ReadLine());
}
Console.WriteLine("Ingrese el primer numero a operar: \n");
float a=float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero a operar: \n");
float b=float.Parse(Console.ReadLine());
float resultado=0;
switch(opcion){
    case 1:resultado=a+b;
    break;
    case 2:resultado=a-b;
    break;
    case 3:resultado=a*b;
    break;
    case 4:if(b!=0){
        resultado=a/b;}else{
            Console.WriteLine("El numero b debe ser distinto de 0");
        }
    break;
}
Console.WriteLine("Resutlado: \n"+resultado);
Console.WriteLine("Desea realizar otro calculo? \n 1-SI \n 2-NO");
int otro=int.Parse(Console.ReadLine());
if(otro!=1){
    otra=false;
}
}
