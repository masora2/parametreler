namespace methoddeneme
{
    class method
    {
        static void Main(string[] args)
        {
            MainClass mainClass = new MainClass();

            mainClass.DenemeMethod();
            Console.ReadLine();
        }
    }
    public class MainClass
{
    public void VoidMethodlarOrnek()
    {
            Console.WriteLine("VoidMethodlarOrnek Çalıştı");
            Console.WriteLine("VoidMethodlarOrnek Çalıştı");
            Console.WriteLine("VoidMethodlarOrnek Çalıştı");
            Console.WriteLine("VoidMethodlarOrnek Çalıştı");
            Console.WriteLine("VoidMethodlarOrnek Çalıştı");
            Console.WriteLine("VoidMethodlarOrnek Çalıştı");
            Console.WriteLine("VoidMethodlarOrnek Çalıştı");
            Console.WriteLine("VoidMethodlarOrnek Çalıştı");
            Console.WriteLine("VoidMethodlarOrnek Çalıştı");
            Console.WriteLine("VoidMethodlarOrnek Çalıştı");
        }

    public void DenemeMethod()
    {
        Console.WriteLine("DenemeMethod Çalıştı");

        VoidMethodlarOrnek();
        Console.WriteLine("Program Bitti");
    }


}

}