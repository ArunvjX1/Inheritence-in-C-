using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritence.sky.hope;
namespace Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExtraInformation extra=new ExtraInformation();
            extra.UniversityName = "Leeds Beckett";
            
            subjects sub = new sky.hope.subjects();
            sub.subject = "Cloud Computing";
            sub.UniversityName = "Leeds Beckett";
            sub.display();

            Console.ReadLine();

        }
    }
}
