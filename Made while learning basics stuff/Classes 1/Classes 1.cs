using System;

namespace Classes_1
{
    class Wizard{
        public string name;
        public string favoriteSpell;
        private int spellSlots;
        private float exp;
        
        public static int Count;

        public Wizard(string _name, string _favoriteSpell){
            name = _name;
            favoriteSpell = _favoriteSpell;
            spellSlots = 2;
            exp = 0;

            Count ++;
        }

        public void CastSpell(){
            if(spellSlots > 0){
            Console.WriteLine(name + " casts " + favoriteSpell);
            spellSlots--;
            exp += 0.3f;
            }
            else{
                Console.WriteLine(name + " is out of spell slots.");
            }
        }
        public void Meditate(){
            Console.WriteLine(name + " meditates to regain spell slots.");
            spellSlots = 2;
        }

    }
    
    class Program{
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard("Harry Pot", "Spanish Inquisition");

            wizard01.CastSpell();
            
            Wizard wizard02 = new Wizard("Doubledoor", "Magic or something idk");

            wizard02.CastSpell();

            Console.WriteLine(Wizard.Count);
            
            Console.ReadKey();
        }
    }
}
