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

namespace WinFrmFile1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            //FileInfo fi = new FileInfo("path");
            //if(fi.Exists())
            //{

            //}
            if(File.Exists(txtPath.Text))
            {
                MessageBox.Show("File exist.");
            }
            else
            {
                MessageBox.Show("File not exist.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtDelete.Text))
            {
                File.Delete(txtDelete.Text);
                txtDelete.Clear();
                txtDelete.Focus();
                MessageBox.Show("file deleted.");
            }
            else
            {
                MessageBox.Show("File not exist.");
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtSource.Text))
            {
                File.Copy(txtSource.Text,txtDest.Text);
                txtSource.Clear();
                txtDest.Clear();
                txtSource.Focus();
                MessageBox.Show("file copied.");
            }
            else
            {
                MessageBox.Show("Source File not exist.");
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtSource.Text))
            {
                File.Move(txtSource.Text, txtDest.Text);
                txtSource.Clear();
                txtDest.Clear();
                txtSource.Focus();
                MessageBox.Show("file Moved.");
            }
            else
            {
                MessageBox.Show("Source File not exist.");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            string path = @"c:\myTemp\MyTest.txt";

            try
            {
                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file."+ Environment.NewLine);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                  //  byte[] info = Encoding.ASCII.GetBytes("This is second line.\n"); 
                    info = Encoding.ASCII.GetBytes("This is second line.\n");
                    fs.Write(info, 0, info.Length);
                }

                // Open the stream and read it back.
               // StreamReader sr = new StreamReader(path);
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        txtDisplay.AppendText(s + Environment.NewLine);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCreatText_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            string path = @"c:\myTemp\MyTest1.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    txtDisplay.AppendText(s + Environment.NewLine);
                }
            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            //File.AppendText(String) Method
            //Creates a StreamWriter that appends UTF-8 encoded text to an existing file, 
            //or to a new file if the specified file does not exist.
            txtDisplay.Clear();
            string path = @"c:\myTemp\MyTest2.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("This");
                sw.WriteLine("is Extra");
                sw.WriteLine("Text");
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    txtDisplay.AppendText(s + Environment.NewLine);
                }
            }
        }

        private void btnAppendAllText_Click(object sender, EventArgs e)
        {
            //File.AppendAllText Method
            //Appends the specified string to the file,
            //creating the file if it does not already exist.

            //WriteAllText(String, String)
            //Creates a new file, writes the specified string to the file, and then closes the file.
            //If the target file already exists, it is overwritten.

            //File.ReadAllText Method
            //Opens a text file, reads all the text in the file into a string,
            //and then closes the file.

            txtDisplay.Clear();
            string path = @"c:\myTemp\MyTest3.txt";

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string createText = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            string appendText = "This is extra text" + Environment.NewLine;
            File.AppendAllText(path, appendText);

            // Open the file to read from.
            string readText = File.ReadAllText(path);
            txtDisplay.AppendText(readText + "\n");
        }

        private void btnOpenWrite_Click(object sender, EventArgs e)
        {
            //File.OpenWrite(String) Method
            //Opens an existing file or creates a new file for writing.

            //File.OpenRead(String) Method
            //Opens an existing file for reading.

            txtDisplay.Clear();
            string path = @"c:\myTemp\MyTest4.txt";
            

            // Open the stream and write to it.
            using (FileStream fs = File.OpenWrite(path))
            {
                Byte[] info =
                    new UTF8Encoding(true).GetBytes("This is to test the OpenWrite method.");

                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }

            // Open the stream and read it back.
            using (FileStream fs = File.OpenRead(path))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);

                while (fs.Read(b, 0, b.Length) > 0)
                {
                    txtDisplay.AppendText(temp.GetString(b));
                }
            }
            //Additional tips:
            string result = Path.GetTempPath();
            MessageBox.Show(result);
            string[] paths = { @"d:\archives", "2001", "media", "images" };
            string fullPath = Path.Combine(paths);
            MessageBox.Show(fullPath);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //File.Open Method  ---> Open(String, FileMode, FileAccess)
            //Opens a FileStream on the specified path,
            //with the specified mode and access with no sharing.
            // Create a temporary file, and put some data into it.

            txtDisplay.Clear();
            string path = Path.GetTempFileName();
            //Path.GetTempFileName Method
            //Creates a uniquely named, zero-byte temporary file on disk and
            //returns the full path of that file.

            //Path.GetTempPath Method
            //Returns the path of the current user's temporary folder.
            //For Example:
            //string result = Path.GetTempPath();
            //MessageBox.Show(result);

            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }

            // Open the stream and read it back.
            using (FileStream fs = File.Open(path, FileMode.Open))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);

                while (fs.Read(b, 0, b.Length) > 0)
                {
                    txtDisplay.AppendText(temp.GetString(b));
                }
            }
            MessageBox.Show(path);
        }

        private void btnReadAndWrite_Click(object sender, EventArgs e)
        {
            string srcPath = @"C:\source\SolarSystem.PNG";
            string destPath = @"C:\myTemp\SolarSystem.PNG";
            byte[] buff = File.ReadAllBytes(srcPath);            
            File.WriteAllBytes(destPath, buff);

            string output = "Length of file:" + buff.Length + "\n";
            output += "The read data was written from the source file to the destination file.";
            MessageBox.Show(output);
        }
    }
}
/*
Check other methods
GetCreationTime:     Returns a DateTime object representing when the file/directory was created.
GetLastAccessTime:   Returns a DateTime object representing when the file/directory was last accessed.
GetLastWriteTime:    Returns a DateTime object representing when the file/directory was last modified.
*/
