
using Video;

Personnage A = new Personnage();
Personnage B = new Personnage();
A.NamePerso();
B.NamePerso();
A.Attack(B);
B.Attack(A);
A.Attack(B);
B.Attack(A); 
while(A.IsAlive()) { B.Attack(A); }
if (!A.IsAlive()) { Console.WriteLine(B.name + " a gagné"); }

