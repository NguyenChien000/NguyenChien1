using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace NguyenVanChien_5951071006.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "hoTen")]
        public string Hoten { get; set; }
        [DataMember(Name = "MSSV")]
        public string MaSoSv { get; set; }
        [DataMember(Name = "LOP")]
        public string Lop { get; set; }
        [DataMember(Name = "ngaySinh")]
        public DateTime NgaySinh { get; set; }


    }
}