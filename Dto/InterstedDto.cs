using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class InterstedDto
    {
        public int IdIntersted { get; set; }
        public string FirstNameIntersted { get; set; }
        public string LastNameIntersted { get; set; }
        public string TzIntersted { get; set; }
        public string GmailIntersted { get; set; }
        public string CellIntersted { get; set; }
        public int? IdResource { get; set; }
        public int? IdFaculty { get; set; }
        public Nullable<int> IdDiploma { get; set; }
        public Nullable<int> IdPersonStatus { get; set; }
        public Nullable<int> IdCollege { get; set; }
        public Nullable<int> IdUser { get; set; }
    }
}
