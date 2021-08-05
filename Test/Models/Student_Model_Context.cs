namespace Test.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Student_Model_Context : DbContext
    {
        public Student_Model_Context()
            : base("name=Student_Model_Context")
        {
        }

        public System.Data.Entity.DbSet<Test.Models.Class> Classes { get; set; }

        public System.Data.Entity.DbSet<Test.Models.Student> Students { get; set; }
    }
}
