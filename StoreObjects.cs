using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE7
{
    class StoreData
    {
        // Properties to store the lists
        public List<Men> MenList { get; set; }
        public Queue<Women> WomenQueue { get; set; }

        // Constructor: Load both men and women data when the object is created
        public StoreData()
        {
            // Initialize lists
            MenList = new List<Men>();
            WomenQueue = new Queue<Women>();

            // Load men from file
            using (StreamReader menReader = new StreamReader("men.txt"))
            {
                while (!menReader.EndOfStream)
                {
                    string line = menReader.ReadLine();

                    string[] parts = line.Split(new string[] { "->" }, StringSplitOptions.None);
                    string personInfo = parts[0];
                    int distance = int.Parse(parts[1]);

                    string[] informations = personInfo.Split('-');
                    string firstName = informations[0];
                    string lastName = informations[1];
                    string city = informations[2];

                    Men person = new Men(firstName, lastName, city, distance);
                    MenList.Add(person);
                }
            }

            // Load women from file
            using (StreamReader womenReader = new StreamReader("women.txt"))
            {
                while (!womenReader.EndOfStream)
                {
                    string line = womenReader.ReadLine();

                    string[] parts = line.Split(new string[] { "->" }, StringSplitOptions.None);
                    string personInfo = parts[0];
                    int numberOfKids = int.Parse(parts[1]);

                    string[] informations = personInfo.Split('-');
                    string firstName = informations[0];
                    string lastName = informations[1];
                    string city = informations[2];

                    Women person = new Women(firstName, lastName, city, numberOfKids);
                    WomenQueue.Enqueue(person); 
                }
            }
        }
    }
}

