using System;

class Program
{
    static void Main(string[] args)
    {
        Elephant licinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

        Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
        while (true)
        {
            char input = Console.ReadKey(true).KeyChar;
            Console.WriteLine("You pressed " + input);
            if (input == '1')
            {
                Console.WriteLine("Calling lloyd.WhoAmI()");
                lloyd.WhoAmI();
            }
            else if (input == '2')
            {
                Console.WriteLine("Calling lucinda.WhoAmI()");
                licinda.WhoAmI();
            }
            else if (input == '3')
            {
                Elephant holder;
                holder = lloyd;
                lloyd = licinda;
                licinda = holder;
                Console.WriteLine("References have been swapped");
            }
            else if (input == '4')
            {
                lloyd = licinda;
                lloyd.EarSize = 4321;
                lloyd.WhoAmI();
            }
            else return;
            Console.WriteLine();
        }


    }
}

class Elephant
{
    public int EarSize;
    public string Name;
    public void WhoAmI()
    {
        Console.WriteLine("My name is " + Name + ".");
        Console.WriteLine("My ears are " + EarSize + " inches tall.");
    }

}
