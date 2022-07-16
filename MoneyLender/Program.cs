namespace MoneyLender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // testing branch
            Guy Joe = new Guy() { Cash = 50, Name = "Joe" };
            Guy Bob = new Guy() { Cash = 100, Name = "Bob" };

            while(true)
            {
                Joe.WriteMyInfo();
                Bob.WriteMyInfo();
                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if(howMuch == "") return;
                if(int.TryParse(howMuch, out int IntHowMuch))
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if(whichGuy == Joe.Name)
                    {
                        int give = Joe.GiveCash(IntHowMuch);
                        Bob.ReceiveCash(give);
                    }
                    else if(whichGuy == Bob.Name)
                    {
                        int give = Bob.GiveCash(IntHowMuch);
                        Joe.ReceiveCash(give);
                    }
                    else
                    {
                        Console.WriteLine("Please enter Joe or Bob");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit)."); 
                }
            }
        }
    }
}