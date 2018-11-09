using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOMJudgeProblemCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Problem problem;

        private void enableEditing()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            btnSave.Enabled = true;
            btnExport.Enabled = true;
        }

        private void newProblem()
        {
            // Create a new Problem object
            problem = new Problem();
            problem.TestCases = new List<string[]>();

            // Enable all the fields
            enableEditing();
            
        }

        private void importProblem()
        {
            // Import a problem from a file

            //Enable all the fields
            enableEditing();
        }
        
        private void exportProblem()
        {
            // Export a problem to a file
        }

        private void createProblemZip()
        {
            // Creates the zip of the problem to be uploaded
        }

        private void updateTestCase(int index)
        {
            // Update a test case with new data
            string[] testCaseTemp = new string[3];
            testCaseTemp[0] = richTextBox1.Text;
            testCaseTemp[1] = richTextBox2.Text;
            testCaseTemp[2] = checkSample.Checked.ToString();
            problem.TestCases[index] = testCaseTemp;
        }

        private void deleteTestCase(int index)
        {
            problem.TestCases.RemoveAt(index);
            listBox1.Items.Clear();
            for(int i = 1; i <= problem.TestCases.Count; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void createTestCase()
        {
            // Create a test case
            string[] testCaseTemp = new string[3];
            testCaseTemp[0] = richTextBox1.Text;
            testCaseTemp[1] = richTextBox2.Text;
            testCaseTemp[2] = checkSample.Checked.ToString();
            problem.TestCases.Add(testCaseTemp);
            listBox1.Items.Add(problem.TestCases.Count);
        }

        private void btnChooseColour_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                string code = (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                hexColour.BackColor = colorDialog1.Color;
                hexColour.Text = "#" + code;
            }
        }

        private void btnChooseProblemStatement_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.  
                string fileName = openFileDialog1.FileName;
                if(fileName.Length > 25)
                {
                    fileName = fileName.Substring(0, 25) + "...";
                }
                problemStatement.Text = fileName;
            }
        }

        private void newProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newProblem();
        }

        private void btnNewTestCase_Click(object sender, EventArgs e)
        {
            createTestCase();
            
        }

        private void btnUpdateTestCase_Click(object sender, EventArgs e)
        {
            
            if(richTextBox1.Text == "DELTHISCASE" && listBox1.SelectedIndex != -1)
            {
                deleteTestCase(listBox1.SelectedIndex);
            }
            else if (listBox1.SelectedIndex != -1)
            {
                updateTestCase(listBox1.SelectedIndex);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                btnUpdateTestCase.Enabled = true;
                string[] testCaseTemp = problem.TestCases[listBox1.SelectedIndex];
                richTextBox1.Text = testCaseTemp[0];
                richTextBox2.Text = testCaseTemp[1];
                checkSample.Checked = Convert.ToBoolean(testCaseTemp[2]);
            }
            else
            {
                btnUpdateTestCase.Enabled = false;
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(richTextBox1.Text == "DELTHISCASE")
            {
                btnNewTestCase.Enabled = false;
            }
            else
            {
                btnNewTestCase.Enabled = true;
            }
        }
    }
}
