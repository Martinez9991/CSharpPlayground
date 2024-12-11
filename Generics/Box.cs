using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //internal class Box<T>
    //{
    //    private T content;
    //    //public T Content { get; set; }

    //    //public Box(T intialValue)
    //    //{
    //    //    content = intialValue;
    //    //}

    //    public void UpdateContent(T newContent)
    //    {
    //        content = newContent;
    //        Console.WriteLine($"Updated content to {content}");
    //    }

    //    public T GetContent()
    //    {
    //        return content;
    //    }

    //    //public string Log()
    //    //{
    //    //    return $"Box contain {Content}";
    //    //}
    //}

    //internal class Box<TFirst, TSecond>
    //{
    //    public TFirst First { get; set; }

    //    public TSecond Second { get; set; }

    //    public Box(TFirst first, TSecond second)
    //    {
    //        First = first;
    //        Second = second;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine($"First: {First} Second: {Second}");
    //    }
    //}

    //Constrait a Generic Class
    internal class Box<T> where T : class
    {
        
    }

}
