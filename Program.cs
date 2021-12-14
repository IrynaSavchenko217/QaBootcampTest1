class Palindr

{
    public static bool Palindromtest(string s)
    {
        for (int i = 0; i < s.Length / 2; i++)

            if (s[i] != s[s.Length - i - 1])
                return false;
        return true;

    }

    static void Main(String[] args)
    {
        string n;
        n = Console.ReadLine();
        n = n.Replace(',', ' ');
        string[] array = n.Split(' ');
        for (int i = 0; i < array.Length; i++)
        {
            string s = array[i];
            s = s.ToLower();
            if (Palindromtest(s))
                Console.WriteLine(s + " - палиндром");
            else Console.WriteLine(s + "- не палиндром");
        }
    }
}