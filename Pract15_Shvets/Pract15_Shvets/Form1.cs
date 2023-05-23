using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Pract15_Shvets
{
    public partial class Form1 : Form
    {
        OneDimensionalArray array = new OneDimensionalArray();
        public Form1()
        {
            InitializeComponent();
            takeItemFromArrayGroupBox.Location = createArrayGroupBox.Location = multiplyArrayGroupBox.Location = showItemsInArrayGroupBox.Location = new Point(104,72);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void createArrayButton_Click(object sender, EventArgs e)
        {
            array.CreateArray(arraySizeTextBox.Text);
        }

        private void showArrayElementButton_Click(object sender, EventArgs e)
        {
            arrayValueLabel.Text = array.TakeElement(arrayElementIndexTextBox.Text);
        }

        private void multiplyArrayButton_Click(object sender, EventArgs e)
        {
            array.Multiply(multiplierTextBox.Text);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex.ToString())
            {
                case "0":
                    
                    takeItemFromArrayGroupBox.Visible = multiplyArrayGroupBox.Visible = showItemsInArrayGroupBox.Visible = false;
                    createArrayGroupBox.Visible = true;
                    break;
                case "1":
                    takeItemFromArrayGroupBox.Visible = true;
                    createArrayGroupBox.Visible = multiplyArrayGroupBox.Visible = showItemsInArrayGroupBox.Visible = false;
                    break;
                case "2":
                    multiplyArrayGroupBox.Visible = true;
                    createArrayGroupBox.Visible = takeItemFromArrayGroupBox.Visible = showItemsInArrayGroupBox.Visible = false;
                    break;
                case "3":
                    showItemsInArrayGroupBox.Visible = true;
                    multiplyArrayGroupBox.Visible = createArrayGroupBox.Visible = takeItemFromArrayGroupBox.Visible = false;
                    break;

            }
        }

        private void showItemsInArrayButton_Click(object sender, EventArgs e)
        {
            ArrayList myarray = array.ReturnArray();
            if (myarray == null)
                MessageBox.Show("Вы не создали массив");
            else
            {
                listOfItemsListBox.Items.Clear();
                for (int i = 0; i < myarray.Count; i++)
                {
                    listOfItemsListBox.Items.Add($"Элемент {i} = {myarray[i]}");
                }
            }
        }

      
    }
}
