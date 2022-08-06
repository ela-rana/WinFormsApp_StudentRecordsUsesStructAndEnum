using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataStoreUsingStruct
{
    enum LetterGrade    //an enum to represent all possible letter grades a student can get
    {
        A,
        B,
        C,
        D,
        F,
        Incom,  //Incomplete: If student's grade has not been calculated due to other reasons
        Drop    //If student drops the course or semester
    }

    enum Month  //an enum to represent all months in a year
    {
        January=1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    struct Student  //A structure to represent all Student properties
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public Month MonthOfAdmission { get; set; }
        public LetterGrade Grade { get; set; }
    }
}
