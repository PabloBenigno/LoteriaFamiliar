using System.ComponentModel;
using System.Media;

namespace LoteriaFamiliar
{
    public partial class Form1 : Form
    {
        private BackgroundWorker _worker = new();
        private List<int> _numbers;
        private bool _playing = false;

        SoundPlayer Player = new SoundPlayer();
        Form2 f;

        public Form1()
        {
            InitializeComponent();
            InitializeGrid();

            _worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            _worker.WorkerSupportsCancellation = true;

            KeyDown += Form_KeyDown;
        }

        private void InitializeGrid()
        {
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
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (!_playing)
                return;

            if (e.KeyCode == Keys.Space)
            {
                _playing = false;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            f = new Form2();

            // Copy styles
            for (int i = 0; i < f.dataGridNumbers.Rows.Count; i++)
            {
                for (int j = 0; j < f.dataGridNumbers.Columns.Count; j++)
                {
                    f.dataGridNumbers.Rows[i].Cells[j].Style.BackColor = dataGridNumbers.Rows[i].Cells[j].Style.BackColor;
                    f.dataGridNumbers.Rows[i].Cells[j].Style.ForeColor = dataGridNumbers.Rows[i].Cells[j].Style.ForeColor;
                }
            }

            f.Show();
            btnContinue.Visible = true;
            btnContinue.Select();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (dataGridNumbers.CurrentCell != null)
                dataGridNumbers.CurrentCell.Selected = false;

            _numbers = Enumerable.Range(1, 90).ToList();
            _playing = true;

            _worker.RunWorkerAsync();

            btnStart.Enabled = false;
            btnStart.Text = "Jugando...";
        }

        private void SetGridCellSelected(int number)
        {
            int row = ((number - 1) % 100 - (number - 1) % 10) / 10;
            int column = (number - 1) % 10;

            dataGridNumbers.Invoke((MethodInvoker)delegate
            {
                dataGridNumbers.Rows[row].Cells[column].Style.BackColor = Color.Yellow;
                dataGridNumbers.Rows[row].Cells[column].Style.ForeColor = Color.Red;
                dataGridNumbers.Update();
            });


        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep((int)numericWait.Value * 1000);

                if (_playing && _numbers.Count > 0)
                {
                    Random rnd = new();

                    // 0 to numbers size
                    var index = rnd.Next(_numbers.Count);

                    UpdateLabels(index);

                    SetGridCellSelected(_numbers[index]);

                    Player.SoundLocation = $"Sounds\\{_numbers[index]}.wav";

                    _numbers.RemoveAt(index);

                    lblBallsIn.Invoke((MethodInvoker)delegate
                    {
                        lblBallsIn.Text = _numbers.Count.ToString();
                        lblBallsIn.Update();
                    });

                    lblBallsOut.Invoke((MethodInvoker)delegate
                    {
                        lblBallsOut.Text = (90 - _numbers.Count).ToString();
                        lblBallsOut.Update();
                    });

                    Player.PlaySync();
                }

                if (_worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void UpdateLabels(int index)
        {
            lblCurrentNumber.Invoke((MethodInvoker)delegate
            {
                lblCurrentNumber.Text = _numbers[index].ToString();
                lblCurrentNumber.Update();
            });
            lblLast5.Invoke((MethodInvoker)delegate
            {
                lblLast5.Text = lblLast4.Text;
                lblLast5.Update();
            });
            lblLast4.Invoke((MethodInvoker)delegate
            {
                lblLast4.Text = lblLast3.Text;
                lblLast4.Update();
            });
            lblLast3.Invoke((MethodInvoker)delegate
            {
                lblLast3.Text = lblLast2.Text;
                lblLast3.Update();
            });
            lblLast2.Invoke((MethodInvoker)delegate
            {
                lblLast2.Text = lblLast1.Text;
                lblLast2.Update();
            });
            lblLast1.Invoke((MethodInvoker)delegate
            {
                lblLast1.Text = lblCurrentNumber.Text;
                lblLast1.Update();
            });
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = false;
            btnContinue.Visible = false;

            f?.Close();

            _playing = false;
            _numbers = Enumerable.Range(1, 90).ToList();

            _worker.CancelAsync();

            Thread.Sleep(1000);

            InitializeGrid();

            btnStart.Enabled = true;
            btnStart.Text = "Comenzar";
            lblCurrentNumber.Text = "";
            lblLast1.Text = "";
            lblLast2.Text = "";
            lblLast3.Text = "";
            lblLast4.Text = "";
            lblLast5.Text = "";
            lblBallsIn.Text = _numbers.Count.ToString();
            lblBallsOut.Text = (90 - _numbers.Count).ToString();

            btnReset.Enabled = true;
            btnStart.Select();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            _playing = true;
            btnContinue.Visible = false;

            f?.Close();
        }
    }
}