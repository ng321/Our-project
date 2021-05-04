using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] countries = new string[17]{
                "Antratica", "Akrotiri", "Algeria", "Albania", "Australia", "Andorra", "Angola", "Anguilla", "Antigue and Barbuda", "Ashmore and Cartier Islands", "Argentina", "Azerbaijan", "Armenia", "American Samoa"
                , "Afghanistan", "Austria", "Aruba"
            };

            
            var query = from country in countries
                         where country.Length > 10
                         orderby country
                         select country;

            foreach(var value in query)
            {
                listBox1.Items.Add(value);
                
            }
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] countries = new string[17]{
                "Antratica", "Akrotiri", "Algeria", "Albania", "Australia", "Andorra", "Angola", "Anguilla", "Antigue and Barbuda", "Ashmore and Cartier Islands", "Argentina", "Azerbaijan", "Armenia", "American Samoa"
                , "Afghanistan", "Austria", "Aruba"
            };


            var query = from country in countries
                        where country.Length < 7
                        orderby country
                        select country;

            foreach (var value in query)
            {
                listBox1.Items.Add(value);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] countries = new string[17]{
                "Antratica", "Akrotiri", "Algeria", "Albania", "Australia", "Andorra", "Angola", "Anguilla", "Antigue and Barbuda", "Ashmore and Cartier Islands", "Argentina", "Azerbaijan", "Armenia", "American Samoa"
                , "Afghanistan", "Austria", "Aruba"
            };


            var query = from country in countries
                        where country.StartsWith("An")
                        orderby country
                        select country;

            foreach (var value in query)
            {
                listBox1.Items.Add(value);

            }
        }

       
    }
}
