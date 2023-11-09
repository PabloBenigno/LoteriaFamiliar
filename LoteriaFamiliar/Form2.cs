using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoteriaFamiliar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            dataGridNumbers.Rows.Clear();
            dataGridNumbers.Rows.Insert(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            dataGridNumbers.Rows.Insert(1, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20);
            dataGridNumbers.Rows.Insert(2, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30);
            dataGridNumbers.Rows.Insert(3, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40);
            dataGridNumbers.Rows.Insert(4, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50);
            dataGridNumbers.Rows.Insert(5, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60);
            dataGridNumbers.Rows.Insert(6, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70);
            dataGridNumbers.Rows.Insert(7, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80);
            dataGridNumbers.Rows.Insert(8, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90);

            KeyDown += Form_KeyDown;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }
    }
}
