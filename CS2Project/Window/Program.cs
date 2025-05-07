using Newtonsoft.Json.Linq;

// I used https://www.mooict.com/c-tutorial-how-to-load-images-from-url-to-a-picture-box/ to learn how to load an image from a URL into a picture box.
// I used https://tcgdex.dev/ to learn about the TCGdex API.
// I would have liked to have been able to use a different set of cards, but I didn't think I could implement it in time.
// I would have put the different sets in an array and used a random number to choose one.
// Then I could have gotten more random cards from that set.
// I could have also just gone straight to a card's link, but then I would have needed to use the API find out how many cards were in that set.
// Then I would have had to use a random number to choose a card from that set.
// I could have gotten more detailed information about the card that way, like the rarity and what kind of variants it has.

namespace Window
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // As soon as it starts it will ask the API for a card's information.
            _ = Request.GetCardInfo();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    class Request
    {
        public static string CardImage { get; set; }
        public static string CardName { get; set; }

        /// <summary>
        /// Gets information of a specific pokemon card using the TCGdex API.
        /// </summary>
        /// <returns> The API's response </returns>
        public static async Task GetCardInfo()
        {
            // I didn't know how to use an API, so I asked AI for some examples of how to use an API in C#.
            // This is part of the code it gave me. I changed most of it to fit my needs.
            using (HttpClient client = new HttpClient())

            try
            {
                JObject cardData = JObject.Parse(await client.GetStringAsync("https://api.tcgdex.net/v2/en/sets/base1"));

                // Gets the number for a random card in the set.
                int cardNumber = GetRandomCard((int)cardData["cardCount"]["total"]);

                // Gets the link for the card image.
                CardImage = (string)cardData["cards"][cardNumber]["image"] + "/high.jpg";
                // Gets the name of the card.
                CardName = (string)cardData["cards"][cardNumber]["name"];
                }
                catch (HttpRequestException e)
            {
                Console.WriteLine("Request error: " + e.Message);
            }
        }

        /// <summary>
        /// Would have used this to choose a random set of cards, but I couldn't finish it in time.
        /// </summary>
        /// <returns> A random number </returns>
       /* public static int GetRandomSet()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }*/

        /// <summary>
        /// Uses a random number to choose a random card from a set.
        /// </summary>
        /// <returns> A random number </returns>
        public static int GetRandomCard(int setMax)
        {
            Random random = new Random();
            return random.Next(0, setMax);
        }
    }
}