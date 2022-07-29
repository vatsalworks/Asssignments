// See https://aka.ms/new-console-template for more information

namespace _12JulyAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            ImplementationOfAbstractClass imp = new ImplementationOfAbstractClass();
            imp.Hello();
            imp.Hi();
            imp.Hey();
            AnotherImplementationOfAbstractClass anImp = new AnotherImplementationOfAbstractClass(); 
            anImp.Hello();
            anImp.Hi();
            anImp.Hey();

            // q6 No we can't type-cast the derive class instance to base class?

            //AnotherSimpleClass another = new AnotherSimpleClass();
            //derivedFromAnotherSimpleClass der = (AnotherSimpleClass)another; 

            //q7 but it is inaccessible

            Sealed seal = new Sealed();
            seal.hey();

            //newSeal ns = new newSeal();


        }
    }
}