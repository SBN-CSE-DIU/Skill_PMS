﻿using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skill_PMS.Controller;
using Skill_PMS.Data;
using Skill_PMS.Models;
using Skill_PMS.UI_WinForm.admin_Panel;
using Skill_PMS.UI_WinForm.CS_Panel;
using Skill_PMS.UI_WinForm.HR_Panel;
using Skill_PMS.UI_WinForm.Production.Designer;
using Skill_PMS.UI_WinForm.Production.QC_Panel;
using Skill_PMS.UI_WinForm.Production.SI_Panel;

namespace Skill_PMS.UI_WinForm
{
    public partial class Login : Form
    {
        private User _user;
        private readonly Common _common = new Common();
        private readonly SkillContext _db = new SkillContext();
        private string _shift;
        private string _version = "1.3.1.6";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = "Skill_PMS Login_V"+_version;
            Check_user();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            _shift = Cmb_Shift.Text;
            var date = _common.Shift_Date(DateTime.Now, _shift);

            if (_user == null) 
            {
                MessageBox.Show(@"Please Enter Proper User ID and Try again", @"User doesn't Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(_shift))
            {
                MessageBox.Show(@"Please Select Your Working Shift", @"Shift is Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_user.Password != Txt_Pss.Text)
            {
                MessageBox.Show(@"Please try again with correct password", @"Password Don't Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var performance = _db.Performances.FirstOrDefault(x => x.Name == _user.Short_Name & x.Date ==  date);

            if (performance == null)
            {
                performance = new Performance
                {
                    Name = _user.Short_Name,
                    Date = date, 
                    Login = DateTime.Now,
                    OT_Start = DateTime.Now
                };
                _db.Performances.Add(performance);
            }
            else
            {
                if (!_user.Employee_ID.Contains("10000") & _user.Role != "SI" & _user.Role != "QC" & performance.Status == "Running")
                {
                    MessageBox.Show(@"Your account is already login running. Please logout first", @"Account Already Running", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

            performance.Logout = DateTime.Now;

            if (CMB_OT.Text == "OT Work" & (int)(performance.Logout - performance.Login).TotalHours < 7)
            {
                MessageBox.Show(@"You are not eligible to start OT. Talk to In-Charge", @"You are not eligible to start OT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                if ((int)(performance.OT_Start - performance.Login).TotalMinutes < 1)
                {
                    performance.OT_Start = DateTime.Now;
                    performance.IsOT = 1;
                }
            }

            if (CMB_OT.Text != "OT Work")
                performance.IsOT = 0;

            performance.Shift = _user.Shift = _shift;
            performance.Status = "Running";
            var HostName = Dns.GetHostName() + "";
            var ipAddress = Dns.GetHostAddresses(HostName);
            performance.PC_Name = _version + "_" + HostName + "_" + ipAddress[0] + "_" + ipAddress[1];
            
            var shiftReport = _db.Shift_Reports.FirstOrDefault(x => x.Date == date & x.Shift == _shift & x.Team == "");

            if (shiftReport == null)
                shiftReport = _common.Add_New_Shift_Report(date, _shift);

            shiftReport.QC_Capacity = _common.QC_Capacity(date, _shift);
            shiftReport.Capacity = _common.Designer_Capacity(date, _shift) + shiftReport.QC_Capacity;
            shiftReport.Up = 0;            

            _db.SaveChanges();
            Task.Run(() => _common.Check_Shift_Changing());
            
            this.Hide();
            switch (_user.Role)
            {
                case "CS":
                {
                    var csDashboard = CsDashboard.GetInstance();
                    CsDashboard.User = _user;
                    csDashboard.Performance = performance;
                    csDashboard.Show();
                    break;
                }
                case "SI":
                {
                    var siDashboard = SiDashboard.GetInstance();
                    SiDashboard._user = _user;
                    siDashboard._performance = performance;
                    siDashboard.Show();
                    break;
                }
                case "HR":
                {
                    var hrDashboard = HrDashboard.GetInstance();
                    HrDashboard.User = _user;
                    hrDashboard.Performance = performance;
                    hrDashboard.Show();
                    break;
                }
                case "QC":
                {
                    var qcDashboard = QcDashboard.GetInstance();
                    QcDashboard._user = _user;
                    qcDashboard._performance = performance;
                    qcDashboard.Show();
                    break;
                }
                default:
                {
                    var dashboard = Dashboard.GetInstance();
                    Dashboard._user = _user;
                    dashboard._performance = performance;
                    dashboard.Show();
                    break;
                }
            }
        }

        private void Check_user()
        {
            try
            {
                Txt_Server.Visible = false;
                _user = _db.Users.FirstOrDefault(x => x.Employee_ID == Txt_Usr.Text);

                if (_user != null)
                {
                    Txt_Name.Text = _user.Full_Name;
                    Txt_Designation.Text = _user.Designation;
                }
                else
                {
                    Txt_Name.Text = "";
                    Txt_Designation.Text = "";
                }
            }
            catch (Exception)
            {
                Txt_Server.Visible = true;
            }            
        }

        private void Txt_Usr_TextChanged(object sender, EventArgs e)
        {
            Check_user();
        }

        private void Lnk_Sync_Click(object sender, EventArgs e)
        {
            var adminPanel = AdminPanel.GetInstance();
            adminPanel.Show();
            this.Hide();
        }
    }
}
