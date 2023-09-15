namespace Lists_DeBord_Joshua
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> games = new()//create a list with the items below
            {
                "Grand Theft Auto 5",
                "Batman Arkham",
                "Fortnite",
                "Apex Legends",
                "Minecraft"
            };

            string[] otherGames = new string[]//creates a 2nd list with the items below
            {
                "Life Is Strange",
                "Human Fall Flat",
            };

            foreach (string game in games)// for each line in the games list, send the to the console
            {
                Console.WriteLine(game);
            }

            Console.WriteLine($"Games in list: {games.Count}");//prints to the console everything in the list #

            games.AddRange(otherGames);//adds othergames list to the games list

            Console.WriteLine($"Games in list: {games.Count}");//prints to the console everything in the list #

            if (games.Contains("Grand Theft Auto 5"))//if the games list includes Grand Theft Auto 5, print to the console.
            {
                Console.WriteLine("Ah yes, let me pull a RPG out of my bum");
            }
            else
            {
                games.Add("Grand Theft Auto 5");//else adds Grand Theft Auto 5 to the list
            }

            int myInt = 6; //creates an integer called myInt equals to 6

            if (myInt < games.Count) //if 6 is 
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("Game isn't available");
            }
            Console.WriteLine("All games:");

            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            games.Sort();

            Console.WriteLine("Sorted List:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            string[] newList = new string[games.Count];

            games.CopyTo(newList);

            games.Clear();

            Console.WriteLine("NewList:");
            foreach (string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }
}