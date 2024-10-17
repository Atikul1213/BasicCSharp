// See https://aka.ms/new-console-template for more information
using CopyContructor;

Console.WriteLine("Hello, World!");

Employee e1 = new Employee(101, 30, "Atikul", "Khansama Dinajpur", true);

e1.Display();

Employee e2 = new Employee(e1);
e2.Display();


StaticConstructor st = new StaticConstructor();
st.Increment();
st.Display();
st.Increment();
st.Display();

StaticConstructor st2 = new StaticConstructor();
st2.Increment();
st2.Display();
st2.Increment();
st2.Display();


Child cld = new Child("Atikul");


Console.WriteLine("From static class: " + Test.GetSquare(10));


Singleton fromPlace1 = Singleton.GetSingletonInstance();
fromPlace1.SomeMethod("From place 1");

Singleton fromPlace2 = Singleton.GetSingletonInstance();
fromPlace2.SomeMethod("from place 2");