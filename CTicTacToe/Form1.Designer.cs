
namespace CTicTacToe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPlayerO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayerX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.restartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.newGameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.newGameToolStripMenuItem.Text = "Play Again";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.infoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.infoToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.restartToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.restartToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.restartToolStripMenuItem.Text = "New Game";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.RestartToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.Controls.Add(this.b9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.b8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.b7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.b6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.b5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.b4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.b3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.b2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.b1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1382, 625);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.PowderBlue;
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(397, 419);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(190, 202);
            this.b9.TabIndex = 8;
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.Button_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.PowderBlue;
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(200, 419);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(190, 202);
            this.b8.TabIndex = 7;
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.Button_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.PowderBlue;
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(3, 419);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(190, 202);
            this.b7.TabIndex = 6;
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.Button_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.PowderBlue;
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(397, 211);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(190, 202);
            this.b6.TabIndex = 5;
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.Button_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.PowderBlue;
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(200, 211);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(190, 202);
            this.b5.TabIndex = 4;
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.Button_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.PowderBlue;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(3, 211);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(190, 202);
            this.b4.TabIndex = 3;
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.Button_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.PowderBlue;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(397, 3);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(190, 202);
            this.b3.TabIndex = 2;
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.Button_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.PowderBlue;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(200, 3);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(190, 202);
            this.b2.TabIndex = 1;
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.Button_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.PowderBlue;
            this.b1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b1.FlatAppearance.BorderSize = 5;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(3, 3);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(190, 202);
            this.b1.TabIndex = 0;
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.Button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(594, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 202);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(1, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 72);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tic Tac Toe";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPlayerO);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblPlayerX);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(594, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 202);
            this.panel2.TabIndex = 10;
            // 
            // lblPlayerO
            // 
            this.lblPlayerO.AutoSize = true;
            this.lblPlayerO.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerO.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlayerO.Location = new System.Drawing.Point(208, 135);
            this.lblPlayerO.Name = "lblPlayerO";
            this.lblPlayerO.Size = new System.Drawing.Size(41, 44);
            this.lblPlayerO.TabIndex = 4;
            this.lblPlayerO.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 55);
            this.label2.TabIndex = 5;
            this.label2.Text = "ScoreBoard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(23, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player O:";
            // 
            // lblPlayerX
            // 
            this.lblPlayerX.AutoSize = true;
            this.lblPlayerX.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlayerX.Location = new System.Drawing.Point(208, 81);
            this.lblPlayerX.Name = "lblPlayerX";
            this.lblPlayerX.Size = new System.Drawing.Size(41, 44);
            this.lblPlayerX.TabIndex = 3;
            this.lblPlayerX.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(23, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player X:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(594, 419);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 202);
            this.panel3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(107, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "https://tildakallstrom.se";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(58, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "This game is created by Tilda Källström. ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(988, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(391, 202);
            this.panel4.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(21, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(336, 72);
            this.label10.TabIndex = 7;
            this.label10.Text = "Guestbook";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(3, 208);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(391, 202);
            this.panel5.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(30, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(33, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtMessage);
            this.panel6.Controls.Add(this.BtnUpdate);
            this.panel6.Controls.Add(this.txtName);
            this.panel6.Controls.Add(this.BtnDelete);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.BtnAdd);
            this.panel6.Location = new System.Drawing.Point(988, 211);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(391, 202);
            this.panel6.TabIndex = 13;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(38, 67);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(320, 88);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.Text = "";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnUpdate.Location = new System.Drawing.Point(273, 170);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(85, 32);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(38, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(320, 22);
            this.txtName.TabIndex = 2;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnDelete.Location = new System.Drawing.Point(156, 170);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(85, 32);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(33, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Message:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAdd.Location = new System.Drawing.Point(38, 170);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(85, 32);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgv);
            this.panel7.Location = new System.Drawing.Point(988, 419);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(391, 203);
            this.panel7.TabIndex = 14;
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.message});
            this.dgv.Location = new System.Drawing.Point(3, 13);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(385, 187);
            this.dgv.TabIndex = 3;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // message
            // 
            this.message.HeaderText = "Message";
            this.message.MinimumWidth = 6;
            this.message.Name = "message";
            this.message.Width = 180;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1400, 1000);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPlayerO;
        private System.Windows.Forms.Label lblPlayerX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.Label label10;
    }
}

