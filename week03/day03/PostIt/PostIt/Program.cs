/*
Post-it
Create a PostIt a struct that has
a BackgroundColor
a Text on it
a TextColor
Create a few example post-it objects:
an orange with blue text: "Idea 1"
a pink with black text: "Awesome"
a yellow with green text: "Superb!"
*/

using System;

namespace PostIt
{
    public struct PostIt
    {
        public string BackgroundColor;
        public string TextColor;
        public string Text;
    }

    class Program
    {
        static void Main(string[] args)
        {
            PostIt orange1;
            PostIt pink1;
            PostIt yellow1;

            orange1.BackgroundColor = "orange";
            orange1.TextColor = "blue";
            orange1.Text = "Idea 1";

            pink1.BackgroundColor = "pink";
            pink1.TextColor = "black";
            pink1.Text = "Awesome";

            yellow1.BackgroundColor = "yellow";
            yellow1.TextColor = "green";
            yellow1.Text = "Superb!";

            Console.WriteLine("Background colour: " + orange1.BackgroundColor + " Text colour: " + orange1.TextColor + " Idea: " + orange1.Text);
            Console.WriteLine("Background colour: " + pink1.BackgroundColor + " Text colour: " + pink1.TextColor + " Idea: " + pink1.Text);
            Console.WriteLine("Background colour: " + yellow1.BackgroundColor + " Text colour: " + yellow1.TextColor + " Idea: " + yellow1.Text);

            Console.ReadLine();
        }
    }
}
