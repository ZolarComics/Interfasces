using System;
namespace Interface
{
    public class Animal
    {
        public Animal()
        {
        }

        public DateTime Birthday
        { get; set; }

        public int Age
        { get { return (int)DateTime.Now.Subtract(Birthday).TotalDays / 365; } }


    }
}
