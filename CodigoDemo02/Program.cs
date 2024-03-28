// See https://aka.ms/new-console-template for more information


#region UsoDelIf






//Tipado: Fuertemente tipado


//EJERCICIO 3
//int calificacion = 0;
//string mensaje = "";
//Console.WriteLine("Ingresa la calificación");
//calificacion = Convert.ToInt32(Console.ReadLine());


//&& => AND
//|| => OR

//if (calificacion>=90  && calificacion<=100 )
//{
//    mensaje = "Excelente";
//}
//if (calificacion >= 80 && calificacion <= 89)
//{
//    mensaje = "Muy Bueno";
//}
//if (calificacion >= 70 && calificacion <= 79)
//{
//    mensaje = "Bueno";
//}

//if (calificacion >= 60 && calificacion <= 69)
//{
//    mensaje = "Suficiente";
//}

//if ( calificacion < 60)
//{
//    mensaje = "Insuficiente";
//}
//Console.WriteLine(mensaje);



//EJERCICIO 4
//int numeroDia = 0;
//string diaSemana = "";
//Console.WriteLine("Ingresa el día de la semana");
//numeroDia = Convert.ToInt32(Console.ReadLine());

//if (numeroDia == 1)
//{
//    diaSemana = "Lunes";
//}

//if (numeroDia == 2)
//{
//    diaSemana = "Martes";
//}

//if (numeroDia == 3)
//{
//    diaSemana = "Miércoles";
//}
//if (numeroDia == 4)
//{
//    diaSemana = "Jueves";
//}
//if (numeroDia == 5)
//{
//    diaSemana = "Viernes";
//}
//if (numeroDia == 6)
//{
//    diaSemana = "Sábado";
//}
//if (numeroDia == 7)
//{
//    diaSemana = "Domingo";
//}

//Console.WriteLine("El día de la semana que ingresó es");
//Console.WriteLine(diaSemana);




//EJERCICIO 1
//int numero1, numero2;

//Console.WriteLine("Ingresa el primer número");
//numero1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Ingresa el segundo número");
//numero2 = Convert.ToInt32(Console.ReadLine());


//if (numero2>numero1)
//{
//    Console.WriteLine("El segundo número es el mayor");
//    Console.WriteLine(numero2);
//}
//else
//{
//    Console.WriteLine("El primer número es el mayor");
//    Console.WriteLine(numero1);
//}



//int edad = 0;

//Console.WriteLine("Ingresa la Edad");

//edad =  Convert.ToInt32(Console.ReadLine());

//if (edad>18)
//{
//    Console.WriteLine("Mayor de Edad");
//}
//else
//{
//    Console.WriteLine("Menor de Edad");
//}


//string usuario = "";
//Console.WriteLine("Ingrese su Usuario");

//Leo la información desde la consola.
//usuario = Console.ReadLine();

//if (usuario == "Hugo")
//{
//    Console.WriteLine("Bienvenido Señor Hugo");
//}

//int numero = 0;
//Console.WriteLine("Ingresa el número");
//numero = Convert.ToInt32( Console.ReadLine());
//Int Parse

//% represen
//if (numero % 2==0)
//{
//    Console.WriteLine("El número es par");
//}
//else
//{
//    Console.WriteLine("El número es impar");
//}





#endregion





#region UsoDelSwitch

//EJERCICIO 10

int opcion = 0;
int lado = 0;
int area = 0;
int volumen = 0;

Console.WriteLine("INGRESE UNA DE LAS OPCIONES");
Console.WriteLine("===========================");

Console.WriteLine("\n");//Salto de Línea
Console.WriteLine("1.Calcular el área del cuadrado");
Console.WriteLine("2.Calcular el volúmen del cubo");
Console.WriteLine("3.Salir");

opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
	case 1:
        Console.WriteLine("AREA");
        Console.WriteLine("======");
        Console.WriteLine("Ingrese el lado del cuadrado");

        lado = Convert.ToInt32(Console.ReadLine());
        area = lado * lado;

        Console.WriteLine("El área del cuadrado es: ");
        Console.WriteLine(area);

        break;

    case 2:
        Console.WriteLine("VOLUMEN");
        Console.WriteLine("========");
        Console.WriteLine("Ingrese el lado del cuadrado");
        
        lado = Convert.ToInt32(Console.ReadLine());
        volumen = lado * lado*lado;
        
        Console.WriteLine("El volumen del cubo es: ");
        Console.WriteLine(volumen);
        break;

    case 3:
        Console.WriteLine("GRACIAS");
        break;

    default:
        Console.WriteLine("OPCIÓN INCORRECTA");
        break;
}





