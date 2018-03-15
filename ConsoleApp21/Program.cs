using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            //var RubyD = new WebProgramming();
            //RubyD.Language = "Ruby";
            //RubyD.Skills = new List<string> { "hard working", "how to use Google", "how to sit for a long time" };
            //RubyD.EnviName = new Environment("windows ", "visual studio 2017");
            ////Console.WriteLine(RubyD.EnviName.IDE);
            //Console.WriteLine(RubyD.UsedTechnology(15));
            var obj = new FrontEndProgramming();
            obj.Language = "html";
            obj.Skills = new List<string>() { "design ability", "inspriration" };
            obj.Webserver = "azure";
            obj.EnviName = new Environment("windows","ide");
            


        }
    }
}
