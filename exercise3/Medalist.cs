﻿using System.IO;

namespace COMP212_Lab1.exercise3
{
    // Implements 
    public static class Extensions
    {
        public static T[] SubArray<T>(this T[] array, int offset, int length)
        {
            T[] result = new T[length];
            Array.Copy(array, offset, result, 0, length);
            return result;
        }
    }
    //Implement a C# application to load the data from Medals.csv, choose appropriate data structure to organize the data. After the data has been loaded, your app should be able to
    //1. Add new medalist information to the data structure
    //2. Delete a specific data from the data structure
    //3. Implement a generic Search method that implements the linear-search algorithm.Search method should compare the search key with each element in the data source until all elements has been processed.The output of this method can be IEnumerable<T>
    //Then use the medalist to test your Search method
    class Program
    {
        static void Main(string[] args)
        {
            const int OFFSET = 2;
            const int LENGTH = 3;


            Dictionary<int, Medalist[]> medalists = new Dictionary<int, Medalist[]>();

            string filePath = System.IO.Path.GetFullPath("Medals.csv");
            Console.WriteLine(filePath);

            // Read data from file 
            using (var reader = new StreamReader(@"!!ADD THE FULL PATH TO YOUR MEDALS.CSV"))
            {
                reader.ReadLine(); //Skips first line

                while (!reader.EndOfStream) // Until it reaches the end
                {
                    var values = reader.ReadLine().Split(','); // Array of strings that contains values of each line

                    //#region Medalist
                    //foreach (string i in values){
                    //    Console.WriteLine(i);
                    //}
                    //Console.WriteLine();
                    //#endregion

                    int[] medals = Array.ConvertAll(values.SubArray(OFFSET, LENGTH), int.Parse); // We store the number of medals as an array of integer
                    int year = Int32.Parse(values[1]); // We store the year as an integer

                    Medalist newMedalist = new Medalist { fullName = values[0], medals = medals };

                    AddMedalist(medalists, year, newMedalist);

                }
                #region TEST
                Console.WriteLine("=======TEST========");
                //1. Add new medalist information to the data structure
                Console.WriteLine("=======Add new medalist========");

                Medalist testMedalist = new Medalist { fullName = "Test", medals = new int[] { 1, 2, 3 } };

                AddMedalist(medalists, 2008, testMedalist);

                foreach (Medalist medalist in medalists[2008])
                {
                    Console.WriteLine(medalist.fullName); // This will print the list of all medalists in 2008, including the testMedalist
                }

                //2. Delete a specific data from the data structure
                Console.WriteLine("=======Deleting specific medalist========");

                DeleteMedalist(medalists, 2008, testMedalist);

                foreach (Medalist medalist in medalists[2008])
                {
                    Console.WriteLine(medalist.fullName); // This will print the list of all medalists in 2008, excluding the testMedalist
                }

                //3. Implement a generic Search method that implements the linear-search algorithm.
                //Search method should compare the search key with each element in the data source until all elements has been processed.
                //The output of this method can be IEnumerable<T>
                #endregion


                Console.WriteLine(medalists.Count);
            }
        }

        //1. Add new medalist information to the data structure
        public static void AddMedalist(Dictionary<int, Medalist[]> medalists, int key, Medalist newMedalist)
        {
            try
            {
                medalists.Add(key, new Medalist[] { newMedalist });
            }
            catch (ArgumentException)
            {
                medalists[key] = medalists[key].Append(newMedalist).ToArray(); // If the year already exists, we add the new medalist to the array
            }
        }

        //2. Delete a specific data from the data structure
        public static void DeleteMedalist(Dictionary<int, Medalist[]> medalists, int key, Medalist newMedalist)
        {
            // We filter the array of Medalists by removing the one that matches the medalist that we are passing
            medalists[key] = medalists[key].Where(val => val != newMedalist).ToArray();
        }

        //3. Implement a generic Search method that implements the linear-search algorithm.Search method should compare the search key with each element in the data source until all elements has been processed.The output of this method can be IEnumerable<T>
        //public static IEnumerable<T> Search<T>()
        //{
            
        //}
    }


    // Create a Medalist class to store all data from the csv file
    internal class Medalist
    {
        public string fullName { get; set; }
        //private int year { get; set; } //! We use year as a key for the dictionary
        public int[] medals { get; set; } = new int[3]; //! Stores the 3 counts of medals [ Gold, Silver, Bronze]


    }
}
