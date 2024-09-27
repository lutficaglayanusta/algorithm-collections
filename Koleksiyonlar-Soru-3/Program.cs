namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen istediğiniz bir cümle giriniz: ");
            string words = Console.ReadLine();

            // Sesli harfler: a, e, ı, i, o, ö, u, ü
            string[] harfler = { "a", "e", "ı", "i", "o", "ö", "u", "ü" };
            List<string> new_words = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < harfler.Length; j++)
                {
                    char new_char = Convert.ToChar(harfler[j]);
                    if (words[i] == new_char)
                    {
                        new_words.Add(Convert.ToString(new_char));
                    }
                }
            }

            // Sesli harfleri ekrana yazdır
            foreach (var new_word in new_words)
            {
                Console.WriteLine(new_word);
            }
        }
    }
}
