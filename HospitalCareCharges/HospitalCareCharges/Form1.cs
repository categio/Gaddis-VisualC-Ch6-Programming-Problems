using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalCareCharges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void calcButton_Click(object sender, EventArgs e)
        {
            //declare variables to hold values entered & output
            decimal meds = 0m, surgery = 0m, labs = 0m, rehab = 0m,
                days = 0m, totMiscCost = 0m, totStayCost = 0m, totCost = 0m;

            //check input with TryParse method
            if (decimal.TryParse(medsTextBox.Text, out meds))
            {
                if (decimal.TryParse(surgeryTextBox.Text, out surgery))
                {
                    if (decimal.TryParse(labsTextBox.Text, out labs))
                    {
                        if (decimal.TryParse(rehabTextBox.Text, out rehab))
                        {
                            if (decimal.TryParse(daysTextBox.Text, out days))
                            {
                                //get calculations from methods
                                totMiscCost = CalcMiscCharges(meds, surgery, labs, rehab);

                                totStayCost = CalcStayCharges(days);

                                totCost = CalcTotalCharges(totStayCost, totMiscCost);

                                //output to form labels
                                medSvcsOutputLabel.Text = totMiscCost.ToString("c");
                                rmBoardOutputLabel.Text = totStayCost.ToString("C");
                                grandTotalOutputLabel.Text = totCost.ToString("C");
                            }
                            else
                            {
                                //call error message
                                DataErrorMessage();
                                //clear days textbox input
                                ClearDaysBox();
                            }
                        }
                        else
                        {
                            //call error message
                            DataErrorMessage();
                            //clear rehab textbox input
                            ClearRehabBox();
                        }
                    }
                    else
                    {
                        //call error message
                        DataErrorMessage();
                        //clear labs textbox input
                        ClearLabsBox();
                    }
                }
                else
                {
                    //call error message
                    DataErrorMessage();
                    //clear surgery textbox input
                    ClearSurgeryBox();
                }
            }
            else
            {
                //call error message
                DataErrorMessage();
                //clear meds textbox input
                ClearMedsBox();
            }
        }

        //error in data input message
        private void DataErrorMessage()
        {
            MessageBox.Show("Please enter a numerical value.");
        }

        //calculate all the service charges
        private decimal CalcMiscCharges(decimal medsChrg, decimal surgeryChrg,
            decimal labsChrg, decimal rehabChrg)
        {
            return medsChrg + surgeryChrg + labsChrg + rehabChrg;
        }

        //calculate hospital overnight charges at $350 a day
        private decimal CalcStayCharges(decimal days)
        {
            return 350 * days;
        }

        //calculate grand total of both services and overnight charges
        private decimal CalcTotalCharges(decimal stayCost, decimal miscChrgCost)
        {
            return stayCost + miscChrgCost;
        }

        //clears daysTextBox 
        private void ClearDaysBox()
        {
            daysTextBox.Text = "";
        }

        private void ClearRehabBox()
        {
            rehabTextBox.Text = "";
        }

        private void ClearLabsBox()
        {
            labsTextBox.Text = "";
        }

        private void ClearSurgeryBox()
        {
            surgeryTextBox.Text = "";
        }

        private void ClearMedsBox()
        {
            medsTextBox.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears the form
            ClearDaysBox();
            ClearRehabBox();
            ClearLabsBox();
            ClearSurgeryBox();
            ClearMedsBox();
            medSvcsOutputLabel.Text = "";
            rmBoardOutputLabel.Text = "";
            grandTotalOutputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
