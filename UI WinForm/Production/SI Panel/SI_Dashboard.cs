﻿using Skill_PMS.Controller;
using Skill_PMS.Data;
using Skill_PMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_PMS.UI_WinForm.Production.SI_Panel
{
    public partial class SI_Dashboard : Form
    {
        SkillContext DB = new SkillContext();
        Common Common = new Common();

        static public User User { get; set; }
        static public Attend Attend = new Attend();

        public SI_Dashboard()
        {
            InitializeComponent();
        }

        private void SI_Dashboard_Load(object sender, EventArgs e)
        {
            this.Text = "SI Panel - " + User.Full_Name;
            Check_New_Job();
        }

        void Check_New_Job()
        {
            Dgv_New_Job.DataSource = null;
            Dgv_New_Job.Rows.Clear();
            Common.Dgv_Size(Dgv_New_Job, 11);

            var Jobs = DB.Jobs
                .Where(x => x.Status == "New")
                .Include(x => x.Actual_Time_Price)
                .ToList();

            int SL = 1;
            foreach (var Job in Jobs)
            {
                Dgv_New_Job.Rows.Add(SL++, Job.JobID, Job.Folder, Job.InputAmount, Job.Actual_Time_Price.Time, Job.Actual_Time_Price.Time * Job.InputAmount, Job.Incoming, Job.Delivery);
            }

            Common.Row_Color_By_Delivery(Dgv_New_Job, "Column28");
        }

        void Check_Running_Job()
        {
            Dgv_Running_Job.DataSource = null;
            Dgv_Running_Job.Rows.Clear();
            Common.Dgv_Size(Dgv_Running_Job, 11);

            var Jobs = DB.Jobs
                .Where(x => x.Status == "Pro")
                .Include(x => x.Pro_Time_Price)
                .ToList();

            int SL = 1;
            foreach (var Job in Jobs)
            {
                Dgv_Running_Job.Rows.Add(SL++, Job.JobID, Job.Folder, Job.InputAmount, Job.Pro_Done, Job.Service, Job.Pro_Time_Price.Target_Time, Job.Pro_Time_Price.Pro_Time, Job.Delivery, "Edit");
            }

            Common.Row_Color_By_Delivery(Dgv_Running_Job, "Column33");
        }

        void Check_QC_Job()
        {
            Dgv_QC_Job.DataSource = null;
            Dgv_QC_Job.Rows.Clear();
            Common.Dgv_Size(Dgv_QC_Job, 11);

            var Jobs = DB.Jobs
                .Where(x => x.Status == "QC")
                .Include(x => x.Pro_Time_Price)
                .ToList();

            int SL = 1;
            foreach (var Job in Jobs)
            {
                Dgv_QC_Job.Rows.Add(SL++, Job.JobID, Job.Folder, Job.InputAmount, Job.Pro_Done, Job.OutputAmount, Job.Service, Job.Pro_Time_Price.Target_Time, Job.Pro_Time_Price.Pro_Time, Job.Delivery, "Edit");
            }

            Common.Row_Color_By_Delivery(Dgv_QC_Job, "Column9");
        }

        void Check_Ready_Job()
        {
            Dgv_Ready_Job.DataSource = null;
            Dgv_Ready_Job.Rows.Clear();
            Common.Dgv_Size(Dgv_Ready_Job, 11);

            var Jobs = DB.Jobs
                .Where(x => x.Status == "Ready")
                .Include(x => x.Pro_Time_Price)
                .ToList();

            int SL = 1;
            foreach (var Job in Jobs)
            {
                Dgv_Ready_Job.Rows.Add(SL++, Job.JobID, Job.Folder, Job.InputAmount, Job.OutputAmount, Job.Service, Job.Pro_Time_Price.Target_Time, Job.Pro_Time_Price.Pro_Time, Job.Delivery, "Edit");
            }

            Common.Row_Color_By_Delivery(Dgv_Ready_Job, "Column9");
        }

        void Check_Done_Job()
        {
            Dgv_QC_Job.DataSource = null;
            Dgv_QC_Job.Rows.Clear();
            Common.Dgv_Size(Dgv_QC_Job, 11);

            var Jobs = DB.Jobs
                .Where(x => x.Status == "Done")
                .Include(x => x.Pro_Time_Price)
                .ToList();

            int SL = 1;
            foreach (var Job in Jobs)
            {
                Dgv_QC_Job.Rows.Add(SL++, Job.JobID, Job.Folder, Job.InputAmount, Job.Service, Job.Pro_Time_Price.Target_Time, Job.Pro_Time_Price.Target_Time * Job.InputAmount, Job.Delivery, "Edit");
            }

            Common.Row_Color_By_Delivery(Dgv_QC_Job, "Column9");
        }

        private void SI_Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Attend.Logout = DateTime.Now;
            Attend.Status = "Logout";
            Attend.Workingtime = Convert.ToInt32((Attend.Logout - Attend.Login).TotalMinutes);
            DB.Attends.AddOrUpdate(Attend);
            DB.SaveChanges();
            Application.Exit();
        }

        private void Tbc_CS_Panel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Tbc_CS_Panel.SelectedIndex)
            {
                case 0:
                    Check_New_Job();
                    break;

                case 1:
                    Check_Running_Job();
                    break;
                case 2:
                    Check_QC_Job();
                    break;

                case 3:
                    Check_Ready_Job();
                    break;

                case 4:
                    Check_Done_Job();
                    break;

                case 5:
                //Dtp_Job_Assign_From.Value = DateTime.Now;
                //Cmb_Job_Assign_Shift.Text = con.Check_Shift();
                //if (assign_check)
                //    Check_Assign();
                //break;

                case 6:
                    break;
            }
        }
    }
}