using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDataStoreUsingStruct
{
    public partial class Form1 : Form
    {
        List<Student> students;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //creates some dummy student records so that the program starts with records already available
            students = new List<Student>()
            {
                new Student() { StudentID = 111, FirstName = "John", LastName = "Doe",
                    DateOfBirth = DateTime.Parse("11/3/1996"), Address = "411 Jane Blvd, Apt 5, Georgetown, PA 32485",
                    MonthOfAdmission = Month.June, Grade = LetterGrade.B},
                new Student() { StudentID = 112, FirstName = "Fred", LastName = "Flintstone",
                    DateOfBirth = DateTime.Parse("5/13/1999"), Address = "2311 Harbor St, Boulder, AZ 32245",
                    MonthOfAdmission = Month.March, Grade = LetterGrade.B},
                new Student() { StudentID = 131, FirstName = "Mary", LastName = "Lamb",
                    DateOfBirth = DateTime.Parse("12/25/2000"), Address = "135 Fleece Way, Whitesnow, MA 11234",
                    MonthOfAdmission = Month.December, Grade = LetterGrade.A},
                new Student() { StudentID = 151, FirstName = "Max", LastName = "Payne",
                    DateOfBirth = DateTime.Parse("1/23/1998"), Address = "52 Bay St, Naples, ID 53532",
                    MonthOfAdmission = Month.January, Grade = LetterGrade.C},
                new Student() { StudentID = 118, FirstName = "Penelope", LastName = "Pitstop",
                    DateOfBirth = DateTime.Parse("5/20/2006"), Address = "623 Indy Raceway, Daytona, FL 23753",
                    MonthOfAdmission = Month.June, Grade = LetterGrade.B}
            };
        }

        private void openStudentRecordsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            groupBoxStudentRecordDisplay.Visible = true;
        }

        private void closeStudentRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxStudentRecordDisplay.Visible = false;
        }
    }
}
