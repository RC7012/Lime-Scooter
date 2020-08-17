using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test1
{
    public partial class Form1 : Form
    {
        //Name: Reginald Chen
        //IDNo: 1542096
        
        //create a list to store the Scooter objects
        List<Scooter> scooterList = new List<Scooter>();

        //constants for the two scooter types
        const string G3 = "G3";
        const string G25 = "G2.5";
        
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Allow user to load a csv file and display the file information in a listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxScooters.Items.Clear();
            StreamReader inputFile;
            //create a string variable and a string array to store the readline information 
            string line = "";
            string[] scooterInfo;

            openFileDialog1.Filter = "CSV File|*.csv|All files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //if the user has selected a csv file and clicked on OK
                //open the file and read till the last line
                inputFile = File.OpenText(openFileDialog1.FileName);
                while (!inputFile.EndOfStream)
                {
                    try
                    {
                        line = inputFile.ReadLine();

                        //seperates the comma seperated line
                        scooterInfo = line.Split(',');

                        //check if the line is missing elements
                        if (scooterInfo.Length == 3)
                        {
                            string suburb = scooterInfo[0];
                            string type = scooterInfo[1];
                            int battery = int.Parse(scooterInfo[2]);

                            //create a scooter object using the information in the line
                            Scooter s = new Scooter(suburb, type, battery);
                            //add the scooter object to the list
                            scooterList.Add(s);
                        }
                        else
                        {
                            Console.WriteLine("ERROR : " + line);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("ERROR : " + line);
                    }
                }
                inputFile.Close();

                //for every scooter object in scooter list
                //displays the scooter information in the listbox using the pre-written tostring method
                foreach (Scooter s in scooterList)
                {
                    listBoxScooters.Items.Add(s.ToString());
                }
            }
        }

        /// <summary>
        /// displays the total amount of money to charge scooters on a single day
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void totalPayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal pay = 0;
            if (scooterList.Count != 0)
            {
                foreach (Scooter s in scooterList)
                {
                    pay += s.Pay;
                }
                MessageBox.Show(pay.ToString("c"));
            }
            else
            {
                MessageBox.Show("Please load your file first");
            }
           
        }

        /// <summary>
        /// Filter the scooters by suburb and display the result in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFindScooters_Click(object sender, EventArgs e)
        {
            listBoxSuburbs.Items.Clear();
            Select_scooters_by_suburb();
            
        }

        /// <summary>
        /// display the scooters in a particular suburb in the listbox
        /// </summary>
        private void Select_scooters_by_suburb()
        {
            if (scooterList.Count != 0 && comboBox1.SelectedItem != null)
            {
                foreach (Scooter s in scooterList)
                {
                    if (s.Suburb == comboBox1.SelectedItem.ToString())
                    {
                        listBoxSuburbs.Items.Add(s.ToString());
                    }

                }
            }
            else
            {
                MessageBox.Show("Please load your file and select a suburb first");
            }
        }

        /// <summary>
        /// display the suburb cost
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (scooterList.Count != 0 && comboBox1.SelectedItem != null)
            {
                decimal pay = pay_scooters_by_suburb(comboBox1.SelectedItem.ToString());
                MessageBox.Show("Amount to charge in " + comboBox1.SelectedItem.ToString() + " is : " + pay.ToString("c"));
            }
            else
            {
                MessageBox.Show("Please load your file and select a suburb first");
            }

        }

        /// <summary>
        /// returns the total cost by suburb
        /// </summary>
        /// <param name="suburb"></param>
        /// <returns></returns>
        private decimal pay_scooters_by_suburb(string suburb)
        {
            decimal pay = 0;

            foreach (Scooter s in scooterList)
            {
                if (s.Suburb == suburb)
                {
                    pay += s.Pay;
                }
            }
            return pay;
        }

        /// <summary>
        /// display which suburb pays the most and the amount to pay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string suburb = "";
            decimal largestPay = 0;
            List<string> suburbList = new List<string>();

            if (scooterList.Count != 0)
            {
                //get every surburb in the list
                foreach (Scooter s in scooterList)
                {
                    if (suburbList.Contains(s.Suburb) == false)
                    {
                        suburbList.Add(s.Suburb);
                    }
                }
                //find the pay-most suburb
                foreach (string s in suburbList)
                {
                    if (largestPay < pay_scooters_by_suburb(s))
                    {
                        largestPay = pay_scooters_by_suburb(s);
                        suburb = s;
                    }
                }
                MessageBox.Show("Suburb " + suburb + " pays the most of " + largestPay.ToString("c"));
            }
            else
            {
                MessageBox.Show("Please load your file first");
            }
        }
    }
}
