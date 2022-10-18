Random rnd = new Random();
int number = 20;
int a = 1;
int b = 900;

int[] A = new int[number];
int[] B = new int[number];

for (int i = 0; i < A.Length; i++)
{  
   A[i] = rnd.Next(a,b);
   if (A[i] <= 888)
   {
    B[i] = A[i];
   }
}
Array.Sort(B);
Array.Reverse(B);
Console.WriteLine(string.Join("\n \b", B));
Console.ReadLine();
