using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivLoopList_DavidRamirez
{
    public partial class Form1 : Form
    {
        const int Mycurrentyear = 2017;

        public Form1()
        {
            InitializeComponent();
            //Author: David Ramirez
            //Goal is to see all years between two year values and to show if election or census year
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            //declare variables for year typed by the user
            int MyTxtStartYear = 0;
            int MyTxtEndYear = 0;
            int LoopYear = 0; 
            string MyString;
            bool ParseResult;
            //To clear the list box with clear button
            ListBoxOFYears.Items.Clear();

            //Shows the year the user chose
            //Mesage box to show if no date was typed and if start year is greater that end year
            ParseResult = int.TryParse(TxtStartYear.Text,out MyTxtStartYear);
            if (!ParseResult)
                {
                MessageBox.Show("Please enter a start year");
                return;
                }
            ParseResult = int.TryParse(TxtEndYear.Text, out MyTxtEndYear);
            if (!ParseResult)
                {
                MessageBox.Show("Please enter an end year");
                return;
                }
           
            if (MyTxtStartYear >= Mycurrentyear)
            {
                MessageBox.Show("Please enter a year prior to the current year");
                return;
            }
            if (MyTxtEndYear <= MyTxtStartYear)
            {
                MessageBox.Show("Please enter a year after the start year");
                return;
            }

            // calculates the years that an election or cencus occured 
            for (int i = MyTxtStartYear; i <= MyTxtEndYear; i++)
            {
                LoopYear = i;
                MyString = "Year:" + LoopYear;
               // if Election or Census Box is checked show message next to the year
                if (checkBoxElection.Checked == true)
                {

                if (LoopYear % 4 == 0)
                {
                    MyString = MyString + ", Election Year ";
                }
                }
                if (checkBoxCensus.Checked == true)
                {

                    if (LoopYear % 10 == 0)
                    {
                        MyString = MyString + ", Census Year ";
                    }
                }
                //adds items to a list box
                ListBoxOFYears.Items.Add(MyString.ToString());
           






        }


    }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtStartYear.Text = " ";
            TxtEndYear.Text = " ";
            ListBoxOFYears.Items.Clear();
        }

        private void ListBoxOFYears_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
