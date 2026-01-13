using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXE7
{
    public partial class Form1 : Form
    {
        /* private StoreData dataHandler;
         private List<Couples> couplesList = new List<Couples>();

         public Form1()
         {
             InitializeComponent();
             // Initialize the form and load data
             dataHandler = new StoreData();
             UpdateWomenDisplay();
         }


         private void Couple_TextChanged(object sender, EventArgs e)
         {

         }

         private void singleWomen_TextChanged(object sender, EventArgs e)
         {

         }

         private void SingleMen_TextChanged(object sender, EventArgs e)
         {

         }

         private void UpdateWomenDisplay()
         {
             women.Clear(); // Clear previous content
             foreach (var woman in dataHandler.WomenQueue)
             {
                 women.AppendText($"{woman.FirstName} {woman.LastName}\n");
             }
         }
         private void women_TextChanged(object sender, EventArgs e)
         {

         }

         //find couples
         private void find_Click(object sender, EventArgs e)
         {
             while (dataHandler.WomenQueue.Count > 0)
             {
                 Women currentWoman = dataHandler.WomenQueue.Dequeue();

                 // Search for a matching man
                 Men matchedMan = dataHandler.MenList.Find(m => m.LastName == currentWoman.LastName);

                 if (matchedMan != null)
                 {
                     // Found a match
                     couplesList.Add(new Couples(
                         $"{currentWoman.FirstName} And {matchedMan.FirstName} {matchedMan.LastName}" +
                         "-" + $"{currentWoman.City}"
                     ));

                     // Remove matched individuals
                     menList.Remove(matchedMan);

                     MessageBox.Show($"Match found: {selectedWoman.FirstName} {selectedWoman.LastName}");
                 }
                 else
                 {
                     // No match found
                     MessageBox.Show($"No match found for {selectedWoman.FirstName} {selectedWoman.LastName}");

                     // Add to singleWomen
                     singleWomen.AppendText($"{selectedWoman.FirstName} {selectedWoman.LastName}, Kids: {selectedWoman.Kids}\n");
                 }
             }

             while (dataHandler.WomenQueue.Count > 0)
             {
                 Women currentWoman = dataHandler.WomenQueue.Dequeue();

                 Men matchedMan = dataHandler.MenList.Find(m => m.LastName == currentWoman.LastName);

                 if (matchedMan != null)
                 {
                     // Add as couple
                     couplesList.Add(new Couples(
                         $"{matchedMan.FirstName} {matchedMan.LastName}",
                         $"{currentWoman.FirstName} {currentWoman.LastName}"
                     ));

                     dataHandler.MenList.Remove(matchedMan);
                     MessageBox.Show($"Match found: {currentWoman.FirstName} {currentWoman.LastName}");
                 }
                 else
                 {
                     // No match
                     MessageBox.Show($"No match found for {currentWoman.FirstName} {currentWoman.LastName}");
                     singleWomenBox.AppendText($"{currentWoman.FirstName} {currentWoman.LastName}, Kids: {currentWoman.Kids}\n");
                 }
             }
       
        */
     
            private StoreData dataHandler;
            private List<Couples> couplesList = new List<Couples>();

            public Form1()
            {
                InitializeComponent();

                dataHandler = new StoreData();
                UpdateWomenDisplay();
            }

        private void UpdateWomenDisplay()
        {
            women.Clear(); // Clear previous content
            foreach (var woman in dataHandler.WomenQueue)
            {
                women.AppendText($"{woman.FirstName} {woman.LastName}\n");
            }
        } 

        // Update RichTextBoxes
        private void UpdateCouplesDisplay()
            {
                Couple.Clear();
                foreach (var couple in couplesList)
                {
                Couple.AppendText(couple.ToString() + "\n");
                }
            }

            private void UpdateSingleWomenDisplay()
            {
                singleWomen.Clear();
                foreach (var woman in dataHandler.WomenQueue)
                {
                    singleWomen.AppendText($"{woman.FirstName}-{woman.LastName}-{woman.City}->{woman.Kids}\n");
                }
            }

            private void UpdateSingleMenDisplay()
            {
                SingleMen.Clear();
                foreach (var man in dataHandler.MenList)
                {
                SingleMen.AppendText($"{man.FirstName}-{man.LastName}-{man.City}->{man.Distance}\n");
                }
            }

        // Find match button
        private void find_Click(object sender, EventArgs e)
        {
            if (dataHandler.WomenQueue.Count == 0)
            {
                MessageBox.Show("No more women to match.");
                return;
            }
            // Take only ONE woman from the queue
            var currentWoman = dataHandler.WomenQueue.Dequeue();
            // Try to find a match
            var matchedMan = dataHandler.MenList.Find(m => m.LastName == currentWoman.LastName);

            if (matchedMan != null)
            {
                couplesList.Add(new Couples(
                    $"{matchedMan.FirstName} {matchedMan.LastName}",
                    $"{currentWoman.FirstName} {currentWoman.LastName}"
                ));

                // Remove the matched man
                dataHandler.MenList.Remove(matchedMan);

                // Show couple in RichTextBox
                Couple.AppendText($"{currentWoman.FirstName} And {matchedMan.FirstName} {currentWoman.LastName} - {currentWoman.City}\n");
            }
            else // No match found
            {
                MessageBox.Show($"No match found for {currentWoman.FirstName} {currentWoman.LastName}");
                singleWomen.AppendText($"{currentWoman.FirstName} {currentWoman.LastName} ( {currentWoman.Kids} )\n");
            }


            // Sort by last name
            couplesList.Sort((a, b) => a.ManName.Split(' ')[1].CompareTo(b.ManName.Split(' ')[1]));

            UpdateCouplesDisplay();
            UpdateSingleMenDisplay();
        } 
   

            // Save button
         /*   private void btnSave_Click(object sender, EventArgs e)
            {
                if (radioButtonSingleMen.Checked)
                {
                    SaveToFile("single_men.txt", dataHandler.MenList);
                }
                else if (radioButtonSingleWomen.Checked)
                {
                    SaveToFile("single_women.txt", dataHandler.WomenQueue);
                }
                else if (radioButtonCouples.Checked)
                {
                    SaveToFile("couples.txt", couplesList);
                }
                else
                {
                    MessageBox.Show("Please select an option to save.");
                    return;
                }

                MessageBox.Show("Data saved successfully!");
            }*/

            // Generic save method
            private void SaveToFile(string filePath, object data)
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    if (data is List<Men> menList)
                    {
                        foreach (var man in menList)
                        {
                            writer.WriteLine($"{man.FirstName}-{man.LastName}-{man.City}->{man.Distance}");
                        }
                    }
                    else if (data is Queue<Women> womenQueue)
                    {
                        foreach (var woman in womenQueue)
                        {
                            writer.WriteLine($"{woman.FirstName}-{woman.LastName}-{woman.City}->{woman.Kids}");
                        }
                    }
                    else if (data is List<Couples> couplesList)
                    {
                        foreach (var couple in couplesList)
                        {
                            writer.WriteLine(couple.ToString());
                        }
                    }
                }
            }
    }
}

