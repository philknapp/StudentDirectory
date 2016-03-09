using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Diagnostics;
using System.Web.UI.WebControls;


namespace StudentDirectory
{
    public partial class MainPage : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        static List<Student> studentList = new List<Student>();

        protected void addButton_Click(object sender, EventArgs e)
        {
            String userNametoFind = userNameBox.Text;
            Boolean findResult = false;
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].userName == userNametoFind)
                {
                    findResult = true;
                }
            }
            if (findResult == true)
                {
                    TextBox1.Text = "";
                    TextBox1.Text = "That Username is already in use.";
                }
            if (findResult == false)
                {
                    Student webStudent = new Student();
                    webStudent.userName = (userNameBox.Text);
                    webStudent.firstName = (firstNameBox.Text);
                    webStudent.lastName = (lastNameBox.Text);
                    webStudent.email = (emailBox.Text);
                    webStudent.phone = (phoneBox.Text);
                    webStudent.major = (majorBox.Text);
                    studentList.Add(webStudent);
                    TextBox1.Text = "";
                    TextBox1.Text = webStudent.userName + " has been added.";
            }
            }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            String userNametoFind = (userNameBox.Text);
            Boolean findResult = false;

            for (int i = 0; i < studentList.Count; i++)
            {
                    if (studentList[i].userName == userNametoFind)
                    {
                    studentList[i].firstName = (firstNameBox.Text);
                    studentList[i].lastName = (lastNameBox.Text);
                    studentList[i].email = (emailBox.Text);
                    studentList[i].phone = (phoneBox.Text);
                    studentList[i].major = (majorBox.Text);
                    TextBox1.Text = "";
                    TextBox1.Text = userNametoFind + "'s profile has been updated.";
                    TextBox1.Text += Environment.NewLine;
                    TextBox1.Text += Environment.NewLine;
                    TextBox1.Text += (studentList[i].ToString());
                    findResult = true;
                }

            }
            if (findResult == false)
            {
                TextBox1.Text = "No student with that username exists.";
            }
        }
        protected void deleteButton_Click(object sender, EventArgs e)
        {
            String userNametoFind = (userNameBox.Text);
            Student result;
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].userName == userNametoFind)
                {
                    result = studentList[i];
                    TextBox1.Text = "";
                    TextBox1.Text = "The following user has been removed:";
                    TextBox1.Text += Environment.NewLine;
                    TextBox1.Text += (result.ToString());
                    studentList.Remove(studentList[i]);
                    TextBox1.Text += Environment.NewLine;
                    TextBox1.Text += Environment.NewLine;
                }
            }
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            String userNametoFind = (userNameBox.Text);
            Student result;
            for (int i = 0; i < studentList.Count; i++)
            {

                if (studentList[i].userName == userNametoFind)
                {
                    result = studentList[i];
                    TextBox1.Text = "";
                    TextBox1.Text += (result.ToString());
                }
            }
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }

        protected void show_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            foreach (var Student in studentList)
            {
                TextBox1.Text += (Student.ToString());
                TextBox1.Text += Environment.NewLine;
                TextBox1.Text += Environment.NewLine;
            }
        }
    }
}