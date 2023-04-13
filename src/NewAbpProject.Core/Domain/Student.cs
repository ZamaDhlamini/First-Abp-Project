using NewAbpProject.Domain.Antributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbpProject.Domain
{
    [Entity(TypeshortAlias = "Arf.Student")]
    [DiscriminatorValue("Arf.Student")]
    public class Student : Person
    {
        public virtual string StudentNumber { get; set; }
        ///<summary>
        ///
        /// </summary>
        public virtual Course course { get; set; }
        ///<summary>
        ///
        /// </summary>
        public virtual int AcademicYear { get; set; }
    }
}
