using System;
using System.Collections.Generic;

namespace GradeConverter
{
    class Program
    {

        static string getName() {
            //gets the user's first and last name. Returns the first and last name
            string name = Console.ReadLine();
            return name;
        }

        static int getNumberOfGrades() {
            //gets the number of grades the user wants to enter. Returns the number of grades to enter
            Console.WriteLine("\nEnter the number of grades you need to convert");
            int numberOfGrades = Convert.ToInt32(readFloatInput());
            return numberOfGrades;
        }

        static List<float> populateGradesList(int listLength) {
            //adds the grades the user enters to a list. Returns the list of grades
            var gradeList = new List<float>(listLength);
            float totalSum = 0.0f;

            for (int i = 0; i < listLength; i++) {
                Console.WriteLine("Enter a Grade:");
                float temp = readFloatInput();
                gradeList.Add(temp);
                totalSum += temp;
            }

            return gradeList;
        }

        static void printGradeReport(List<float> list) {
            //prints the letter grades and the numerical scores for the grades stored in the grades list e.g. (A score of  89.5 is a B grade)
            foreach (float num in list) {
                string temp = numberToLetter(num);
                Console.WriteLine("A score of {0} is {1}", num, temp);
            }
        }

        static void printGradeStatistics(float numberOfGrades, float average, float max, float min) {
            //prints the statistics for the grades list. (number of grades, average grade, maximum grade, minimum grade)
            Console.WriteLine("\nGrade Statistics\n---------------------------------");
            Console.WriteLine("Number of grades: " + numberOfGrades);
            Console.WriteLine("Max Grade: " + max);
            Console.WriteLine("Min Grade: " + min);
            Console.WriteLine("Average grade: " + average + ", which is " + numberToLetter(average));
        }

        static float getAverageGrade(List<float> list) {
            //calculates and returns the average grade
            float sum = 0; 
            float count = 0;
            foreach (float num in list) {
                sum += num;
                count++;
            }
            float average = sum/count;
            return average;
        }

        static float getMaximumGrade(List<float> list, int numberOfGrades) {
            //returns the highest grade in the list of grades
            float max = list[0];
            for (int i = 1; i < numberOfGrades; i++) {
                float next = list[i];
                if(next > max) {
                    max = next;
                }
            }
            return max;
        }

        static float getMinimumGrade(List<float> list, int numberOfGrades) {
            //returns the lowest grade in the list of grades
            float min = list[0];
            for (int i = 1; i < numberOfGrades; i++) {
                float next = list[i];
                if(next < min) {
                    min = next;
                }
            }
            return min;
        }

        static float readFloatInput() {
            while (true) {
                float number;
                string value = Console.ReadLine();
                if (Single.TryParse(value, out number)) {
                    return number;
                } else {
                    Console.WriteLine("Please enter a number");
                    continue;
                }
            }
        }

        static string numberToLetter(float num) {
                if (num >= 90) {
                    return "an A.";
                } else if (num >= 80) {
                    return "a B.";
                } else if (num >= 70) {
                    return "a C.";
                } else if (num >= 60) {
                    return "a D.";
                } else {
                    return "an F.";
                }
        }

        static void gradeConverter() {

            Console.WriteLine("Enter Name:");
            string name = getName();
            Console.WriteLine("hello, " + name);

            int numOfGrades = getNumberOfGrades();

            List<float> list = populateGradesList(numOfGrades);

            float average = getAverageGrade(list);
            float max = getMaximumGrade(list, numOfGrades);
            float min = getMinimumGrade(list, numOfGrades);

            printGradeReport(list);
            printGradeStatistics(numOfGrades, average, max, min);

        }

        static void Main(string[] args)
        {


            bool flag = true;

            while(flag) {
                gradeConverter();
                Console.WriteLine("\nDo you have more grades to convert? [Y/N]:");

                while(true) {
                    string input = Console.ReadLine();
                    char charVal;
                    bool success = Char.TryParse(input, out charVal);
                    if(success) {
                        if (charVal == 'Y' || charVal == 'y') {
                            break;
                        } else if (charVal == 'N' || charVal == 'n') {
                            Console.WriteLine("\n");
                            flag = false;
                            break;
                        }
                    } else {
                        Console.WriteLine("Please Enter Y or N");
                    }
                }
            }
        }
    }
}
