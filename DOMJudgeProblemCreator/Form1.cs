using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DOMJudgeProblemCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        private Problem problem;
        private string FormTitle = "DOMJudge Problem Creator";

        // UPDATE THIS VERSION SO THAT IT WILL NOT BE STUCK IN AN UPDATE LOOP
        Version mainVersion = new Version("1.0.0");

        private void updateCheck()
        {
            try
            {
                Version remoteVersion = new Version(new System.Net.WebClient().DownloadString("https://version.davidhui.ca/domjudgeproblemcreator/version.txt"));
                if (remoteVersion.CompareTo(mainVersion) > 0)
                {
                    if (MessageBox.Show("There is a new version available. Would you like to open a browser to download it?", FormTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("https://version.davidhui.ca/domjudgeproblemcreator/new.html");
                    }
                }
            }
            catch
            {
                Console.WriteLine("No internet connection. Skipping update check.");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateCheck();
        }

        private void enableEditing()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            btnSave.Enabled = true;
            btnExport.Enabled = true;
            listBox1.Enabled = true;
        }

        private void newProblem()
        {
            // Create a new Problem object
            problem = new Problem();
            problem.TestCases = new List<string[]>();
            listBox1.Items.Clear();

            testCases.Text = "no test cases";
            name.Text = "";
            nickName.Text = "";
            memLimit.Text = "";
            timeLimit.Text = "";
            hexColour.Text = "#FFFFFF";
            hexColour.BackColor = Color.FromName("white");
            problemStatement.Text = "Invalid path!";

            richTextBox1.Text = "Sample Input";
            richTextBox2.Text = "Sample Output";
            
            checkSample.Checked = false;

            this.Text = FormTitle;
            // Enable all the fields
            enableEditing();
            
        }

        private bool updateProblemObject()
        {
            try
            {
                problem.Name = name.Text;
                if(nickName.Text.Split(' ').Length > 1)
                {
                    MessageBox.Show("The short name cannot contain any spaces!", FormTitle, MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
                problem.ShortName = nickName.Text;
                problem.MaxMemory = Math.Abs(Convert.ToInt64(memLimit.Text));
                problem.MaxTime = Math.Abs(Convert.ToDouble(timeLimit.Text));

                // Check if any values are weird
                if (problem.ProblemStatementPath == null && MessageBox.Show("You have no problem statement! Continue?", FormTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    return false;
                }

                if (problem.TestCases.Count < 1 && MessageBox.Show("You have no test cases! Continue?", FormTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    return false;
                }

                if (problem.MaxMemory > 512 && MessageBox.Show("Your maximum memory is unusally high. Did you input the correct value?", FormTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return false;
                }

                if (problem.MaxTime > 10 && MessageBox.Show("Your maximum time is unusally high. Did you input the correct value?", FormTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return false;
                }

                return true;
            }
            catch
            {
                MessageBox.Show("Invalid data. Please check your fields and try again.", FormTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        private void importProblem()
        {
            // Import a problem from a file

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Problem Descriptor Files|*.problem";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.  
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string savedData = sr.ReadToEnd();

                XmlSerializer serializer = new XmlSerializer(typeof(Problem));
                using (TextReader reader = new StringReader(savedData))
                {
                    try
                    {
                        problem = (Problem)serializer.Deserialize(reader);
                        listBox1.Items.Clear();
                        for (int i = 0; i < listBox1.Items.Count; i++)
                        {
                            listBox1.Items.Add(i);
                        }
                        testCases.Text = problem.TestCases.Count.ToString();
                        name.Text = problem.Name;
                        nickName.Text = problem.ShortName;
                        memLimit.Text = problem.MaxMemory.ToString();
                        timeLimit.Text = problem.MaxTime.ToString();
                        hexColour.Text = problem.HexColour;

                        Color temp = ColorTranslator.FromHtml(problem.HexColour);
                        hexColour.BackColor = Color.FromArgb(temp.R, temp.G, temp.B);

                        string problemFileName = problem.ProblemStatementPath;
                        if (problemFileName.Length > 25)
                        {
                            problemFileName = problemFileName.Substring(0, 25) + "...";
                        }
                        problemStatement.Text = problemFileName;

                        for (int i = 0; i < problem.TestCases.Count; i++)
                        {
                            listBox1.Items.Add(i + 1);
                        }

                        // Allow editing
                        enableEditing();
                        sr.Close();
                        string[] titleTextTemp = this.Text.Split(Convert.ToChar("-"));
                        this.Text = FormTitle + " - " + openFileDialog1.FileName;
                        //Console.WriteLine(fileName);
                        
                    }
                    catch
                    {
                        MessageBox.Show("This save file is corrupt!", FormTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }
        
        private void exportProblem()
        {
            // Export a problem to a file

            // Update the problem object
            bool updatedObject = updateProblemObject();

            if (!updatedObject)
            {
                return;
            }

            // Show the save file dialog
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.Filter = "Problem Descriptor Files|*.problem";
            saveFileDialog1.OverwritePrompt = true;
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StringWriter Output = new StringWriter(new StringBuilder());
                XmlSerializer xs = new XmlSerializer(problem.GetType());
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("ProblemDescriptor", "http://davidhui.ca"); // add as many or few as you need
                xs.Serialize(Output, problem, ns);
                try
                {
                    File.WriteAllText(saveFileDialog1.FileName, Output.ToString());
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, FormTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void createProblemZip()
        {
            // Creates the zip of the problem to be uploaded

            // Asks user for the file to save as

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.Filter = "ZIP Files|*.zip";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Update problem object
                updateProblemObject();

                // Setup a temporary directory / clear an old one
                try
                {
                    if (Directory.Exists("temp"))
                    {
                        Directory.Delete("temp", true);
                    }
                    Directory.CreateDirectory("temp");
                    Directory.CreateDirectory("temp/problem_statement");
                    Directory.CreateDirectory("temp/data");
                }
                catch
                {
                    MessageBox.Show("Unable to setup a working directory.", FormTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check to see if need to create a sample data dir
                bool hasSample = false;
                bool hasSecret = false;
                foreach (string[] testCase in problem.TestCases)
                {
                    if (testCase[2] == "True")
                    {
                        hasSample = true;
                        if (hasSecret)
                        {
                            break;
                        }
                    }
                    else if (testCase[2] == "False")
                    {
                        hasSecret = true;
                        if (hasSample)
                        {
                            break;
                        }
                    }
                }

                if (hasSample)
                {
                    Directory.CreateDirectory("temp/data/sample");
                }

                if (hasSecret)
                {
                    Directory.CreateDirectory("temp/data/secret");
                }

                // Copy the problem statement
                if (problem.ProblemStatementPath != null)
                {
                    try
                    {
                        File.Copy(problem.ProblemStatementPath, "temp/problem_statement/problem.pdf");
                    }
                    catch
                    {
                        MessageBox.Show("Unable to copy the problem statement into the working direcotry.", FormTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Generate the problem yaml
                using (StreamWriter writetext = new StreamWriter("temp/problem.yaml"))
                {
                    writetext.WriteLine("---");
                    writetext.WriteLine("name: " + problem.Name);
                    writetext.WriteLine("limits:");
                    writetext.WriteLine("    memory: " + problem.MaxMemory);
                }

                // Gegerate the problem ini
                using (StreamWriter writetext = new StreamWriter("temp/domjudge-problem.ini"))
                {
                    writetext.WriteLine($"probid = '{problem.ShortName}'");
                    writetext.WriteLine($"timelimit = '{problem.MaxTime}'");
                    writetext.WriteLine($"color = '{problem.HexColour}'");
                }

                // Copy the test cases
                int i = 0;
                foreach (string[] testCase in problem.TestCases)
                {
                    string path = "temp/data/";
                    if (Convert.ToBoolean(testCase[2]))
                    {
                        path += "sample/";
                    }
                    else
                    {
                        path += "secret/";
                    }
                    try
                    {
                        File.WriteAllLines(path + (i + 1) + ".in", new string[] { testCase[0] });
                        File.WriteAllLines(path + (i + 1) + ".ans", new string[] { testCase[1] });
                    }
                    catch
                    {
                        MessageBox.Show("Unable to copy the test case into the working directory.", FormTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    i++;
                }

                // Generate the zip
                try
                {
                    ZipFile.CreateFromDirectory("temp", saveFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show("Unable to generate a zip file. Please do it manually.", FormTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            
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
            testCases.Text = listBox1.Items.Count.ToString();
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

            // Update the number of test cases label
            testCases.Text = listBox1.Items.Count.ToString();
        }

        private void btnChooseColour_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                string code = (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                hexColour.BackColor = colorDialog1.Color;
                hexColour.Text = "#" + code;
                problem.HexColour = "#" + code;
            }
        }

        private void btnChooseProblemStatement_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "PDF Files|*.pdf|TXT Files|*.txt";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.  
                string fileName = openFileDialog1.FileName;
                problem.ProblemStatementPath = fileName;
                if (fileName.Length > 25)
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

        private void btnDeleteTestCase_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1 && MessageBox.Show("Are you sure you want to delete this test case?",FormTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                deleteTestCase(listBox1.SelectedIndex);
            }
        }

        private void btnUpdateTestCase_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedIndex != -1)
            {
                updateTestCase(listBox1.SelectedIndex);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                btnUpdateTestCase.Enabled = true;
                btnDeleteTestCase.Enabled = true;
                string[] testCaseTemp = problem.TestCases[listBox1.SelectedIndex];
                richTextBox1.Text = testCaseTemp[0];
                richTextBox2.Text = testCaseTemp[1];
                checkSample.Checked = Convert.ToBoolean(testCaseTemp[2]);
            }
            else
            {
                btnUpdateTestCase.Enabled = false;
                btnDeleteTestCase.Enabled = false;
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            exportProblem();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            importProblem();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            createProblemZip();
        }

        private void openJudgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://judge.codereach.ca");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.terminate = true;
        }
    }
}
