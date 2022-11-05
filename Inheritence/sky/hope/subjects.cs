using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence.sky.hope
{
 class subjects : ExtraInformation
    {
        public string subject;
        public string topics;
        public void display() 
        {
            Console.WriteLine("Subject: {0}  And The University {1}",subject,UniversityName);
            Console.ReadLine();
        }
    }
}
