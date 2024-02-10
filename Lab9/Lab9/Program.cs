class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите сообщение: ");
        string message = Console.ReadLine();

        Console.WriteLine("Введите ключ: ");
        string tempKey = Console.ReadLine();

        char[] key = tempKey.ToCharArray();
        char[] S = new char[256];

        for (int i = 0; i < 256; i++)
        {
            S[i] = (char)i;
        }

        int j = 0;

        for (int i = 0; i < 256; i++)
        {
            j = (j + S[i] + key[i % key.Length]) % 256;
            char temp = S[i];
            S[i] = S[j];
            S[j] = temp;
        }

        int x = 0;
        int y = 0;

        for (int i = 0; i < message.Length; i++)
        {
            x = (x + 1) % 256;
            y = (y + S[x]) % 256;

            char temp = S[x];

            S[x] = S[y];
            S[y] = temp;

            char k = S[(S[x] + S[y]) % 256];

            Console.Write((message[i] ^ k) + " ");
        }

    }
}