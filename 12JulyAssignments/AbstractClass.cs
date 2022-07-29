using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12JulyAssignments
{
    public abstract class AbstractClass
    {
        // Q3. Yes we have static members in abstract class

        public static int num = 25;

        public static void hola()
        {
            Console.WriteLine("Hola, this is a static method in abstract class");
        }
        public abstract void Hi();
        public abstract void Hello();

        protected virtual void Hey()
        {
            Console.WriteLine("Hey there");
        }

        // Q1. No we cannot have private virtual methods in Abstract class

        //private virtual void Greetings()
        //{
        //    Console.WriteLine("Greetings");
        //}

        // Q1. Yes we can have protected virtual methods in Abstract class but it can't be overriden
        protected virtual void Welcome()
        {
            Console.WriteLine("Welcome");
        }
    }

    public class ImplementationOfAbstractClass : AbstractClass
    {
        //Console.WriteLine(num);
        public override void Hello()
        {
            Console.WriteLine("Hello");
        }

        public override void Hi()
        {
            Console.WriteLine("Hi");
        }

        protected override void Hey()
        {
            Console.WriteLine("Hey from ImplementationOfAbstractClass");
            hola();
            
        }

        // Q1. Trying to override protected abstract method

        //public override void Welcome()
        //{

        //}
    }

    public class AnotherImplementationOfAbstractClass : AbstractClass
    {
        public override void Hello()
        {
            Console.WriteLine("Hello There!");    
        }

        public override void Hi()
        {
            Console.WriteLine("Hi There");
        }
        public override void Hey()
        {
            Console.WriteLine("Hey from AnotherImplementationOfAbstractClass");
        }

    }

    // Q 10 - an we have static COnstructors in a class and
    // if yes then how many times they are called and what will be the use of it?
    // yes - It is used to instantiate static data members
    // it will be called only once and before any other method or constructor 
    public class SimpleClass
    {
        static int x;
        static SimpleClass()
        {
            x = 10;
        }
    }

    public abstract class canTheDerivedClassBeAbstract : AbstractClass
    {
        // q4. the derived class can be an abstract class
    }

    public abstract class abstractClassFromNonAbstractClass : ImplementationOfAbstractClass
    {
        // q4. the derived class can be an abstract class
    }

    public abstract class abstractClassFromNonAbstractClass2 : SimpleClass
    {
        // q4. the derived class can be an abstract class
    }

    public class AnotherSimpleClass
    {
        // Q5. Can we have abstract and virtual methods in non-abstract class?

        // Abstract Class cannot be there

        //public abstract void Hi();
       

        // Virtual class can be there
        public virtual void hey()
        {
            Console.WriteLine("Hey in virtual class from Another Simple Class");
        }
    }

    // Can the sealed class be a derived class? - yes
    public class derivedFromAnotherSimpleClass : AnotherSimpleClass
    {

    }

    // q7  sealed class can contain Protected methods but it is inaccessible

    sealed class Sealed : AnotherSimpleClass
    {
        protected void Hello()
        {
            Console.WriteLine("Hello from sealed class");
        }
        // q8 Can we have virtual or abtsract methods in sealed class? - Np

        //public virtual void Hi()
        //{
        //    Console.WriteLine("Virtual ");
        //}

        //public abstract void Yo();
        

        
    }

    // q 11 Can we have static constructor and methods in Abstract class? - yes (doubt)
    public abstract class ThirdAbstract
    {
        static int z = 10;

        static ThirdAbstract()
        {
            z = 12;
        }

        ThirdAbstract()
        {
            Console.WriteLine(z + " In third abstract");
        }
    }

    // q12 Can we have static constructor and methods in sealed class?

     sealed class newSeal
    {
        static int f = 10;

        static newSeal()
        {
            f = 20;
        }

        newSeal()
        {
            Console.WriteLine("From newSeal = " + f);
        }

    }
}
