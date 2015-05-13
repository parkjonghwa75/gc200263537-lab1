using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gc200263537_lab1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblStudentNameC.Text = "";
            lblPasswordC.Text = "";
            lblAddressC.Text = "";
            lblEducationC.Text = "";
            lblLaptopC.Text = "";
            lblSkillsC.Text = "";
            lblProvinceC.Text = "";

            //when user submit the form
            lblStudentNameC.Text = txtStudentName.Text;
            lblPasswordC.Text = txtPassword.Text;
            lblAddressC.Text = txtAddress.Text;

            foreach (ListItem education in rblEducation.Items)
            {
                if (education.Selected)
                {
                    lblEducationC.Text = education.Text;
                }
            }

            if(ckbLaptop.Checked){
                lblLaptopC.Text = txtStudentName.Text+ " has a laptop.";
            } else {
                lblLaptopC.Text = txtStudentName.Text + " doesn't have a laptop.";
            }
            

            foreach (ListItem skill in cblSkills.Items)
            {
                if (skill.Selected)
                {
                    lblSkillsC.Text += skill.Text + " ";
                }
            }

            lblProvinceC.Text = ddlProvince.SelectedItem.Text;
        }
    }
}