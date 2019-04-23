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

namespace Readexportfile
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFile = new OpenFileDialog();
        private List<string> AnimalString = new List<string>();
        private string Animal = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void SelectFileBtn_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Text file |*.txt";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                ReadFile(openFile.FileName);
                CheckAnimal();
            }
        }

        private void ReadFile(string filename)
        {
            using (StreamReader read = new StreamReader(openFile.FileName))
            {
                while(Animal != null)
                {
                    try
                    {
                        Animal = read.ReadLine();
                        if (Animal != null)
                        {
                            AnimalString.Add(Animal);
                        }
                    }
                    catch(ArgumentOutOfRangeException Exception)
                    {
                        MessageBox.Show(Exception.ToString());
                    }
                    catch(NotSupportedException)
                    {
                        MessageBox.Show("Unable to Read File");
                    }
                    catch(IOException Exception)
                    {
                        MessageBox.Show("An error occurred when reading file: " + Exception.ToString());
                    }
                    catch(ArgumentException Exception)
                    {
                        MessageBox.Show(Exception.ToString());
                    }
                    catch(ObjectDisposedException)
                    {
                        MessageBox.Show("File is not open");
                    }
                }
            }
        }

        private void CheckAnimal()
        {
            foreach(string s in AnimalString)
            {
                string species = s.Substring(0, s.IndexOf(':'));
                string info = s.Substring(s.IndexOf(':') + 1);
                if(species.ToUpper() == "DOG")
                {
                    listBoxDog.Items.Add(info);
                }
                else if(species.ToUpper() == "CAT")
                {
                    listBoxCat.Items.Add(info);
                }
            }

        }
    }
}
