using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulse8Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var userPrompt = "Want to see member info? (Press Y to continue, any other key to exit)";

            Console.WriteLine(userPrompt);
            var promptValue = Console.ReadLine();

            do
            {
                Console.WriteLine("Enter Member ID: ");
                var memberIdInput = Console.ReadLine();

                if(int.TryParse(memberIdInput, out int memberId))
                {
                    var provider = new PulseDataProvider();

                    var pulseData = provider.GetPulseData(memberId);

                    foreach(var record in pulseData)
                    {
                        Console.WriteLine(record.ToString());
                    }
                }

                Console.WriteLine(userPrompt);

                promptValue = Console.ReadLine();

            } while (promptValue.ToUpper() == "Y");
        }
    }
}
