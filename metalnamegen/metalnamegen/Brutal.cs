using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metalnamegen
{
    class Brutal
    {
        static int Main(string[] args)
        {
            Brutal objHeadbang = new Brutal();

            if (args.Length != 1)
            {
                System.Console.WriteLine("You must run this script with an argument");
                System.Console.WriteLine("Enter a word count (1, 2, or 3)");
                System.Console.WriteLine("EX: C:\\> metalnamegen 3");
                Console.ReadKey();
                return 1;
            }

            long wordCount = Int64.Parse(args[0]);

            if (wordCount < 1 || wordCount > 3)
            {
                System.Console.WriteLine("What are you doing? I said 1, 2, or 3!");
                Console.WriteLine("You broke it. It's crippled now -- good job.");
                Console.ReadKey();
                return 1;
            }

            Console.WriteLine(objHeadbang.generateBrutalName(wordCount));
            return 1;
        }

        //array of brutal words
        private string[] wordArray = new string[]{ "Brutal",
                                                   "Awakening",
                                                   "Corpse",
                                                   "Burning",
                                                   "Death",
                                                   "Bloody",
                                                   "Pussy",
                                                   "Moist",
                                                   "Lugubrious",
                                                   "Gurgle",
                                                   "Phlegm",
                                                   "Fetus",
                                                   "Smear",
                                                   "Squirt",
                                                   "Orifice",
                                                   "Maggots",
                                                   "Panties",
                                                   "Vomit",
                                                   "Dripping",
                                                   "Chainsaw",
                                                   "Brazen Bull",
                                                   "Quartering",
                                                   "Ling Chi",
                                                   "Boiling",
                                                   "Flaying",
                                                   "Scaphism",
                                                   "Sawing",
                                                   "Skies",
                                                   "Plastic",
                                                   "Black",
                                                   "Plague",
                                                   "Needle",
                                                   "Sorrow",
                                                   "Fire",
                                                   "Hate",
                                                   "God",
                                                   "Evil",
                                                   "Kill",
                                                   "Fire",
                                                   "Storm",
                                                   "Rain",
                                                   "Lord",
                                                   "Head",
                                                   "Metal",
                                                   "Human",
                                                   "Light",
                                                   "Moon",
                                                   "Winter",
                                                   "Shadow",
                                                   "Demon",
                                                   "Satan",
                                                   "Pain",
                                                   "Suffer",
                                                   "Murder",
                                                   "Divine",
                                                   "Slaughter",
                                                   "Child",
                                                   "Nocturnal",
                                                   "Sorrow",
                                                   "Psycho",
                                                   "Torture",
                                                   "Torment",
                                                   "Wrath",
                                                   "Serpent",
                                                   "Agony",
                                                   "Slave",
                                                   "Heaven",
                                                   "Circle",
                                                   "Grace",
                                                   "Noise",
                                                   "Ancient",
                                                   "Dragon",
                                                   "Hand"
                                                    };

        public string generateBrutalName(long myWordCount)
        {
            Random rando = new Random();

            long counter = myWordCount;
            int index1, index2, index3;
            string strBrutalBandName = "";

            switch (myWordCount)
            {
                case 1:
                    while (counter > 0)
                    {
                        strBrutalBandName = wordArray[rando.Next(wordArray.Length)];
                        counter--;
                    }
                    break;
                case 2:
                    while (counter > 0)
                    {
                        strBrutalBandName += wordArray[rando.Next(wordArray.Length)] + " ";
                        counter--;
                    }
                    break;
                case 3:
                    while (counter > 0)
                    {
                        strBrutalBandName += wordArray[rando.Next(wordArray.Length)] + " ";
                        counter--;
                    }
                    break;
                default:
                    Console.WriteLine("You broke it. Bad.");
                    break;
            }

            return strBrutalBandName;
        }
    }

}
