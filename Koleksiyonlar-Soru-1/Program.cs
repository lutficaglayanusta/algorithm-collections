using System.Collections;

namespace algoritma;

class Program
{
    static void Main(string[] args)
    {
        ArrayList primeNumbers = new ArrayList();
        ArrayList notPrimeNumbers = new ArrayList();
        
        for (int i = 0; i < 20; i++){
            Console.Write("Lütfen sıfırdan büyük değer giriniz: ");
            int chooseNumber = Convert.ToInt32(Console.ReadLine());
            if (chooseNumber >0){
                bool isPrime = true;   
                for(int j=2;j<chooseNumber;j++){
                    if(chooseNumber % j ==0){
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) {
                    primeNumbers.Add(chooseNumber);
                } else {
                    notPrimeNumbers.Add(chooseNumber);
                }
            }else{
                Console.WriteLine("Lütfen sıfırdan daha büyük değerler giriniz.");
            }
        }
         
        notPrimeNumbers.Sort();
        notPrimeNumbers.Reverse();
        primeNumbers.Sort();
        primeNumbers.Reverse();

        
        Console.WriteLine("Asal olmayan sayılar:");
        foreach(var notPrimeNumber in notPrimeNumbers)
            Console.WriteLine(notPrimeNumber);
        
        Console.WriteLine("Asal olan sayılar");
        foreach(var primeNumber in primeNumbers)
            Console.WriteLine(primeNumber);

        Console.WriteLine($"Asal olmayan sayılar miktarı: {notPrimeNumbers.Count} ");
        Console.WriteLine($"Asal olan sayılar miktarı: {primeNumbers.Count} ");

        int[] primeArrays = new int[20]; 
        primeArrays =(int[]) primeNumbers.ToArray(typeof(int));

        int[] notPrimeArrays = new int[20]; 
        notPrimeArrays =(int[]) notPrimeNumbers.ToArray(typeof(int));

        int notPrimeTotal =0;
        int primeTotal = 0;


        foreach(var primeArray in primeArrays){
            primeTotal += primeArray;
        }
        foreach(var notPrimeArray in notPrimeArrays){
            notPrimeTotal += notPrimeArray;
        }
        Console.WriteLine($"Asay sayıların toplamı: {primeTotal}");
        Console.WriteLine($"Asal olmayan sayıların toplamı: {notPrimeTotal}");
    }
}
