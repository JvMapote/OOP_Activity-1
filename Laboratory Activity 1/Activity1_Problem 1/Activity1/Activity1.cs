﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1
{
    /* 
     * FullName: Jayvee N. Mapote
     * Section: C11
     * Course: IT105L
     * Laboratory Activity 1 : Problem 1
     */

    public partial class Activity1 : Form
    {
        //Initialized variables
        String name;
        Double AssignmentValue, QuizValue, prelimValue, midtermValue, finalValue, finalGrade, equivalentGrade;  

        //Submit Button
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Convertion of inputs
                AssignmentValue = Convert.ToDouble(AssignmentBox.Text);
                QuizValue = Convert.ToDouble(QuizBox.Text);
                prelimValue = Convert.ToDouble(PrelimBox.Text);
                midtermValue = Convert.ToDouble(MidtermBox.Text);
                finalValue = Convert.ToDouble(FinalBox.Text);
                //Weight of grades
                AssignmentValue *= 0.1;
                QuizValue *= 0.3;
                prelimValue *= 0.2;
                midtermValue *= 0.2;
                finalValue *= 0.2;

                //Computation of final grades
                finalGrade = AssignmentValue + QuizValue + prelimValue + midtermValue + finalValue;
                FinalGradeBox.Text = finalGrade.ToString();

                //Determining the Equivalent grade
                if (finalGrade > 96 && finalGrade <= 100)
                {
                    equivalentGrade = 1.00;
                }
                else if (finalGrade >= 91.51 && finalGrade <= 96)
                {
                    equivalentGrade = 1.25;
                }
                else if (finalGrade >= 87.01 && finalGrade <= 91.50)
                {
                    equivalentGrade = 1.50;
                }
                else if (finalGrade >= 82.51 && finalGrade <= 87)
                {
                    equivalentGrade = 1.75;
                }
                else if (finalGrade >= 78.01 && finalGrade <= 82.50)
                {
                    equivalentGrade = 2.00;
                }
                else if (finalGrade >= 73.51 && finalGrade <= 78)
                {
                    equivalentGrade = 2.25;
                }
                else if (finalGrade >= 69.01 && finalGrade <= 73.50)
                {
                    equivalentGrade = 2.50;
                }
                else if (finalGrade >= 64.51 && finalGrade <= 69)
                {
                    equivalentGrade = 2.75;
                }
                else if (finalGrade >= 60 && finalGrade <= 64.50)
                {
                    equivalentGrade = 3.00;
                }
                else if (finalGrade < 60)
                {
                    equivalentGrade = 5.00;
                }
                EquivalentGradeBox.Text = equivalentGrade.ToString();
                if (equivalentGrade <= 3.00)
                {
                    MessageBox.Show(name + " Have Passed", "Status");
                    Result_Label.Text = name + " Have Passed the course!";
                }
                else
                {
                    MessageBox.Show(name + " Have Failed", "Status");
                    Result_Label.Text = name + " Have failed the course.";
                }
       
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input", "Error");     //Error message, if they left a textbox empty
            }
        }

        //Exit
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            name = (String)NameBox.Text;
            if (name == "exit" || name == "Exit" || name == "EXIT")
            {
                Application.Exit();
            }
        }
        //Clear Button
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            AssignmentBox.Clear();
            QuizBox.Clear();
            PrelimBox.Clear();
            MidtermBox.Clear();
            FinalBox.Clear();
            NameBox.Clear();
            NameBox.Focus();
        }
        //Auto set minimum (0) and maximum (100) value on textbox
        private void PrelimBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                prelimValue = Convert.ToDouble(PrelimBox.Text);
            }
            catch (Exception)
            {
                PrelimBox.Text = null;
            }

            if (prelimValue > 100)
            {
                PrelimBox.Text = "100";
            }
            else if (prelimValue < 0)
            {
                PrelimBox.Text = "0";
            }
        }
        //Auto set minimum (0) and maximum (100) value on textbox
        private void MidtermBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                midtermValue = Convert.ToDouble(MidtermBox.Text);
            }
            catch (Exception)
            {
                MidtermBox.Text = null;
            }

            if (midtermValue > 100)
            {
                MidtermBox.Text = "100";
            }
            else if (midtermValue < 0)
            {
                MidtermBox.Text = "0";
            }
        }
        //Auto set minimum (0) and maximum (100) value on textbox
        private void FinalBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                finalValue = Convert.ToDouble(FinalBox.Text);
            }
            catch (Exception)
            {
                FinalBox.Text = null;
            }

            if (finalValue > 100)
            {
                FinalBox.Text = "100";
            }
            else if (finalValue < 0)
            {
                FinalBox.Text = "0";
            }
        }
        //Auto set minimum (0) and maximum (100) value on textbox
        private void QuizBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                QuizValue = Convert.ToDouble(QuizBox.Text);
            }
            catch (Exception)
            {
                QuizBox.Text = null;
            }

            if (QuizValue > 100)
            {
                QuizBox.Text = "100";
            }
            else if (QuizValue < 0)
            {
                QuizBox.Text = "0";
            }
        }
        //Auto set minimum (0) and maximum (100) value on textbox
        private void AssignmentBox_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                AssignmentValue = Convert.ToDouble(AssignmentBox.Text);
            }
            catch (Exception)
            {
                AssignmentBox.Text = null;
            }

            if (AssignmentValue > 100)
            {
                AssignmentBox.Text = "100";
            }
            else if(AssignmentValue < 0)
            {
                AssignmentBox.Text = "0";
            }
        }
        public Activity1()
        {
            InitializeComponent();
        }
    }
}
