// See https://aka.ms/new-console-template for more information
double[] A = new double [3];
double res;
for (int i = 0; i < 3;) {
    Console.WriteLine($"Введите {i+1} координату точки А");
A[i] = Convert.ToDouble(Console.ReadLine());
i += 1;
}
double[] B = new double [3];
for (int i = 0; i < 3;) {
    Console.WriteLine($"Введите {i+1} координату точки B");
B[i] = Convert.ToDouble(Console.ReadLine());
i += 1;
}
res = Math.Sqrt(Math.Pow(B[0] - A[0], 2) + Math.Pow(B[1] - A[1], 2) + Math.Pow(B[2] - A[2], 2));
Console.WriteLine($"Расстояние между двумя точками = {res}");


