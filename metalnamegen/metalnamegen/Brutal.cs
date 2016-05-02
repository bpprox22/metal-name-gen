using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metalnamegen
{
    public class Brutal
    {       
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
