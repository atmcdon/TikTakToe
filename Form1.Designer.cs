namespace TikTakToe
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
            this.Grid = new System.Windows.Forms.TableLayoutPanel();
            this.gridBtn1 = new System.Windows.Forms.Button();
            this.gridBtn2 = new System.Windows.Forms.Button();
            this.gridBtn3 = new System.Windows.Forms.Button();
            this.gridBtn5 = new System.Windows.Forms.Button();
            this.gridBtn6 = new System.Windows.Forms.Button();
            this.gridBtn7 = new System.Windows.Forms.Button();
            this.gridBtn4 = new System.Windows.Forms.Button();
            this.gridBtn9 = new System.Windows.Forms.Button();
            this.gridBtn8 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlayerTies = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.displayBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.P2WinsLabel = new System.Windows.Forms.Label();
            this.P1WinsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Player2Label = new System.Windows.Forms.Label();
            this.playerInputName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Player1Label = new System.Windows.Forms.Label();
            this.restartBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.fullResetBtn = new System.Windows.Forms.Button();
            this.Grid.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.ColumnCount = 3;
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.Grid.Controls.Add(this.gridBtn1, 0, 0);
            this.Grid.Controls.Add(this.gridBtn2, 1, 0);
            this.Grid.Controls.Add(this.gridBtn3, 2, 0);
            this.Grid.Controls.Add(this.gridBtn5, 1, 1);
            this.Grid.Controls.Add(this.gridBtn6, 2, 1);
            this.Grid.Controls.Add(this.gridBtn7, 0, 2);
            this.Grid.Controls.Add(this.gridBtn4, 0, 1);
            this.Grid.Controls.Add(this.gridBtn9, 2, 2);
            this.Grid.Controls.Add(this.gridBtn8, 1, 2);
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.Name = "Grid";
            this.Grid.RowCount = 3;
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.Grid.Size = new System.Drawing.Size(255, 252);
            this.Grid.TabIndex = 0;
            this.Grid.Paint += new System.Windows.Forms.PaintEventHandler(this.Grid_Paint);
            // 
            // gridBtn1
            // 
            this.gridBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBtn1.Location = new System.Drawing.Point(3, 3);
            this.gridBtn1.Name = "gridBtn1";
            this.gridBtn1.Size = new System.Drawing.Size(79, 78);
            this.gridBtn1.TabIndex = 0;
            this.gridBtn1.UseVisualStyleBackColor = true;
            this.gridBtn1.Click += new System.EventHandler(this.gridBtn_Click);
            // 
            // gridBtn2
            // 
            this.gridBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBtn2.Location = new System.Drawing.Point(88, 3);
            this.gridBtn2.Name = "gridBtn2";
            this.gridBtn2.Size = new System.Drawing.Size(79, 78);
            this.gridBtn2.TabIndex = 1;
            this.gridBtn2.UseVisualStyleBackColor = true;
            this.gridBtn2.Click += new System.EventHandler(this.gridBtn_Click);
            // 
            // gridBtn3
            // 
            this.gridBtn3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBtn3.Location = new System.Drawing.Point(173, 3);
            this.gridBtn3.Name = "gridBtn3";
            this.gridBtn3.Size = new System.Drawing.Size(79, 78);
            this.gridBtn3.TabIndex = 2;
            this.gridBtn3.UseVisualStyleBackColor = true;
            this.gridBtn3.Click += new System.EventHandler(this.gridBtn_Click);
            // 
            // gridBtn5
            // 
            this.gridBtn5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBtn5.Location = new System.Drawing.Point(88, 87);
            this.gridBtn5.Name = "gridBtn5";
            this.gridBtn5.Size = new System.Drawing.Size(79, 78);
            this.gridBtn5.TabIndex = 4;
            this.gridBtn5.UseVisualStyleBackColor = true;
            this.gridBtn5.Click += new System.EventHandler(this.gridBtn_Click);
            // 
            // gridBtn6
            // 
            this.gridBtn6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBtn6.Location = new System.Drawing.Point(173, 87);
            this.gridBtn6.Name = "gridBtn6";
            this.gridBtn6.Size = new System.Drawing.Size(79, 78);
            this.gridBtn6.TabIndex = 5;
            this.gridBtn6.UseVisualStyleBackColor = true;
            this.gridBtn6.Click += new System.EventHandler(this.gridBtn_Click);
            // 
            // gridBtn7
            // 
            this.gridBtn7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBtn7.Location = new System.Drawing.Point(3, 171);
            this.gridBtn7.Name = "gridBtn7";
            this.gridBtn7.Size = new System.Drawing.Size(79, 78);
            this.gridBtn7.TabIndex = 8;
            this.gridBtn7.UseVisualStyleBackColor = true;
            this.gridBtn7.Click += new System.EventHandler(this.gridBtn_Click);
            // 
            // gridBtn4
            // 
            this.gridBtn4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBtn4.Location = new System.Drawing.Point(3, 87);
            this.gridBtn4.Name = "gridBtn4";
            this.gridBtn4.Size = new System.Drawing.Size(79, 78);
            this.gridBtn4.TabIndex = 3;
            this.gridBtn4.UseVisualStyleBackColor = true;
            this.gridBtn4.Click += new System.EventHandler(this.gridBtn_Click);
            // 
            // gridBtn9
            // 
            this.gridBtn9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBtn9.Location = new System.Drawing.Point(173, 171);
            this.gridBtn9.Name = "gridBtn9";
            this.gridBtn9.Size = new System.Drawing.Size(79, 78);
            this.gridBtn9.TabIndex = 6;
            this.gridBtn9.UseVisualStyleBackColor = true;
            this.gridBtn9.Click += new System.EventHandler(this.gridBtn_Click);
            // 
            // gridBtn8
            // 
            this.gridBtn8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBtn8.Location = new System.Drawing.Point(88, 171);
            this.gridBtn8.Name = "gridBtn8";
            this.gridBtn8.Size = new System.Drawing.Size(79, 78);
            this.gridBtn8.TabIndex = 7;
            this.gridBtn8.UseVisualStyleBackColor = true;
            this.gridBtn8.Click += new System.EventHandler(this.gridBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(255, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(196, 252);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fullResetBtn);
            this.panel1.Controls.Add(this.PlayerTies);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.displayBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.P2WinsLabel);
            this.panel1.Controls.Add(this.P1WinsLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Player2Label);
            this.panel1.Controls.Add(this.playerInputName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Player1Label);
            this.panel1.Controls.Add(this.restartBtn);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 246);
            this.panel1.TabIndex = 0;
            // 
            // PlayerTies
            // 
            this.PlayerTies.AutoSize = true;
            this.PlayerTies.Location = new System.Drawing.Point(81, 87);
            this.PlayerTies.Name = "PlayerTies";
            this.PlayerTies.Size = new System.Drawing.Size(13, 13);
            this.PlayerTies.TabIndex = 14;
            this.PlayerTies.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "    is   O";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "    is   X";
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(17, 165);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(157, 28);
            this.displayBox.TabIndex = 11;
            this.displayBox.Text = "Press start to Play";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Game Ties";
            
            // 
            // P2WinsLabel
            // 
            this.P2WinsLabel.AutoSize = true;
            this.P2WinsLabel.Location = new System.Drawing.Point(126, 55);
            this.P2WinsLabel.Name = "P2WinsLabel";
            this.P2WinsLabel.Size = new System.Drawing.Size(13, 13);
            this.P2WinsLabel.TabIndex = 8;
            this.P2WinsLabel.Text = "0";
            // 
            // P1WinsLabel
            // 
            this.P1WinsLabel.AutoSize = true;
            this.P1WinsLabel.Location = new System.Drawing.Point(126, 29);
            this.P1WinsLabel.Name = "P1WinsLabel";
            this.P1WinsLabel.Size = new System.Drawing.Size(13, 13);
            this.P1WinsLabel.TabIndex = 7;
            this.P1WinsLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wins";
            // 
            // Player2Label
            // 
            this.Player2Label.AutoSize = true;
            this.Player2Label.Location = new System.Drawing.Point(17, 55);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(55, 13);
            this.Player2Label.TabIndex = 5;
            this.Player2Label.Text = "Computer ";
            // 
            // playerInputName
            // 
            this.playerInputName.Location = new System.Drawing.Point(17, 129);
            this.playerInputName.Name = "playerInputName";
            this.playerInputName.Size = new System.Drawing.Size(100, 20);
            this.playerInputName.TabIndex = 4;
            this.playerInputName.Text = "Player 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Player Name";
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Location = new System.Drawing.Point(17, 29);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(45, 13);
            this.Player1Label.TabIndex = 2;
            this.Player1Label.Text = "Player 1";
            // 
            // restartBtn
            // 
            this.restartBtn.Location = new System.Drawing.Point(71, 199);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(46, 41);
            this.restartBtn.TabIndex = 1;
            this.restartBtn.Text = "New Game";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(17, 199);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(45, 41);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // fullResetBtn
            // 
            this.fullResetBtn.Location = new System.Drawing.Point(129, 200);
            this.fullResetBtn.Name = "fullResetBtn";
            this.fullResetBtn.Size = new System.Drawing.Size(44, 37);
            this.fullResetBtn.TabIndex = 15;
            this.fullResetBtn.Text = "Reset";
            this.fullResetBtn.UseVisualStyleBackColor = true;
            this.fullResetBtn.Click += new System.EventHandler(this.fullResetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 252);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(467, 291);
            this.Name = "Form1";
            this.Text = "Tik Tac Toe";
            this.Grid.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Grid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Button gridBtn1;
        private System.Windows.Forms.Button gridBtn2;
        private System.Windows.Forms.Button gridBtn3;
        private System.Windows.Forms.Button gridBtn7;
        private System.Windows.Forms.Button gridBtn8;
        private System.Windows.Forms.Button gridBtn9;
        private System.Windows.Forms.Button gridBtn4;
        private System.Windows.Forms.Button gridBtn5;
        private System.Windows.Forms.Button gridBtn6;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.TextBox playerInputName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label P2WinsLabel;
        private System.Windows.Forms.Label P1WinsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Player2Label;
        private System.Windows.Forms.RichTextBox displayBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PlayerTies;
        private System.Windows.Forms.Button fullResetBtn;
    }
}

