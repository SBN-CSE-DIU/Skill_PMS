﻿namespace Skill_PMS.UI_WinForm.Production.QC_Panel
{
    partial class QC_Process
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QC_Process));
            this.Pnl_Counter = new System.Windows.Forms.Panel();
            this.Lbl_Job_Time = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Lbl_Count = new System.Windows.Forms.Label();
            this.Btn_Pause = new System.Windows.Forms.Button();
            this.DGV_Files = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tmr_Count = new System.Windows.Forms.Timer(this.components);
            this.Btn_Instruction = new System.Windows.Forms.Button();
            this.Btn_My_Folder = new System.Windows.Forms.Button();
            this.Btn_Ready_Folder = new System.Windows.Forms.Button();
            this.Btn_Job_Folder = new System.Windows.Forms.Button();
            this.Btn_100 = new System.Windows.Forms.Button();
            this.Btn_90 = new System.Windows.Forms.Button();
            this.Btn_80 = new System.Windows.Forms.Button();
            this.Btn_60 = new System.Windows.Forms.Button();
            this.Btn_70 = new System.Windows.Forms.Button();
            this.Btn_50 = new System.Windows.Forms.Button();
            this.Txt_File = new System.Windows.Forms.TextBox();
            this.Btn_Find = new System.Windows.Forms.Button();
            this.Tmr_Open = new System.Windows.Forms.Timer(this.components);
            this.Tmr_Save = new System.Windows.Forms.Timer(this.components);
            this.Pnl_Counter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Files)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Counter
            // 
            this.Pnl_Counter.Controls.Add(this.Lbl_Job_Time);
            this.Pnl_Counter.Controls.Add(this.Btn_Cancel);
            this.Pnl_Counter.Controls.Add(this.Btn_Save);
            this.Pnl_Counter.Controls.Add(this.Lbl_Count);
            this.Pnl_Counter.Controls.Add(this.Btn_Pause);
            this.Pnl_Counter.Location = new System.Drawing.Point(2, 729);
            this.Pnl_Counter.Name = "Pnl_Counter";
            this.Pnl_Counter.Size = new System.Drawing.Size(376, 41);
            this.Pnl_Counter.TabIndex = 425;
            // 
            // Lbl_Job_Time
            // 
            this.Lbl_Job_Time.AutoSize = true;
            this.Lbl_Job_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Lbl_Job_Time.Location = new System.Drawing.Point(1, 7);
            this.Lbl_Job_Time.Name = "Lbl_Job_Time";
            this.Lbl_Job_Time.Size = new System.Drawing.Size(126, 26);
            this.Lbl_Job_Time.TabIndex = 399;
            this.Lbl_Job_Time.Text = "Time  00:00";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_Cancel.Enabled = false;
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.Location = new System.Drawing.Point(138, 3);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(76, 35);
            this.Btn_Cancel.TabIndex = 398;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Save.Enabled = false;
            this.Btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Location = new System.Drawing.Point(296, 3);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(76, 35);
            this.Btn_Save.TabIndex = 395;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Lbl_Count
            // 
            this.Lbl_Count.AutoSize = true;
            this.Lbl_Count.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Count.ForeColor = System.Drawing.Color.Purple;
            this.Lbl_Count.Location = new System.Drawing.Point(-121, 42);
            this.Lbl_Count.Name = "Lbl_Count";
            this.Lbl_Count.Size = new System.Drawing.Size(130, 39);
            this.Lbl_Count.TabIndex = 397;
            this.Lbl_Count.Text = "0:00:00";
            // 
            // Btn_Pause
            // 
            this.Btn_Pause.Enabled = false;
            this.Btn_Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pause.Location = new System.Drawing.Point(215, 3);
            this.Btn_Pause.Name = "Btn_Pause";
            this.Btn_Pause.Size = new System.Drawing.Size(80, 35);
            this.Btn_Pause.TabIndex = 396;
            this.Btn_Pause.Text = "Pause";
            this.Btn_Pause.UseVisualStyleBackColor = true;
            this.Btn_Pause.Click += new System.EventHandler(this.Btn_Pause_Click);
            // 
            // DGV_Files
            // 
            this.DGV_Files.AllowDrop = true;
            this.DGV_Files.AllowUserToAddRows = false;
            this.DGV_Files.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Files.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Files.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGV_Files.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Files.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Files.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn33});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Files.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Files.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGV_Files.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGV_Files.Location = new System.Drawing.Point(10, 47);
            this.DGV_Files.Name = "DGV_Files";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Files.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Files.RowHeadersVisible = false;
            this.DGV_Files.RowHeadersWidth = 30;
            this.DGV_Files.RowTemplate.Height = 30;
            this.DGV_Files.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Files.Size = new System.Drawing.Size(360, 610);
            this.DGV_Files.TabIndex = 420;
            this.DGV_Files.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Files_CellContentClick);
            this.DGV_Files.DragDrop += new System.Windows.Forms.DragEventHandler(this.DGV_Files_DragDrop);
            this.DGV_Files.DragEnter += new System.Windows.Forms.DragEventHandler(this.DGV_Files_DragEnter);
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.HeaderText = "SL";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Width = 35;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn31.HeaderText = "Image_Name";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.HeaderText = "X";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.Width = 35;
            // 
            // Tmr_Count
            // 
            this.Tmr_Count.Interval = 1000;
            this.Tmr_Count.Tick += new System.EventHandler(this.Tmr_Count_Tick);
            // 
            // Btn_Instruction
            // 
            this.Btn_Instruction.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Instruction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Instruction.BackgroundImage")));
            this.Btn_Instruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Instruction.FlatAppearance.BorderSize = 0;
            this.Btn_Instruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Instruction.Location = new System.Drawing.Point(4, 11);
            this.Btn_Instruction.Name = "Btn_Instruction";
            this.Btn_Instruction.Size = new System.Drawing.Size(40, 30);
            this.Btn_Instruction.TabIndex = 411;
            this.Btn_Instruction.UseVisualStyleBackColor = false;
            this.Btn_Instruction.Click += new System.EventHandler(this.Btn_Instruction_Click);
            // 
            // Btn_My_Folder
            // 
            this.Btn_My_Folder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_My_Folder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_My_Folder.BackgroundImage")));
            this.Btn_My_Folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_My_Folder.Enabled = false;
            this.Btn_My_Folder.FlatAppearance.BorderSize = 0;
            this.Btn_My_Folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_My_Folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_My_Folder.Location = new System.Drawing.Point(295, 11);
            this.Btn_My_Folder.Name = "Btn_My_Folder";
            this.Btn_My_Folder.Size = new System.Drawing.Size(40, 30);
            this.Btn_My_Folder.TabIndex = 410;
            this.Btn_My_Folder.UseVisualStyleBackColor = false;
            this.Btn_My_Folder.Click += new System.EventHandler(this.Btn_My_Folder_Click);
            // 
            // Btn_Ready_Folder
            // 
            this.Btn_Ready_Folder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Ready_Folder.BackgroundImage")));
            this.Btn_Ready_Folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Ready_Folder.Enabled = false;
            this.Btn_Ready_Folder.FlatAppearance.BorderSize = 0;
            this.Btn_Ready_Folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ready_Folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ready_Folder.Location = new System.Drawing.Point(333, 11);
            this.Btn_Ready_Folder.Name = "Btn_Ready_Folder";
            this.Btn_Ready_Folder.Size = new System.Drawing.Size(40, 30);
            this.Btn_Ready_Folder.TabIndex = 409;
            this.Btn_Ready_Folder.UseVisualStyleBackColor = true;
            this.Btn_Ready_Folder.Click += new System.EventHandler(this.Btn_Ready_Folder_Click);
            // 
            // Btn_Job_Folder
            // 
            this.Btn_Job_Folder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Job_Folder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Job_Folder.BackgroundImage")));
            this.Btn_Job_Folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Job_Folder.FlatAppearance.BorderSize = 0;
            this.Btn_Job_Folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Job_Folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Job_Folder.Location = new System.Drawing.Point(45, 11);
            this.Btn_Job_Folder.Name = "Btn_Job_Folder";
            this.Btn_Job_Folder.Size = new System.Drawing.Size(40, 30);
            this.Btn_Job_Folder.TabIndex = 408;
            this.Btn_Job_Folder.UseVisualStyleBackColor = false;
            this.Btn_Job_Folder.Click += new System.EventHandler(this.Btn_Job_Folder_Click);
            // 
            // Btn_100
            // 
            this.Btn_100.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_100.Enabled = false;
            this.Btn_100.FlatAppearance.BorderSize = 0;
            this.Btn_100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_100.Location = new System.Drawing.Point(8, 697);
            this.Btn_100.Name = "Btn_100";
            this.Btn_100.Size = new System.Drawing.Size(60, 30);
            this.Btn_100.TabIndex = 399;
            this.Btn_100.Text = "100%";
            this.Btn_100.UseVisualStyleBackColor = false;
            this.Btn_100.Click += new System.EventHandler(this.Btn_100_Click);
            // 
            // Btn_90
            // 
            this.Btn_90.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_90.Enabled = false;
            this.Btn_90.FlatAppearance.BorderSize = 0;
            this.Btn_90.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_90.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_90.Location = new System.Drawing.Point(69, 697);
            this.Btn_90.Name = "Btn_90";
            this.Btn_90.Size = new System.Drawing.Size(60, 30);
            this.Btn_90.TabIndex = 427;
            this.Btn_90.Text = "90%";
            this.Btn_90.UseVisualStyleBackColor = false;
            this.Btn_90.Click += new System.EventHandler(this.Btn_95_Click);
            // 
            // Btn_80
            // 
            this.Btn_80.BackColor = System.Drawing.Color.Khaki;
            this.Btn_80.Enabled = false;
            this.Btn_80.FlatAppearance.BorderSize = 0;
            this.Btn_80.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_80.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_80.Location = new System.Drawing.Point(130, 697);
            this.Btn_80.Name = "Btn_80";
            this.Btn_80.Size = new System.Drawing.Size(60, 30);
            this.Btn_80.TabIndex = 428;
            this.Btn_80.Text = "80%";
            this.Btn_80.UseVisualStyleBackColor = false;
            this.Btn_80.Click += new System.EventHandler(this.Btn_90_Click);
            // 
            // Btn_60
            // 
            this.Btn_60.BackColor = System.Drawing.Color.LightSalmon;
            this.Btn_60.Enabled = false;
            this.Btn_60.FlatAppearance.BorderSize = 0;
            this.Btn_60.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_60.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_60.Location = new System.Drawing.Point(252, 697);
            this.Btn_60.Name = "Btn_60";
            this.Btn_60.Size = new System.Drawing.Size(60, 30);
            this.Btn_60.TabIndex = 429;
            this.Btn_60.Text = "60%";
            this.Btn_60.UseVisualStyleBackColor = false;
            this.Btn_60.Click += new System.EventHandler(this.Btn_80_Click);
            // 
            // Btn_70
            // 
            this.Btn_70.BackColor = System.Drawing.Color.Moccasin;
            this.Btn_70.Enabled = false;
            this.Btn_70.FlatAppearance.BorderSize = 0;
            this.Btn_70.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_70.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_70.Location = new System.Drawing.Point(191, 697);
            this.Btn_70.Name = "Btn_70";
            this.Btn_70.Size = new System.Drawing.Size(60, 30);
            this.Btn_70.TabIndex = 430;
            this.Btn_70.Text = "70%";
            this.Btn_70.UseVisualStyleBackColor = false;
            this.Btn_70.Click += new System.EventHandler(this.Btn_85_Click);
            // 
            // Btn_50
            // 
            this.Btn_50.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_50.Enabled = false;
            this.Btn_50.FlatAppearance.BorderSize = 0;
            this.Btn_50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_50.Location = new System.Drawing.Point(313, 697);
            this.Btn_50.Name = "Btn_50";
            this.Btn_50.Size = new System.Drawing.Size(60, 30);
            this.Btn_50.TabIndex = 431;
            this.Btn_50.Text = "50%";
            this.Btn_50.UseVisualStyleBackColor = false;
            this.Btn_50.Click += new System.EventHandler(this.Btn_75_Click);
            // 
            // Txt_File
            // 
            this.Txt_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_File.Location = new System.Drawing.Point(7, 664);
            this.Txt_File.Name = "Txt_File";
            this.Txt_File.Size = new System.Drawing.Size(247, 26);
            this.Txt_File.TabIndex = 433;
            this.Txt_File.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_Find
            // 
            this.Btn_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Btn_Find.Location = new System.Drawing.Point(255, 662);
            this.Btn_Find.Name = "Btn_Find";
            this.Btn_Find.Size = new System.Drawing.Size(120, 30);
            this.Btn_Find.TabIndex = 399;
            this.Btn_Find.Text = "Find Data";
            this.Btn_Find.UseVisualStyleBackColor = true;
            this.Btn_Find.Click += new System.EventHandler(this.Btn_Find_Click);
            // 
            // Tmr_Open
            // 
            this.Tmr_Open.Interval = 1;
            this.Tmr_Open.Tick += new System.EventHandler(this.Tmr_Open_Tick);
            // 
            // Tmr_Save
            // 
            this.Tmr_Save.Interval = 1;
            this.Tmr_Save.Tick += new System.EventHandler(this.Tmr_Save_Tick);
            // 
            // QC_Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(380, 772);
            this.Controls.Add(this.Btn_Find);
            this.Controls.Add(this.Txt_File);
            this.Controls.Add(this.Btn_50);
            this.Controls.Add(this.Btn_70);
            this.Controls.Add(this.Btn_60);
            this.Controls.Add(this.Btn_80);
            this.Controls.Add(this.Btn_90);
            this.Controls.Add(this.Btn_100);
            this.Controls.Add(this.Btn_Instruction);
            this.Controls.Add(this.Pnl_Counter);
            this.Controls.Add(this.Btn_My_Folder);
            this.Controls.Add(this.Btn_Ready_Folder);
            this.Controls.Add(this.DGV_Files);
            this.Controls.Add(this.Btn_Job_Folder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.Name = "QC_Process";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Processing";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QC_Process_FormClosed);
            this.Load += new System.EventHandler(this.QC_Process_Load);
            this.Resize += new System.EventHandler(this.QC_Process_Resize);
            this.Pnl_Counter.ResumeLayout(false);
            this.Pnl_Counter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Files)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Counter;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label Lbl_Count;
        private System.Windows.Forms.Button Btn_Pause;
        private System.Windows.Forms.Timer Tmr_Count;
        private System.Windows.Forms.DataGridView DGV_Files;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.Button Btn_Instruction;
        private System.Windows.Forms.Button Btn_My_Folder;
        private System.Windows.Forms.Button Btn_Ready_Folder;
        private System.Windows.Forms.Button Btn_Job_Folder;
        private System.Windows.Forms.Button Btn_100;
        private System.Windows.Forms.Button Btn_90;
        private System.Windows.Forms.Button Btn_80;
        private System.Windows.Forms.Button Btn_60;
        private System.Windows.Forms.Button Btn_70;
        private System.Windows.Forms.Button Btn_50;
        private System.Windows.Forms.TextBox Txt_File;
        private System.Windows.Forms.Button Btn_Find;
        private System.Windows.Forms.Label Lbl_Job_Time;
        private System.Windows.Forms.Timer Tmr_Open;
        private System.Windows.Forms.Timer Tmr_Save;
    }
}