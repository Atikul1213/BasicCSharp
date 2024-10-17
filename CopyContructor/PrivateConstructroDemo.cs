namespace CopyContructor
{
    public class Parent
    {
        private Parent()
        {
            Console.WriteLine("Parent class private constructor called");
        }

        public Parent(string msg)
        {
            Console.WriteLine("Parent class public constructor is called");
        }

    }

    public class Child : Parent
    {

        public Child(string msg1) : base(msg1)
        {
            Console.WriteLine("Child class public constructor is called");
        }
    }
}
