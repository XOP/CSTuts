using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using C_Basic.Text;

using PassGen;

namespace C_Basic
{
    class MainClass
    {

        static void PrintArray(Array array) 
        {
            foreach (var i in array)
            {
                Console.Write(i + " | ");
            }
            Console.WriteLine();
        }        

        static void PrintList(List<int> list) 
        {
            foreach (var i in list)
            {
                Console.Write(i + " | ");
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            #region part1
            /*

            var teslaCar = new Car
            {
                Model = "Tesla",
                Gear = "Manual",
                Speed = 120,
                SpeedBoost = 20
            };

            teslaCar.PrintModel();
            teslaCar.PrintTotalSpeed();
            teslaCar.PrintGear();

            // auto generated
            teslaCar.PrintYear();

            // dependencies
            var arrays = new ArrayClass();
            arrays.Init();

            var strings = new StringClass();
            strings.Init();

            var enums = new EnumsClass();
            enums.Init();

            // user input
            Console.WriteLine("We need your credentials now:");

            while (true)
            {
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Robot voice: This is not your name, " + input);

                    continue;
                }

                break;
            }

            */
            #endregion

            #region Pass Generator

            // =================================================================

            /*
            var myNextPass = new PassGenerator
            {
                Min = 10,
                Max = 10,
                HasCaps = true,
                HasNumber = true,
                HasSpecials = true
            };

            Console.WriteLine("Print something to exit");
            Console.WriteLine("Press ENTER for new password");

            while (true) {
                var newPass = myNextPass.Generate();
                Console.WriteLine("Here is your new passsword: " + newPass);

                if (!String.IsNullOrWhiteSpace(Console.ReadLine())) break;
            }
            */

            // =================================================================

            #endregion

            #region arrays

            // =================================================================

            /* Array */

            /*

            var numbers = new[] { 4, 16, 192, 128, 8, 32, 2, 256, 64 };

            Console.WriteLine("\nInitial Array");
            PrintArray(numbers);
            
            // sorting
            Array.Sort(numbers);
            Console.WriteLine("\nSorted Array");
            PrintArray(numbers);

            // reverse
            Array.Reverse(numbers);
            Console.WriteLine("\nReverse Array");
            PrintArray(numbers);

            // clear
            var indexOf32 = Array.IndexOf(numbers, 32);
            var arrayLength = numbers.Length;

            Array.Clear(numbers, indexOf32, arrayLength - indexOf32);
            Console.WriteLine("\nCleared 32 Array");
            PrintArray(numbers);

            // copy
            var bigNumbers = new int[indexOf32];

            Array.Copy(numbers, bigNumbers, indexOf32);
            Console.WriteLine("\nCopy of Array");
            PrintArray(bigNumbers);

            */

            // =================================================================

            /* List */

            /*

            var list = new List<int>();

            list.Add(128);
            list.AddRange(new int[]{ 32, 16, 192, 256, 4, 8, 2, 128 });

            PrintList(list);

            // indexes of 128
            Console.WriteLine("Index of 128: " + list.IndexOf(128));
            Console.WriteLine("Last Index of 128: " + list.LastIndexOf(128));

            // get rid of 128
            // Remove in foreach throws exception
            //foreach (var i in list)
            //{
            //    if (i == 128) {
            //        list.Remove(i);
            //    }
            //}

            for (var i = 0; i < list.Count; i++) {
                var item = list[i];

                if (item == 128) 
                    list.Remove(item);
            }

            Console.WriteLine("\nList without 128");
            PrintList(list);

            */

            // =================================================================

            #endregion

            #region dates

            // =================================================================

            /*
            
            var date = new DateTime(2017, 12, 31);

            var dateNow = DateTime.Now;
            var dateUTCNow = DateTime.UtcNow;
            var dateToday = DateTime.Today;

            var tomorrow = dateNow.AddDays(1);
            var yesterday = dateNow.AddDays(-1);

            Console.WriteLine(dateNow.ToLongDateString());
            Console.WriteLine(String.Format("Today is {0}.{1}, time is {2}:{3}", dateNow.Day, dateNow.Month, dateNow.Hour, dateNow.Minute));
            Console.WriteLine(String.Format("Tomorrow is {0}.{1}", tomorrow.Day, tomorrow.Month));

            var nowDayString = dateNow.ToString("dd");
            var nowMonthString = dateNow.ToString("MMMMM");

            Console.WriteLine(String.Format("Today is {0} of {1}", nowDayString, nowMonthString));

            // time span 1
            var timespan1 = new TimeSpan(1, 2, 3);

            // time span 2
            var timespan2 = TimeSpan.FromHours(1);

            // time span 3
            var timespan3 = DateTime.Now.AddMinutes(85.5) - DateTime.Now;

            Console.WriteLine();
            Console.WriteLine("timespan " + timespan3);
            Console.WriteLine("hours " + timespan3.Hours);
            Console.WriteLine("mins " + timespan3.Minutes);
            Console.WriteLine("total mins " + timespan3.TotalMinutes);

            // add time
            var timespanPlus = timespan3.Add(TimeSpan.FromMinutes(12));

            Console.WriteLine("added 12 minutes " + timespanPlus);

            // parse
            var timespanParse = TimeSpan.Parse("01:25:00");

            Console.WriteLine("parsed timespan "+ timespanParse);

            */

            // =================================================================

            #endregion

            #region strings
            /*

            // =================================================================

            var fullName = "Brian Griffin";
            var nameParts = fullName.Split(' ');

            Array.Reverse(nameParts);

            Console.WriteLine();
            Console.WriteLine(nameParts[0] + "/" + nameParts[1]);

            fullName = fullName.Replace("iffi", "obbo");
            Console.WriteLine(fullName);

            var year = "1985";
            var yearNum = Convert.ToInt32(year);
            Console.WriteLine(yearNum);

            var price = 29.99f;
            var priceStr = price.ToString("##");
            Console.WriteLine(priceStr);

            // =================================================================

            var longText = "Andouille filet mignon tri-tip landjaeger, swine turkey jerky beef sirloin biltong doner bresaola shank. Bacon kielbasa boudin ham hock. T-bone flank frankfurter kevin ham shankle alcatra short ribs tri-tip fatback bacon turkey drumstick. Filet mignon cow short loin, corned beef kielbasa jerky brisket.";
            var finalText = StringUtils.LimitString(longText, 128);

            Console.WriteLine(finalText);

            // =================================================================

            var sbuilder = new StringBuilder();

            sbuilder
                .Append('#', 20)
                .AppendLine()
                .Append("Wow, such code!")
                .AppendLine()
                .Append('=', 20);

            Console.WriteLine(sbuilder);

            // =================================================================

            */
            #endregion

            #region files

            // =================================================================

            // FILE

            //File.Copy("from", "to");
            //File.Delete("path\\file.png");
            //if (File.Exists("some-other-path.png"))
            //{
            //    // ...
            //}

            var candyPath = @"/Users/evgeny.khoroshilov/Documents/candy.svg";
            var candySvg = File.ReadAllText(candyPath);

            Console.WriteLine(candySvg);

            Console.WriteLine("==================================");


            // FILEINFO

            var fileInfo = new FileInfo(@"/Users/evgeny.khoroshilov/Documents/candy.svg");

            Console.WriteLine(fileInfo.Extension);
            Console.WriteLine(fileInfo.Directory);
            Console.WriteLine(fileInfo.Name);


            // DIRECTORY

            var docsPath = @"/Users/evgeny.khoroshilov/Documents";

            // prints files from the top level
            var documents = Directory.GetFiles(docsPath, "*.jpg");

            foreach (var d in documents)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("==================================");
            Console.WriteLine("==================================");

            // prints directories
            var documentDirs = Directory.GetDirectories(docsPath);

            foreach (var d in documentDirs)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("==================================");


            // DIRECTORYINFO

            var directoryInfo = new DirectoryInfo(docsPath);

            Console.WriteLine(directoryInfo.FullName);
            Console.WriteLine(directoryInfo.Name);
            Console.WriteLine(directoryInfo.Attributes);

            Console.WriteLine("==================================");
            Console.WriteLine("==================================");


            // PATH

            var fileExt = Path.GetExtension(candyPath);

            Console.WriteLine("Extension: " + fileExt);

            // =================================================================

            #endregion
        }
    }
}
