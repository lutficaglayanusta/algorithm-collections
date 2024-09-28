namespace Koleksiyonlar_Soru_2;

class Program
{
    static void Main(string[] args)
    {
       int[] numbers = new int[20]; // 0 elemanlı boş bir int dizisi
       int[] maxNumbers = new int[3];
       int[] minNumbers = new int[3];

       for(int i=0;i<20;i++){
            Console.Write("Lütfen bir sayı giriniz: ");
           int chooseNumber = Convert.ToInt32(Console.ReadLine());
           numbers[i] = chooseNumber;
       }
       Array.Sort(numbers);
       for (int i = 0; i < 3; i++)
        {
            minNumbers[i]=numbers[i];
        }
        for (int i = 0; i < 3; i++)
        {
            maxNumbers[i] = numbers[numbers.Length - 1 - i];
        }
        int minTotal=0;
        int maxTotal=0;
        foreach (var item in minNumbers)
        {
            minTotal +=item;
        }
        int minResult=minTotal/3;
        foreach (var item in maxNumbers)
        {
            maxTotal += item;
        }
        int maxResult=maxTotal/3;
        Console.WriteLine($"3 tane en büyük sayının ortalaması: {maxResult}");
        Console.WriteLine($"3 tane en küçük sayının ortalaması: {minResult}");
        Console.WriteLine($"2 ortalamanın toplamı: {maxResult+minResult} ");
    }
}
