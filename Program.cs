using EjercicioInterfaces;

CalcularAreas calcularAreas=new CalcularAreas();
double l, B, b, h, D, d;

Console.WriteLine("       Ingrese datos del Cuadrado       ");
Console.WriteLine("----------------------------------------");
Console.Write("Ingrese un lado del cuadraddo en cm: ");
l=Convert.ToDouble(Console.ReadLine());
calcularAreas.AreaDeUnCuadrado(l);
Console.WriteLine();

Console.WriteLine("      Ingrese datos del Rectángulo      ");
Console.WriteLine("----------------------------------------");
Console.Write("Ingrese la base en cm: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la altura en cm: ");
h = Convert.ToDouble(Console.ReadLine());
calcularAreas.AreaDeUnRectangulo(b, h);
Console.WriteLine();

Console.WriteLine("         Ingrese datos del Rombo        ");
Console.WriteLine("----------------------------------------");
Console.Write("Ingrese la diagonal mayor en cm: ");
D = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la diagonal menor en cm: ");
d = Convert.ToDouble(Console.ReadLine());
calcularAreas.AreaDeUnRombo(D, d);
Console.WriteLine();

Console.WriteLine("       Ingrese datos del Trapecio       ");
Console.WriteLine("----------------------------------------");
Console.Write("Ingrese la base mayor en cm: ");
B = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la base menor en cm: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la altura en cm: ");
h = Convert.ToDouble(Console.ReadLine());
calcularAreas.AreaDeUnTrapecio(B, b, h);
Console.WriteLine();

Console.WriteLine("       Ingrese datos del Triangulo      ");
Console.WriteLine("----------------------------------------");
Console.Write("Ingrese la base en cm: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la altura en cm: ");
h = Convert.ToDouble(Console.ReadLine());
calcularAreas.AreaDeUnTriangulo(b, h);
Console.WriteLine();

Console.WriteLine("            R E S U L T A D O           ");
Console.WriteLine("----------------------------------------");
calcularAreas.Imprimir();
