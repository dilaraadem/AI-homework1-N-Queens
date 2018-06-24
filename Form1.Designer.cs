namespace AI_hw1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label heuristicLbl;
            System.Windows.Forms.Label lblStep;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbBxSize = new System.Windows.Forms.ComboBox();
            this.SetBtn = new System.Windows.Forms.Button();
            this.stepCount = new System.Windows.Forms.Label();
            this.sizeOfBoard = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.lblHeuNum = new System.Windows.Forms.Label();
            this.lblAlgo = new System.Windows.Forms.Label();
            this.queen5 = new System.Windows.Forms.PictureBox();
            this.queen3 = new System.Windows.Forms.PictureBox();
            this.queen4 = new System.Windows.Forms.PictureBox();
            this.queen8 = new System.Windows.Forms.PictureBox();
            this.queen7 = new System.Windows.Forms.PictureBox();
            this.queen6 = new System.Windows.Forms.PictureBox();
            this.queen2 = new System.Windows.Forms.PictureBox();
            this.queen1 = new System.Windows.Forms.PictureBox();
            this.GAParamPanel = new System.Windows.Forms.Panel();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCrossO = new System.Windows.Forms.Label();
            this.lblGens = new System.Windows.Forms.Label();
            this.LblPopSize = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStates = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.HCpanel = new System.Windows.Forms.Panel();
            this.numericUpDownHC = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            heuristicLbl = new System.Windows.Forms.Label();
            lblStep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.queen5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen1)).BeginInit();
            this.GAParamPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.HCpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // heuristicLbl
            // 
            heuristicLbl.AutoSize = true;
            heuristicLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            heuristicLbl.Location = new System.Drawing.Point(517, 81);
            heuristicLbl.Name = "heuristicLbl";
            heuristicLbl.Size = new System.Drawing.Size(74, 17);
            heuristicLbl.TabIndex = 4;
            heuristicLbl.Text = "Heuristics:";
            // 
            // lblStep
            // 
            lblStep.AutoSize = true;
            lblStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            lblStep.Location = new System.Drawing.Point(517, 107);
            lblStep.Name = "lblStep";
            lblStep.Size = new System.Drawing.Size(48, 17);
            lblStep.TabIndex = 8;
            lblStep.Text = "Steps:";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hill Climbing",
            "Simulated Annealing",
            "Local Beam Search",
            "Genetic Algorithm"});
            this.comboBox1.Location = new System.Drawing.Point(594, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // cmbBxSize
            // 
            this.cmbBxSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbBxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxSize.FormattingEnabled = true;
            this.cmbBxSize.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbBxSize.Location = new System.Drawing.Point(594, 21);
            this.cmbBxSize.Name = "cmbBxSize";
            this.cmbBxSize.Size = new System.Drawing.Size(79, 21);
            this.cmbBxSize.TabIndex = 1;
            // 
            // SetBtn
            // 
            this.SetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SetBtn.Location = new System.Drawing.Point(582, 472);
            this.SetBtn.Name = "SetBtn";
            this.SetBtn.Size = new System.Drawing.Size(75, 23);
            this.SetBtn.TabIndex = 2;
            this.SetBtn.Text = "Set";
            this.SetBtn.UseVisualStyleBackColor = true;
            this.SetBtn.Click += new System.EventHandler(this.SetBtn_Click);
            // 
            // stepCount
            // 
            this.stepCount.AutoSize = true;
            this.stepCount.Location = new System.Drawing.Point(610, 111);
            this.stepCount.Name = "stepCount";
            this.stepCount.Size = new System.Drawing.Size(13, 13);
            this.stepCount.TabIndex = 7;
            this.stepCount.Text = "0";
            // 
            // sizeOfBoard
            // 
            this.sizeOfBoard.AutoSize = true;
            this.sizeOfBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sizeOfBoard.Location = new System.Drawing.Point(517, 22);
            this.sizeOfBoard.Name = "sizeOfBoard";
            this.sizeOfBoard.Size = new System.Drawing.Size(39, 17);
            this.sizeOfBoard.TabIndex = 9;
            this.sizeOfBoard.Text = "Size:";
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clearBtn.Location = new System.Drawing.Point(665, 472);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // lblHeuNum
            // 
            this.lblHeuNum.AutoSize = true;
            this.lblHeuNum.Location = new System.Drawing.Point(610, 85);
            this.lblHeuNum.Name = "lblHeuNum";
            this.lblHeuNum.Size = new System.Drawing.Size(13, 13);
            this.lblHeuNum.TabIndex = 11;
            this.lblHeuNum.Text = "0";
            // 
            // lblAlgo
            // 
            this.lblAlgo.AutoSize = true;
            this.lblAlgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAlgo.Location = new System.Drawing.Point(517, 48);
            this.lblAlgo.Name = "lblAlgo";
            this.lblAlgo.Size = new System.Drawing.Size(71, 17);
            this.lblAlgo.TabIndex = 12;
            this.lblAlgo.Text = "Algorithm:";
            // 
            // queen5
            // 
            this.queen5.Image = ((System.Drawing.Image)(resources.GetObject("queen5.Image")));
            this.queen5.Location = new System.Drawing.Point(524, 405);
            this.queen5.Name = "queen5";
            this.queen5.Size = new System.Drawing.Size(51, 44);
            this.queen5.TabIndex = 13;
            this.queen5.TabStop = false;
            this.queen5.Visible = false;
            // 
            // queen3
            // 
            this.queen3.Image = ((System.Drawing.Image)(resources.GetObject("queen3.Image")));
            this.queen3.Location = new System.Drawing.Point(638, 386);
            this.queen3.Name = "queen3";
            this.queen3.Size = new System.Drawing.Size(51, 44);
            this.queen3.TabIndex = 14;
            this.queen3.TabStop = false;
            this.queen3.Visible = false;
            // 
            // queen4
            // 
            this.queen4.Image = ((System.Drawing.Image)(resources.GetObject("queen4.Image")));
            this.queen4.Location = new System.Drawing.Point(695, 386);
            this.queen4.Name = "queen4";
            this.queen4.Size = new System.Drawing.Size(51, 44);
            this.queen4.TabIndex = 15;
            this.queen4.TabStop = false;
            this.queen4.Visible = false;
            // 
            // queen8
            // 
            this.queen8.Image = ((System.Drawing.Image)(resources.GetObject("queen8.Image")));
            this.queen8.Location = new System.Drawing.Point(695, 405);
            this.queen8.Name = "queen8";
            this.queen8.Size = new System.Drawing.Size(51, 44);
            this.queen8.TabIndex = 16;
            this.queen8.TabStop = false;
            this.queen8.Visible = false;
            // 
            // queen7
            // 
            this.queen7.Image = ((System.Drawing.Image)(resources.GetObject("queen7.Image")));
            this.queen7.Location = new System.Drawing.Point(638, 405);
            this.queen7.Name = "queen7";
            this.queen7.Size = new System.Drawing.Size(51, 44);
            this.queen7.TabIndex = 17;
            this.queen7.TabStop = false;
            this.queen7.Visible = false;
            // 
            // queen6
            // 
            this.queen6.Image = ((System.Drawing.Image)(resources.GetObject("queen6.Image")));
            this.queen6.Location = new System.Drawing.Point(581, 405);
            this.queen6.Name = "queen6";
            this.queen6.Size = new System.Drawing.Size(51, 44);
            this.queen6.TabIndex = 18;
            this.queen6.TabStop = false;
            this.queen6.Visible = false;
            // 
            // queen2
            // 
            this.queen2.Image = ((System.Drawing.Image)(resources.GetObject("queen2.Image")));
            this.queen2.Location = new System.Drawing.Point(581, 386);
            this.queen2.Name = "queen2";
            this.queen2.Size = new System.Drawing.Size(51, 44);
            this.queen2.TabIndex = 19;
            this.queen2.TabStop = false;
            this.queen2.Visible = false;
            // 
            // queen1
            // 
            this.queen1.Image = ((System.Drawing.Image)(resources.GetObject("queen1.Image")));
            this.queen1.Location = new System.Drawing.Point(524, 386);
            this.queen1.Name = "queen1";
            this.queen1.Size = new System.Drawing.Size(51, 44);
            this.queen1.TabIndex = 20;
            this.queen1.TabStop = false;
            this.queen1.Visible = false;
            // 
            // GAParamPanel
            // 
            this.GAParamPanel.Controls.Add(this.numericUpDown5);
            this.GAParamPanel.Controls.Add(this.label6);
            this.GAParamPanel.Controls.Add(this.numericUpDown4);
            this.GAParamPanel.Controls.Add(this.numericUpDown3);
            this.GAParamPanel.Controls.Add(this.numericUpDown2);
            this.GAParamPanel.Controls.Add(this.numericUpDown1);
            this.GAParamPanel.Controls.Add(this.label2);
            this.GAParamPanel.Controls.Add(this.lblCrossO);
            this.GAParamPanel.Controls.Add(this.lblGens);
            this.GAParamPanel.Controls.Add(this.LblPopSize);
            this.GAParamPanel.Location = new System.Drawing.Point(506, 219);
            this.GAParamPanel.Name = "GAParamPanel";
            this.GAParamPanel.Size = new System.Drawing.Size(249, 161);
            this.GAParamPanel.TabIndex = 22;
            this.GAParamPanel.Visible = false;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 2;
            this.numericUpDown4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown4.Location = new System.Drawing.Point(121, 79);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown4.TabIndex = 7;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown3.Location = new System.Drawing.Point(121, 56);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 6;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(121, 33);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(120, 11);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mutation Probability:";
            // 
            // lblCrossO
            // 
            this.lblCrossO.AutoSize = true;
            this.lblCrossO.Location = new System.Drawing.Point(12, 59);
            this.lblCrossO.Name = "lblCrossO";
            this.lblCrossO.Size = new System.Drawing.Size(106, 13);
            this.lblCrossO.TabIndex = 2;
            this.lblCrossO.Text = "Crossover Probablity:";
            // 
            // lblGens
            // 
            this.lblGens.AutoSize = true;
            this.lblGens.Location = new System.Drawing.Point(12, 36);
            this.lblGens.Name = "lblGens";
            this.lblGens.Size = new System.Drawing.Size(67, 13);
            this.lblGens.TabIndex = 1;
            this.lblGens.Text = "Generations:";
            // 
            // LblPopSize
            // 
            this.LblPopSize.AutoSize = true;
            this.LblPopSize.Location = new System.Drawing.Point(12, 13);
            this.LblPopSize.Name = "LblPopSize";
            this.LblPopSize.Size = new System.Drawing.Size(83, 13);
            this.LblPopSize.TabIndex = 0;
            this.LblPopSize.Text = "Population Size:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(506, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 73);
            this.panel1.TabIndex = 23;
            this.panel1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cooling Factor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Starting Temperature:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStates);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Location = new System.Drawing.Point(509, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 64);
            this.panel2.TabIndex = 24;
            this.panel2.Visible = false;
            // 
            // lblStates
            // 
            this.lblStates.AutoSize = true;
            this.lblStates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStates.Location = new System.Drawing.Point(14, 20);
            this.lblStates.Name = "lblStates";
            this.lblStates.Size = new System.Drawing.Size(105, 15);
            this.lblStates.TabIndex = 1;
            this.lblStates.Text = "Number of States:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 17);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(106, 20);
            this.textBox3.TabIndex = 0;
            // 
            // HCpanel
            // 
            this.HCpanel.Controls.Add(this.numericUpDownHC);
            this.HCpanel.Controls.Add(this.label5);
            this.HCpanel.Location = new System.Drawing.Point(501, 174);
            this.HCpanel.Name = "HCpanel";
            this.HCpanel.Size = new System.Drawing.Size(286, 54);
            this.HCpanel.TabIndex = 25;
            this.HCpanel.Visible = false;
            // 
            // numericUpDownHC
            // 
            this.numericUpDownHC.Location = new System.Drawing.Point(171, 19);
            this.numericUpDownHC.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownHC.Name = "numericUpDownHC";
            this.numericUpDownHC.Size = new System.Drawing.Size(97, 20);
            this.numericUpDownHC.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(17, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Max Number of Iterations:";
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Start.Location = new System.Drawing.Point(501, 472);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 26;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(517, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Parameters:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Percent of Elitism: ";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 2;
            this.numericUpDown5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown5.Location = new System.Drawing.Point(121, 101);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown5.TabIndex = 9;
            this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(805, 523);
            this.Controls.Add(this.GAParamPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.queen1);
            this.Controls.Add(this.queen2);
            this.Controls.Add(this.queen6);
            this.Controls.Add(this.queen7);
            this.Controls.Add(this.queen8);
            this.Controls.Add(this.queen4);
            this.Controls.Add(this.queen3);
            this.Controls.Add(this.queen5);
            this.Controls.Add(this.lblAlgo);
            this.Controls.Add(this.lblHeuNum);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.sizeOfBoard);
            this.Controls.Add(lblStep);
            this.Controls.Add(this.stepCount);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(heuristicLbl);
            this.Controls.Add(this.SetBtn);
            this.Controls.Add(this.cmbBxSize);
            this.Controls.Add(this.HCpanel);
            this.Name = "Form1";
            this.Text = "N-Queens Problem, AI Assignment1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.queen5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen1)).EndInit();
            this.GAParamPanel.ResumeLayout(false);
            this.GAParamPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.HCpanel.ResumeLayout(false);
            this.HCpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbBxSize;
        private System.Windows.Forms.Button SetBtn;
        private System.Windows.Forms.Label stepCount;
        private System.Windows.Forms.Label sizeOfBoard;
        private System.Windows.Forms.Button clearBtn;
        public System.Windows.Forms.Label lblHeuNum;
        private System.Windows.Forms.Label lblAlgo;
        public System.Windows.Forms.PictureBox queen5;
        public System.Windows.Forms.PictureBox queen3;
        public System.Windows.Forms.PictureBox queen4;
        public System.Windows.Forms.PictureBox queen8;
        public System.Windows.Forms.PictureBox queen7;
        public System.Windows.Forms.PictureBox queen6;
        public System.Windows.Forms.PictureBox queen2;
        public System.Windows.Forms.PictureBox queen1;
        private System.Windows.Forms.Panel GAParamPanel;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCrossO;
        private System.Windows.Forms.Label lblGens;
        private System.Windows.Forms.Label LblPopSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStates;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel HCpanel;
        private System.Windows.Forms.NumericUpDown numericUpDownHC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
    }
}

