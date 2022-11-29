string[] a = new string[4];
a[0] = "monday";
a[1] = "up";
a[2] = "to";
a[3] = "you";
int count = 0;
for (int i = 0; i < a.Length; i++)
{
   if (a[i].Length <= 3)
   {
   count++;
   }
}

string[] array2 = new string[count];
int j = 0;
for (int i = 0; i < a.Length; i++)
    {
     if (a[i].Length <= 3)
     {
      array2[j] = a[i];
      System.Console.WriteLine(array2[j]);
      j++;
     }
    }