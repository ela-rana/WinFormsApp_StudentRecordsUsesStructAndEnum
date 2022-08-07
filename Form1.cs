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
        List<Student> students; //to create a list of student records

        public Form1()
        {
            InitializeComponent();
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
            dataGridViewDisplayStudentRecord.DataSource=students; //to set the students list as the source
                                                                  //to display within the datagridview
            comboBoxGrade.DataSource = Enum.GetValues(typeof(LetterGrade)); //to set possible values for the
                //grade combobox as all the possible values in the enum LetterGrade
            comboBoxGrade.SelectedIndex = -1;   //to keep the combobox blank until user selects a dropdown 
                //option by setting the index to a value lower than the first index
            comboBoxMonthOfAdmission.DataSource = Enum.GetValues(typeof(Month)); //to set possible values for
                //month of admission combobox as all the possible values in the enum Month
            comboBoxMonthOfAdmission.SelectedIndex = 1; //to keep the combobox blank until user selects a dropdown 
                //option by setting the index to a value lower than the first index
        }


        private void openStudentRecordsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            groupBoxStudentRecordDisplay.Visible = true;    //to make the Student Record Display groupbox visible
        }

        private void addNewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxStudentRecordEntry.Visible = true;    //to make the Student Record Entry groupbox visible
        }

        private void deleteStudentRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxStudentRecordDeletion.Visible = true;    //to make the Student Record Deletion groupbox visible
        }        
        
        private void closeStudentRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxStudentRecordDisplay.Visible = false;    //to make the Student Record Display groupbox invisible
                                                             //when user clicks the close menu item
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to make all groupboxes invisible when the user clicks the Close All menu choice
            groupBoxStudentRecordDisplay.Visible = false;
            groupBoxStudentRecordDeletion.Visible = false;
            groupBoxStudentRecordEntry.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to close the app when the user presses the Exit Menu choice
            Application.Exit();
        }

        private void textBoxStudentID_TextChanged(object sender, EventArgs e)
        {
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "This functionality is currently unavailable.\nPlease press CTRL+Z on your keyboard to Undo.");
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "This functionality is currently unavailable.\nPlease press CTRL+Y on your keyboard to Redo.");
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            if(textBoxStudentID.Text != String.Empty && textBoxFirstName.Text != String.Empty &&
               textBoxLastName.Text != String.Empty && textBoxAddress.Text != String.Empty &&
               dateTimePickerDateOfBirth.Text != String.Empty && comboBoxGrade.Text != String.Empty && 
               comboBoxMonthOfAdmission.Text != String.Empty)   //to make sure all fields are filled before
                                                                //record is added to our student records list
            {
                Student st = new Student()
                {
                    StudentID = Int32.Parse(textBoxStudentID.Text),
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    Address = textBoxAddress.Text,
                    DateOfBirth = DateTime.Parse(dateTimePickerDateOfBirth.Text),
                    Grade = (LetterGrade)comboBoxGrade.SelectedIndex,
                    MonthOfAdmission = (Month)comboBoxMonthOfAdmission.SelectedIndex
                };  //to create a new temp student record variable st to hold user entered student record
                students.Add(st);   //to add the newly entered record in st to our students list
                MessageBox.Show("Record successfully added");
                RefreshData();  //to clear everything we just filled and display the updated students list
            }
        }

        /// <summary>
        /// A method to clear all filled values in the groupBoxStudentRecordEntry and to refresh the datagrid 
        /// with most current number of records
        /// </summary>
        private void RefreshData()
        {
            textBoxStudentID.Clear(); //blanks out and clears any text currently in the Employee ID textbox
            textBoxFirstName.Clear();   //clears First Name textbox
            textBoxLastName.Clear();    //clears Last Name textbox
            textBoxAddress.Clear();  //clears Salary textbox
            comboBoxGrade.SelectedIndex = -1;    //to keep the combobox blank until user selects a dropdown 
                                                 //option by setting the index to a value lower than the first index
            comboBoxMonthOfAdmission.SelectedIndex = -1; //to keep the combobox blank until user selects a dropdown 
                                                         //option by setting the index to a value lower than the first index 
            dateTimePickerDateOfBirth.CustomFormat = "";    //to reset datetimepicker to show a blank value
            dataGridViewDisplayStudentRecord.DataSource = null; //to clear the datagridview before it can be refreshed
            dataGridViewDisplayStudentRecord.DataSource = students;    //to display the latest student data to grid
        }


        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (students.Count != 0)    //As long as the students list is not blank
            {
                students.RemoveAt(dataGridViewDisplayStudentRecord.CurrentRow.Index);   //the record at the 
                                                //selected row is deleted
                RefreshData();  //then the datagrid is refreshed
            }
            else
            {
                MessageBox.Show("There are no records to delete."); //if the students list is blank and the 
                            //delete record button is clicked, this error message is displayed
            }

        }

        private void dateTimePickerDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerDateOfBirth.CustomFormat = "MMMMM dd, yyyy";  //the datetimepicker is initially blank
            //this statement causes the datetimepicker to display the date once a date is selected
        }

        private void openAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to make all groupboxes visible when the user clicks the Open All menu choice
            groupBoxStudentRecordDisplay.Visible = true;
            groupBoxStudentRecordDeletion.Visible = true;
            groupBoxStudentRecordEntry.Visible = true;

        }
    }
}
