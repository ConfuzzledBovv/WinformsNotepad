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
using System.Security;

namespace Notes
{
    public partial class Notes : Form
    {
        bool hasFilePath, textChanged, saveCancelled;
        FileInfo fi;
        TextWriter myStream;
        SaveFileDialog saveFileDialog;
        public Notes()
        {
            InitializeComponent();
            hasFilePath = false;
            textChanged = false;
            saveCancelled = false;
            saveFileDialog = new SaveFileDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if(hasFilePath == true)
            {
                if((myStream = new StreamWriter(saveFileDialog.FileName)) != null)
                {
                    myStream.Write(Data.Text);
                }
                myStream.Close();
            }
            else
            {
                saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files (*.txt) | *.txt|All files (*.*) |*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = new StreamWriter(saveFileDialog.FileName)) != null)
                    {
                        try
                        {
                            myStream.Write(Data.Text);
                            hasFilePath = true;
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine("There was an error: " + exception.Message);
                        }
                        finally
                        {
                            myStream.Close();
                            fi = new FileInfo(saveFileDialog.FileName);
                            this.Text = fi.Name;
                        }
                    }
                }
                else
                {
                    saveCancelled = true;
                    return;
                }
            }
            textChanged = false;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr;
                try
                {
                    sr = new StreamReader(openFileDialog.FileName);
                    Data.Text = sr.ReadToEnd();
                    hasFilePath = true;
                    sr.Close();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
                finally
                {
                    this.Text = openFileDialog.SafeFileName;
                    saveFileDialog.FileName = openFileDialog.FileName;
                }
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            this.Text = "NewNotes.txt";
            hasFilePath = false;
            Data.Text = null;
        }

        private void Notes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(textChanged)
            {
                DialogResult window = MessageBox.Show("Are you sure?", "Exit without saving", MessageBoxButtons.YesNoCancel);

                if (window == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

                switch (window)
                {
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        Save();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }

                if(saveCancelled)
                {
                    e.Cancel = true;
                    saveCancelled = false;
                }
            }
        }

        private void Data_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;
        }
    }
}
