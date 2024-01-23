namespace GA_ThisKeyword_Hafsa
{
    //hafsa mohamed
    //01/19/24


    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Alice", 25);
            person1.Display(); //outputs: Name: Alice, Age: 25

            Person person2 = new Person("Bob");
            person2.Display(); //outputs Name: Bob, AGe: 0
            person2.SetAge(30);
            person2.Display(); //output name:bob age:30
            
        }//main


    }//class


}//namespace