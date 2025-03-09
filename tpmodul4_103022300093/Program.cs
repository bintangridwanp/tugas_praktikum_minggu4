class Program
{
    static void Main()
    {
        DoorMachine pintu = new DoorMachine();

        Console.WriteLine("\nMenekan tombol buka pintu...");
        pintu.BukaPintu();

        Console.WriteLine("\nMenekan tombol kunci pintu...");
        pintu.KunciPintu();
    }
}
