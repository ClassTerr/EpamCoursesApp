using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_2
{
    class FairyTale
    {
        public List<Character> Characters { get; set; }

        int currentCharacterIndex = 0;
        public int CurrentCharacterIndex { get => currentCharacterIndex; set => currentCharacterIndex = value; }

        public bool IsEnded
        {
            get => currentCharacterIndex >= Characters.Count;
        }

        public FairyTale()
        {
            Characters = new List<Character>();
            Characters.Add(new Chick());
            Characters.Add(new Chicken());
            Characters.Add(new Cock());
            Characters.Add(new Goat());
            Characters.Add(new Lamb());
            Characters.Add(new Cow());
            Characters.Add(new Horse());
            Characters.Add(new Cat());
            Characters.Add(new Dog());
            Characters.Add(new Mistress());
        }


        public void NextStep()
        {
            if (IsEnded)
                return;

            string prefix = "у нас живет ";
            if (Characters[currentCharacterIndex].Name == "хозяйка")
                prefix = "а вот идёт ";

            Console.WriteLine(prefix + Characters[currentCharacterIndex]);
            Console.WriteLine(prefix + Characters[currentCharacterIndex]);
            for (int i = currentCharacterIndex; i >= 0; i--)
            {
                if (i == currentCharacterIndex || i == 0)
                    Console.Write("a ");

                Character c = Characters[i];
                Console.WriteLine(c.Name + " " + c.Speech);
            }
            Console.WriteLine();
            CurrentCharacterIndex++;
        }
    }
}
