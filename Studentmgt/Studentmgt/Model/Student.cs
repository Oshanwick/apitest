using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Studentmgt.Model
{
    [Table("tblStudentDetails")]
    public class Student
    {
        [Key]
        public string    strStudentId { get; set; }
        public int  intId { get; set; }
        public string strCourseId { get; set; }
        public string strStudentName { get; set; }
        public string strStudentMobileNo { get; set; }
        public string strStudentEmail { get; set; }



    }
}
