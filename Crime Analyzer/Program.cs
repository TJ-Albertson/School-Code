using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;

namespace Crime_Analyzer
{
    class Program
    {
        static ArrayList toIntArray(IEnumerable var) {
            ArrayList array = new ArrayList();
            int count = 0;
            foreach(var num in var) {
                array.Add(num);
                count++;
            }
            return array;
        }

        static void Main(string[] args)
        {
            String csv, report;
            csv = args[0].ToString();
            report = args[1].ToString();

            List<CrimeStats> list = new List<CrimeStats>();

            try {   
                 if (File.Exists(csv)) {    
            
                    using(StreamReader file = new StreamReader(csv)) {  

                        var line = file.ReadLine();
                        var values = line.Split(',');

                        while (!file.EndOfStream) {
                            line = file.ReadLine();
                            values = line.Split(',');
                            list.Add(new CrimeStats(Int32.Parse(values[0]), Int32.Parse(values[1]), Int32.Parse(values[2]), Int32.Parse(values[3]), Int32.Parse(values[4]), Int32.Parse(values[5]), Int32.Parse(values[6]), Int32.Parse(values[7]), Int32.Parse(values[8]), Int32.Parse(values[9]), Int32.Parse(values[10])));
                        }  
                        file.Close();
                    }
                 }
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
                Console.WriteLine("CrimeAnalyzer <crime_csv_file_path> <report_file_path>");
            }

            //period: 1994
            var years = from crimeStats in list select crimeStats.year;
            var min = years.Min();
            var max = years.Max();
            var dif = max - min;
            
            //Years murders per year < 15000: 2010, 2011, 2012, 2013
            var murders = from crimeStats in list where crimeStats.murder < 15000 select crimeStats.year;
            ArrayList arrayMurders = toIntArray(murders);

            //Robberies per year > 500000: 1994 = 618949, 1995 = 580509, 1996 = 535594
            var robberiesPerYear = from crimeStats in list where crimeStats.robbery > 500000 select crimeStats.year;
            var robberiesYear = from crimeStats in list where crimeStats.robbery > 500000 select crimeStats.robbery;

            ArrayList rob1 = toIntArray(robberiesPerYear);
            ArrayList rob2 = toIntArray(robberiesYear);



            //Violent crime per capita rate (2010): 0.0040450234834638
            var violentCrime = from crimeStats in list where crimeStats.year == 2010 select crimeStats.violentCrime;
            var violentCrimePop = from crimeStats in list where crimeStats.year == 2010 select crimeStats.population;

            float crime = violentCrime.Max();
            float pop = violentCrimePop.Max();

            float capita = crime / pop;

            //Average murder per year (all years): 16864.25
            var murderYearAll = from crimeStats in list select crimeStats.murder;
            var avgMurder = murderYearAll.Average();

            //Average murder per year (1994–1997): 20696.25
            var murderYear1994 = from crimeStats in list where crimeStats.year >= 1994 && crimeStats.year <= 1997 select crimeStats.murder;
            var avgMurder1994 = murderYear1994.Average();

            //Average murder per year (2010–2014): 14608.75
            var murderYear2010 = from crimeStats in list where crimeStats.year >= 2010 && crimeStats.year <= 2014 select crimeStats.murder;
            var avgMurder2010 = murderYear2010.Average();

            //Minimum thefts per year (1999–2004): 6937089
            var thefts = from crimeStats in list where crimeStats.year >= 1999 && crimeStats.year <= 2004 select crimeStats.theft;
            var minTheft = thefts.Min();
             //Maximum thefts per year (1999–2004): 7092267
            var maxTheft = thefts.Max();

            //Year of highest number of motor vehicle thefts: 1994
            var motor = from crimeStats in list select crimeStats.motorVehicle;
            var motorMax = motor.Max();
            var motor2 = from crimeStats in list where crimeStats.motorVehicle == motorMax select crimeStats.year;
            var motorYear = motor2.Max();


            try {    
                using (StreamWriter outputFile = new StreamWriter(report)) {
                    outputFile.WriteLine("Crime Analyzer Report");
                    outputFile.WriteLine("");
                    outputFile.Write("Period: ");
                    outputFile.WriteLine("{0}-{1} ({2} years)", min, max, dif);
                    outputFile.WriteLine("");

                    outputFile.Write("Years murders per year < 15000: ");
                    foreach(var num in arrayMurders) {
                        outputFile.Write(num + ",");
                    }
                    outputFile.WriteLine("");

                    outputFile.Write("Robberies per year >  500000: ");
                    for(int i = 0; i < rob1.Count; i++) {
                        outputFile.Write(rob1[i] + " = " + rob2[i] + ",");
                    }
                    outputFile.WriteLine("");

                    outputFile.WriteLine("Violent crime per capita rate (2010): {0}", capita);

                    outputFile.WriteLine("Average murder per year (all years): {0}", avgMurder);

                    outputFile.WriteLine("Average murder per year (1994–1997): {0}", avgMurder1994);

                    outputFile.WriteLine("Average murder per year (2010–2014): {0}", avgMurder2010);

                    outputFile.WriteLine("Minimum thefts per year (1999–2004): {0}", minTheft);

                    outputFile.WriteLine("Maximum thefts per year (1999–2004): {0}", maxTheft);

                    outputFile.WriteLine("Year of highest number of motor vehicle thefts: {0}", motorYear);
                }
            } catch (Exception Ex) {    
                Console.WriteLine(Ex.ToString());    
                System.Environment.Exit(0);
            }
        }
    }
}
