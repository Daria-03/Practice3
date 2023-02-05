//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.Write("Введите координаты Ax точки: ");
double Ax = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты Ay точки: ");
double Ay = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты Cx точки: ");
double Cx = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты Bx точки: ");
double Bx = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты By точки: ");
double By = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты Cy точки: ");
double Cy = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Cx - Cy, 2));
System.Console.WriteLine(distance);