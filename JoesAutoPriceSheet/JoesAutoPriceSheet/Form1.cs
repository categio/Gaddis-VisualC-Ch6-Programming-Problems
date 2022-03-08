using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoesAutoPriceSheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //variables to hold values
            decimal oilChange = 0m, lubeJob = 0m, radiFlush = 0m, tranFlush = 0m,
                inspection = 0m, muffRepair = 0m, tireRotate = 0m;

            //set vals if boxes are checked
            if (oilChgeChkBox.Checked == true)
            {
                oilChange = 26.00m;
            }
            if (lubeChkBox.Checked == true)
            {
                lubeJob = 18.00m;
            }
            if (radFlushChkBox.Checked == true)
            {
                radiFlush = 30.00m;
            }
            if (tranFlushChkBox.Checked == true)
            {
                tranFlush = 80.00m;
            }
            if (inspectChkBox.Checked == true)
            {
                inspection = 15.00m;
            }
            if (mufflerChkBox.Checked == true)
            {
                muffRepair = 100.00m;
            }
            if (tireRotChkBox.Checked == true)
            {
                tireRotate = 30.00m;
            }

            //checks value of input for parts and labor text boxes 
            decimal partsCost = 0m, laborCost = 0m;
            if (decimal.TryParse(partsTextBox.Text, out partsCost))
            {
                if (decimal.TryParse(laborTextBox.Text, out laborCost))
                {
                    //if value is a decimal, get value and convert
                    partsCost = decimal.Parse(partsTextBox.Text);

                    //if value is a decimal, get value and convert
                    laborCost = decimal.Parse(laborTextBox.Text);

                    //get value from methods
                    decimal totOilLube = OilLubeCharges(oilChange, lubeJob);

                    decimal totFlushes = FlushCharges(radiFlush, tranFlush);

                    decimal totMisc = MiscCharges(inspection, muffRepair, tireRotate);

                    decimal totOther = OtherCharges(partsCost, laborCost);

                    decimal totSvcs = totOilLube + totFlushes + totMisc;

                    decimal tax = TaxCharges(partsCost);

                    decimal totalFees = TotalCharges(totOilLube, totFlushes, totMisc, totOther, tax);

                    //print to text boxes
                    totServAndLabOutputLabel.Text = totSvcs.ToString("c");
                    totPartsOutputLabel.Text = totOther.ToString("c");
                    totTaxOutputLabel.Text = tax.ToString("c");
                    totFeesOutputLabel.Text = totalFees.ToString("c");
                }
                else
                {
                    //value is not parseable, show error
                    MessageBox.Show("Please enter a numerical value for the cost of labor.");

                    //clear the textbox for labor
                    laborTextBox.Text = "";
                }
            }
            else
            {
                //value not parseable, show error
                MessageBox.Show("Please enter a numerical value for the cost of parts.");

                //clear the textbox for parts
                partsTextBox.Text = "";
            }

        }

        private decimal OilLubeCharges(decimal oilChng, decimal lubeChng)
        {
            //combine charges for oil/lube ordered
            return oilChng + lubeChng;
        }

        private decimal FlushCharges(decimal radChrg, decimal tranChrg)
        {
            //combine charges for flushes ordered
            return radChrg + tranChrg;
        }

        private decimal MiscCharges(decimal inspectChrg, decimal muffChrg, decimal tireChrg)
        {
            //combine charges for misc services ordered
            return inspectChrg + muffChrg + tireChrg;
        }

        private decimal OtherCharges(decimal partsChrg, decimal laborChrg)
        {
            //combine parts & labor charges
            return partsChrg + laborChrg;
        }

        private decimal TaxCharges(decimal partsChrg)
        {
            //variable for tax cost
            decimal tax = 0.06m;

            //if there is a parts charge
            if (partsChrg != 0m)
            {
                //return tax on parts
                return partsChrg * tax;
            }
            else
                //if not parts charge, no tax
                return 0m;
        }

        private decimal TotalCharges(decimal totOilLube, decimal totFlushes,
            decimal totMisc, decimal totOther, decimal totTax)
        {
            //returns all total charges
            return totOilLube + totFlushes + totMisc + totOther + totTax;
        }

        private void ClearOilLube()
        {
            oilChgeChkBox.Checked = false;
            lubeChkBox.Checked = false;
        }

        private void ClearFlushes()
        {
            radFlushChkBox.Checked = false;
            tranFlushChkBox.Checked = false;
        }

        private void ClearMisc()
        {
            inspectChkBox.Checked = false;
            mufflerChkBox.Checked = false;
            tireRotChkBox.Checked = false;
        }

        private void ClearOther()
        {
            partsTextBox.Text = "";
            laborTextBox.Text = "";
        }

        private void ClearFees()
        {
            totServAndLabOutputLabel.Text = "";
            totPartsOutputLabel.Text = "";
            totTaxOutputLabel.Text = "";
            totFeesOutputLabel.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shutting Down.");
            this.Close();
        }
    }
}
