using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        //Create Reception Event
        Reception r1 = new Reception("Bride and Groom's Wedding Reception", "A celebration of the union of two people.", "May 15, 2023", "10:00 am", "123 Easy St", "Reception", "together4ever@aol.com");
        {
            WriteLine(r1.GetStandard());
            WriteLine($"{r1.GetFull()}{r1.GetFullDeets()}\n");
            WriteLine(r1.GetShort());
        }

        //Create Lecture Event
        Lecture l1 = new Lecture("Mr Boddy", 8, "Discourse of Ethics", "An event held in Mr Boddy's mansion, in which he will give a lecture on morality and ethics.", "June 30, 2023", "8:00 pm", "160 South San Rafael Avenue", "Lecture");
        {
            WriteLine(l1.GetStandard());
            WriteLine($"{l1.GetFull()}{l1.GetFullDeets()}\n");
            WriteLine(l1.GetShort());
        }

        //Create Outdoor Gathering
        Outdoor o1 = new Outdoor("Lawn Care Gala", "A Gala celebrating local landscaping businesses.", "July 8, 2023", "12:30 am", "123 Easy St", "Outdoor Gathering", "Sunny");
        {
            WriteLine(o1.GetStandard());
            WriteLine($"{o1.GetFull()}{o1.GetFullDeets()}\n");
            WriteLine(o1.GetShort());            
        }
    }
}