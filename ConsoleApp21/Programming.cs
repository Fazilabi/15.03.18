using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Programming
    {
        public string Language;
        public List<string> Skills;
        public Environment EnviName;
        public void ShowSkills()
        {
            foreach (var skill in Skills)
            {
                Console.WriteLine(skill);
            }
        }
    }
}
