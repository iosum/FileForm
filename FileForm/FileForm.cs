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
using System.Diagnostics;

namespace FileForm
{
    public partial class FileForm : Form
    {
        private StreamReader _reader;
        private StreamWriter _writer;
        private const string FILENAME = "filename.txt";

        public FileForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The button will handling save files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _saveButton_click(object sender, EventArgs e)
        {
            // if we can write into a file
            try
            {
                // open a stream writer and specify a filename and override the old content
                this._writer = new StreamWriter(FILENAME);
                // get the data from the text box and write it into a file
                _writer.WriteLine(WriteFirstNameTextBox.Text);
                _writer.WriteLine(WriteLastNameTextBox.Text);
                // close the writer
                _writer.Close();
                
                // pop up the message to hint the user
                MessageBox.Show("Save File Successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // clear the textboxes
                WriteFirstNameTextBox.Clear();
                WriteLastNameTextBox.Clear();
                WriteFirstNameTextBox.Focus();

            }
            catch(Exception ex)
            {
                Debug.WriteLine("Error : Can not write into a file", ex.Message);
                MessageBox.Show("Cannot save the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// This button will handle uploading a file 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void _uploadFileButton_click(object sender, EventArgs e)
        {
            // if there is a file to read
            try
            {
                // open a file reader
                this._reader = new StreamReader(FILENAME);
                // get the line and read it into the textbox
                ReadFirstNameTextBox.Text = _reader.ReadLine();
                ReadLastNameTextBox.Text = _reader.ReadLine();
                // close the reader
                _reader.Close();

            }
            // otherwise, the file doesn't exist
            catch (Exception ex)
            {
                Debug.WriteLine("Error : Can not open a file", ex.Message);
                MessageBox.Show("The file doesn't exist","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
