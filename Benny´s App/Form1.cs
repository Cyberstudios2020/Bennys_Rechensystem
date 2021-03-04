using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benny_s_App
{
    public partial class Bennys_App : Form
    {
        int prices;
        int result;

        public Bennys_App()
        {
            InitializeComponent();
        }

        private void CmdAddPart_Click(object sender, EventArgs e)
        {
            double salePrice = Convert.ToDouble(TxtListPrice.Text);
            double payPercent = Convert.ToDouble(DudSalePercent.Text);
            double salePercent = salePrice * (payPercent / 100);
            double price = salePrice + salePercent;
            prices = (int)price;

            listFiller(prices);

            checkedListBox1.Items.Add(CbSelectPerformance.Text + " " +
                                          CbSelectDesign.Text + " " +
                                          CbSelectExtras.Text + " " +
                                          (int)price + " $",true);
        }

        private void CmdNewResult_Click(object sender, EventArgs e)
        {
            listRefresher(prices);
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            //hier soll ein Textdoc erstellt werden in dem alle daten gespeichert werden teile kd name datum und summe und kennzeichen
            //Directory.CreateDirectory(@"C:\temp\x_Test\");

            //string text = "A class is the most powerful data type in C#. Like a structure, " +
            //               "a class defines the data and behavior of the data type. ";
            //File.WriteAllText(@"C:\temp\x_Test\WriteText.txt", text);
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maxMustermannToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblWorkerName.Text = maxMustermannToolStripMenuItem.Text;
        }

        private void manfredFernandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblWorkerName.Text = manfredFernandesToolStripMenuItem.Text;
        }

        private void listFiller(int prices)
        {
            List<int> priceList = new List<int>();
            priceList.Add(prices);

            foreach (var item in priceList)
            {
                result = result + item;
                LblPriceResult.Text = "Rechnungssumme: " + result + "$";
            }
        }

        private void listRefresher(int prices)
        {
            List<int> priceList = new List<int>();
            priceList.Add(prices);

            for (int i = 0; i < priceList.Count; i++)
            {
                if (CheckState.Unchecked == 0)
                {
                    result = result - item;
                    LblPriceResult.Text = "Rechnungssumme: " + result + "$";
                }
            }
            //else
            //{
            //    foreach (var item in priceList)
            //    {
            //        result = result + item;
            //        LblPriceResult.Text = "Rechnungssumme: " + result + "$";
            //    }
            //}
        }
    }
}