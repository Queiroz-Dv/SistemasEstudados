using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DTO;

namespace PersonalTracking
{
    public partial class FrmPosition : Form
    {
        public FrmPosition()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        List<DEPARTMENT> departmentlist = new List<DEPARTMENT>();
        public PositionDTO detail = new PositionDTO();
        public bool isUpdate = false;


        private void FrmPosition_Load(object sender, EventArgs e)
        {
            departmentlist = DepartmentBLL.GetDepartments();
            cmbDeparment.DataSource = departmentlist;
            cmbDeparment.DisplayMember = "DepartmentName";
            cmbDeparment.ValueMember = "ID";
            cmbDeparment.SelectedIndex = -1;
            if(isUpdate)
            {
                txtPosition.Text = detail.PositionName;
                cmbDeparment.SelectedValue = detail.DepartmentID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPosition.Text.Trim() == "")
                MessageBox.Show("Please fill the position name");
            else if (cmbDeparment.SelectedIndex == -1)
                MessageBox.Show("Please select a department");
            else
            {
                if(!isUpdate)
                {
                    POSITION position = new POSITION();
                    position.PositionName = txtPosition.Text;
                    position.DepartmentID = Convert.ToInt32(cmbDeparment.SelectedValue);
                    PositionBLL.AddPosition(position);
                    MessageBox.Show("Position was added");
                    txtPosition.Clear();
                    cmbDeparment.SelectedIndex = -1;
                }
                else
                {
                    POSITION position = new POSITION();
                    position.ID = detail.ID;
                    position.PositionName = txtPosition.Text;
                    position.DepartmentID = Convert.ToInt32(cmbDeparment.SelectedValue);
                    bool control = false;
                    if (Convert.ToInt32(cmbDeparment.SelectedValue) != detail.OldDepartmentID)
                        control = true;
                    PositionBLL.UpdatePosition(position, control);
                    MessageBox.Show("Position was updated");
                    this.Close();
                }
            }

        }
    }
}
