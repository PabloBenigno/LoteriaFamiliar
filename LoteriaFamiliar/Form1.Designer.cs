namespace LoteriaFamiliar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            dataGridNumbers = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnContinue = new Button();
            label2 = new Label();
            numericWait = new NumericUpDown();
            label1 = new Label();
            btnStart = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            lblCurrentNumber = new Label();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btnReset = new Button();
            label8 = new Label();
            lblBallsIn = new Label();
            label6 = new Label();
            label5 = new Label();
            lblBallsOut = new Label();
            label3 = new Label();
            panel4 = new Panel();
            lblLast5 = new Label();
            lblLast4 = new Label();
            lblLast3 = new Label();
            lblLast2 = new Label();
            lblLast1 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridNumbers).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericWait).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridNumbers);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 95);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1156, 817);
            panel1.TabIndex = 0;
            // 
            // dataGridNumbers
            // 
            dataGridNumbers.AllowUserToAddRows = false;
            dataGridNumbers.AllowUserToDeleteRows = false;
            dataGridNumbers.AllowUserToResizeColumns = false;
            dataGridNumbers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridNumbers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridNumbers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridNumbers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridNumbers.BackgroundColor = SystemColors.Control;
            dataGridNumbers.BorderStyle = BorderStyle.None;
            dataGridNumbers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridNumbers.ColumnHeadersVisible = false;
            dataGridNumbers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridNumbers.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridNumbers.Dock = DockStyle.Fill;
            dataGridNumbers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridNumbers.Enabled = false;
            dataGridNumbers.Location = new Point(0, 0);
            dataGridNumbers.Margin = new Padding(3, 4, 3, 4);
            dataGridNumbers.MultiSelect = false;
            dataGridNumbers.Name = "dataGridNumbers";
            dataGridNumbers.ReadOnly = true;
            dataGridNumbers.RowHeadersVisible = false;
            dataGridNumbers.RowHeadersWidth = 51;
            dataGridNumbers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridNumbers.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridNumbers.RowTemplate.DefaultCellStyle.ForeColor = Color.Silver;
            dataGridNumbers.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridNumbers.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Silver;
            dataGridNumbers.RowTemplate.DividerHeight = 2;
            dataGridNumbers.RowTemplate.Height = 60;
            dataGridNumbers.RowTemplate.ReadOnly = true;
            dataGridNumbers.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridNumbers.ScrollBars = ScrollBars.None;
            dataGridNumbers.Size = new Size(1156, 817);
            dataGridNumbers.TabIndex = 0;
            dataGridNumbers.TabStop = false;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Column4";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Column5";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Column6";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Column7";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.HeaderText = "Column8";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column9.HeaderText = "Column9";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column10.HeaderText = "Column10";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(btnContinue);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(numericWait);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnStart);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1657, 95);
            panel2.TabIndex = 1;
            // 
            // btnContinue
            // 
            btnContinue.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinue.Location = new Point(19, 24);
            btnContinue.Margin = new Padding(3, 4, 3, 4);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(117, 36);
            btnContinue.TabIndex = 6;
            btnContinue.Text = "Continuar";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Visible = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(337, 27);
            label2.Name = "label2";
            label2.Size = new Size(103, 24);
            label2.TabIndex = 5;
            label2.Text = "segundos";
            // 
            // numericWait
            // 
            numericWait.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numericWait.Location = new Point(289, 24);
            numericWait.Margin = new Padding(3, 4, 3, 4);
            numericWait.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericWait.Name = "numericWait";
            numericWait.Size = new Size(41, 30);
            numericWait.TabIndex = 4;
            numericWait.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(203, 27);
            label1.Name = "label1";
            label1.Size = new Size(84, 24);
            label1.TabIndex = 1;
            label1.Text = "Esperar";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(19, 21);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(117, 36);
            btnStart.TabIndex = 0;
            btnStart.Text = "Comenzar";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(btnReset);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(lblBallsIn);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lblBallsOut);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1156, 95);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(501, 946);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Blue;
            panel5.Controls.Add(lblCurrentNumber);
            panel5.Location = new Point(150, 308);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(317, 328);
            panel5.TabIndex = 18;
            // 
            // lblCurrentNumber
            // 
            lblCurrentNumber.BackColor = Color.Yellow;
            lblCurrentNumber.BorderStyle = BorderStyle.FixedSingle;
            lblCurrentNumber.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentNumber.ForeColor = Color.Red;
            lblCurrentNumber.Location = new Point(17, 24);
            lblCurrentNumber.Name = "lblCurrentNumber";
            lblCurrentNumber.Size = new Size(277, 282);
            lblCurrentNumber.TabIndex = 17;
            lblCurrentNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "logo.png";
            pictureBox1.Location = new Point(269, 44);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(31, 373);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(103, 36);
            btnExit.TabIndex = 13;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Visible = false;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(31, 329);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(103, 36);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reiniciar";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(187, 104);
            label8.Name = "label8";
            label8.Size = new Size(61, 24);
            label8.TabIndex = 11;
            label8.Text = "bolas";
            // 
            // lblBallsIn
            // 
            lblBallsIn.AutoSize = true;
            lblBallsIn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBallsIn.Location = new Point(150, 104);
            lblBallsIn.Name = "lblBallsIn";
            lblBallsIn.Size = new Size(32, 24);
            lblBallsIn.TabIndex = 10;
            lblBallsIn.Text = "90";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(31, 104);
            label6.Name = "label6";
            label6.Size = new Size(84, 24);
            label6.TabIndex = 9;
            label6.Text = "Quedan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(187, 44);
            label5.Name = "label5";
            label5.Size = new Size(61, 24);
            label5.TabIndex = 8;
            label5.Text = "bolas";
            // 
            // lblBallsOut
            // 
            lblBallsOut.AutoSize = true;
            lblBallsOut.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBallsOut.Location = new Point(160, 44);
            lblBallsOut.Name = "lblBallsOut";
            lblBallsOut.Size = new Size(21, 24);
            lblBallsOut.TabIndex = 7;
            lblBallsOut.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 44);
            label3.Name = "label3";
            label3.Size = new Size(109, 24);
            label3.TabIndex = 6;
            label3.Text = "Han salido";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(lblLast5);
            panel4.Controls.Add(lblLast4);
            panel4.Controls.Add(lblLast3);
            panel4.Controls.Add(lblLast2);
            panel4.Controls.Add(lblLast1);
            panel4.Controls.Add(label9);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 912);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1156, 129);
            panel4.TabIndex = 3;
            // 
            // lblLast5
            // 
            lblLast5.BackColor = Color.Yellow;
            lblLast5.BorderStyle = BorderStyle.FixedSingle;
            lblLast5.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblLast5.ForeColor = Color.Red;
            lblLast5.Location = new Point(721, 28);
            lblLast5.Name = "lblLast5";
            lblLast5.Size = new Size(126, 79);
            lblLast5.TabIndex = 15;
            lblLast5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLast4
            // 
            lblLast4.BackColor = Color.Yellow;
            lblLast4.BorderStyle = BorderStyle.FixedSingle;
            lblLast4.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblLast4.ForeColor = Color.Red;
            lblLast4.Location = new Point(588, 28);
            lblLast4.Name = "lblLast4";
            lblLast4.Size = new Size(127, 79);
            lblLast4.TabIndex = 14;
            lblLast4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLast3
            // 
            lblLast3.BackColor = Color.Yellow;
            lblLast3.BorderStyle = BorderStyle.FixedSingle;
            lblLast3.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblLast3.ForeColor = Color.Red;
            lblLast3.Location = new Point(455, 28);
            lblLast3.Name = "lblLast3";
            lblLast3.Size = new Size(127, 79);
            lblLast3.TabIndex = 13;
            lblLast3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLast2
            // 
            lblLast2.BackColor = Color.Yellow;
            lblLast2.BorderStyle = BorderStyle.FixedSingle;
            lblLast2.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblLast2.ForeColor = Color.Red;
            lblLast2.Location = new Point(323, 28);
            lblLast2.Name = "lblLast2";
            lblLast2.Size = new Size(126, 79);
            lblLast2.TabIndex = 12;
            lblLast2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLast1
            // 
            lblLast1.BackColor = Color.Yellow;
            lblLast1.BorderStyle = BorderStyle.FixedSingle;
            lblLast1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblLast1.ForeColor = Color.Red;
            lblLast1.Location = new Point(191, 28);
            lblLast1.Name = "lblLast1";
            lblLast1.Size = new Size(126, 79);
            lblLast1.TabIndex = 11;
            lblLast1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(14, 57);
            label9.Name = "label9";
            label9.Size = new Size(177, 24);
            label9.TabIndex = 10;
            label9.Text = "Últimos números:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1657, 1041);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Lotería Familiar";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridNumbers).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericWait).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnStart;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private NumericUpDown numericWait;
        private DataGridView dataGridNumbers;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Label lblBallsOut;
        private Label label3;
        private Button btnExit;
        private Button btnReset;
        private Label label8;
        private Label lblBallsIn;
        private Label label6;
        private Label label5;
        private Label lblLast5;
        private Label lblLast4;
        private Label lblLast3;
        private Label lblLast2;
        private Label lblLast1;
        private Label label9;
        private PictureBox pictureBox1;
        private Label lblCurrentNumber;
        private Panel panel5;
        private Button btnContinue;
    }
}