//EJERCICIO 5

//int mes;
//string mensaje="";
//Console.WriteLine("Ingrese el mes");

//mes = Convert.ToInt32( Console.ReadLine());

//switch (mes)
//{
//	case 1 or 2 or 3:
//		mensaje = "Verano";
//		break;
//    case 4 or 5 or 6:
//        mensaje = "Otoño";
//        break;
//    case 7:
//    case 8:
//    case 9:
//        mensaje = "Primavera";
//        break;
//    case 10:
//    case 11:
//    case 12:
//        mensaje = "Invierno";
//        break;

//    default:
//		break;
//}

//Console.WriteLine(mensaje);




//+
//-
//*
//%

//string operacion = "";
//int numero1,numero2;
//int resultado = 0;
//Console.WriteLine("Ingrese la operación a ejecutar");
//Console.WriteLine("-Sumar (+)");
//Console.WriteLine("-Multiplicar (x)");
//Console.WriteLine("-Restar (-)");
//Console.WriteLine("-Restar (/)");

//operacion = Console.ReadLine();

//Console.WriteLine("Ingrese primer número");
//numero1 = Convert.ToInt32( Console.ReadLine());
//Console.WriteLine("Ingrese segundo número");
//numero2 =  Convert.ToInt32(Console.ReadLine());


//switch (operacion)
//{
//	case "+":
//        resultado = numero1 + numero2;
//        Console.WriteLine("El  resultado de la suma es");
//        Console.WriteLine(resultado);

//        break;
//    case "-":
//        resultado = numero1 - numero2;
//        Console.WriteLine("El  resultado de la resta es");
//        Console.WriteLine(resultado);

//        break;
//    case "x":
//    case "X":
//        resultado = numero1 * numero2;
//        Console.WriteLine("El  resultado de la multiplicación es");
//        Console.WriteLine(resultado);

//        break;
//    case "/":

//        if (numero2==0)
//        {
//            Console.WriteLine("No hay división por cero");
//        }
//        else
//        { 
//        resultado = numero1 / numero2;
//        Console.WriteLine("El  resultado de la división es");
//        Console.WriteLine(resultado);
//        }


//        break;
//    default:
//        Console.WriteLine("Operación incorrecta");
//        break;
//}









//string calificacion = "";
//string mensaje = "";

//Console.WriteLine("Ingrese la Calificación");
//calificacion = Console.ReadLine();

//switch (calificacion)
//{
//    case "A":
//        mensaje = "Felicitaciones!";
//        break;
//    case "B":
//        mensaje = "Buen Trabajo!";
//        break;
//    case "C":
//        mensaje = "Mayor Esfuerzo";
//        break;
//    case "D":
//        mensaje = "Un poco de fé";
//        break;
//    default:
//        mensaje = "Letra Incorrecta";
//        break;
//}

//Console.WriteLine(mensaje);

//int numeroDia = 0;
//string diaSemana = "";
//Console.WriteLine("Ingresa el día de la semana");
//numeroDia = Convert.ToInt32(Console.ReadLine());

//switch (numeroDia)
//{
//	case 1:
//        diaSemana = "Lunes";
//        break;
//    case 2:
//        diaSemana = "Martes";
//        break;
//    case 3:
//        diaSemana = "Miércoles";
//        break;
//    case 4:
//        diaSemana = "Jueves";
//        break;
//    case 5:
//        diaSemana = "Viernes";
//        break;
//    case 6:
//        diaSemana = "Sábado";
//        break;
//    case 7:
//        diaSemana = "Domingo";
//        break;
//    default:
//        diaSemana = "Número incorrecto";
//        break;
//}

//Console.WriteLine("El día de la semana que ingresó es");
//Console.WriteLine(diaSemana);



#endregion

Console.Read();




