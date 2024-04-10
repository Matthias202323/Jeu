

namespace Video
{
    internal class Personnage
    {
        public int pv = 20;
        public int force = 18;
        public int défense = 14;

        public string name = "";
     

        public string NamePerso()
        {
            Console.WriteLine("Enterez un nom");
            name = Console.ReadLine();
            return name;

        }
        public bool IsAlive()
        {
            if (pv > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Le personnage " + name + " est mort");
                return false;
            }
        }

        public void Attack(Personnage A)
        {
            A.pv = (A.pv) - (force - A.défense);
            Console.WriteLine(A.name  +" Ponts de vie="+ A.pv);
        }
    }

   
}

