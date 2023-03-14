string[] array = {"start", "1234","321" };
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}


Console.WriteLine("=====");


string[] copy = new string[array.Length];

Array.Copy(array, copy, array.Length);

for (int i = 0; i < copy.Length; i++)
{
    if (array[i].Length <= 3)
    {
    Console.WriteLine(copy[i]);
    }
}
