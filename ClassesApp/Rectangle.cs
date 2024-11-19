using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{

    //Computed Proprities and no constructor
    internal class Rectangle
    {
        // In C#, const and readonly are two keyword used to define non.modifiable fields, but they differ
        // in terms of when they are initailized and their usage contexts
        // Understading the differences between these two can help in deciding which one to used
        // based on specific requirements

        //declaration of the field
        public const int NumberOfCorners = 4;
        //declaration of the field
        public readonly string Color;

        //Readonly field. A unique identifier for each rectangle instance
        private readonly string _id;

        public Rectangle(string color)
        {
            Color = color;
        }

        //Method to display details of the rectangle
        public void DisplayDetails()
        {
            Console.WriteLine($"Color : {Color}, Width: {Width}, Height: {Height}, Area: {Area}," +
                $" Number of Corners: {NumberOfCorners}");
        }


        public double Width { get; set; }

        public double Height { get; set; }

        //Computed property

        // Read Only Prop
        public double Area
        {
            get { return Width * Height; }
        }

    }
}
