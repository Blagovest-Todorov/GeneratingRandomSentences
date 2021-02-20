using System;

namespace Test
{
    
    class Program
    {
        static void Main(string[] args)
        {

            string[] phrases = new string[]
            {     "Excellent product.",
                  "Such a great product.",
                  "I always use that product.",
                  "Best product of its category.",
                  "Exceptional product.",
                  "I can’t live without this product."  // create an array of given massages
            };

            string[] events = new string[]
            {
                   "Now I feel good.",
                    "I have succeeded with this product.",
                   "Makes miracles. I am happy of the results!",
                   "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.",
                    "I feel great!"   // creaste string array of events
            };

            string[] authors = new string[]
            {
                    "Diana",
                    "Petya",
                    "Stella",
                    "Elena",
                    "Katya",
                    "Iva",
                    "Annie",
                    "Eva"
            }; //create string array of Autors

            string[] cities = new[]
            {   "Burgas",
                    "Sofia",
                    "Plovdiv",
                    "Varna",
                    "Ruse"
            };

            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random();

                //phrases
                string phr = phrases[i];
                int randomIdx = rnd.Next(0, phrases.Length);
                phrases[i] = phrases[randomIdx];
                //phrases[randomIdx] = phr;

                // now for events
                string eve = events[i];
                int randomIdx1 = rnd.Next(0, events.Length);
                events[i] = events[randomIdx1];
                // events[randomIdx1] = eve;

                //authors
                string auth = authors[i];
                int randomIdx2 = rnd.Next(0, authors.Length);
                authors[i] = authors[randomIdx2];
                //authors[randomIdx2] = auth;

                // cities
                string curCity = cities[i];
                int index3 = rnd.Next(0, cities.Length);
                cities[i] = cities[index3];
                //cities[index3] = curCity;


                Console.WriteLine($"{phrases[i]} {events[i]} {authors[i]} - {cities[i]}.");
            }
        }
    }
}
