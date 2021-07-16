using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneBook.Models.EntityModels
{
    public class TblUserMetaData
    {
        [Display]
        public int ID { get; set; }
        [Display(Name ="نام")]
        public string Firstname { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string Lastname { get; set; }
        [Display(Name = "موبایل")]
        public string Mobile { get; set; }
        [Display(Name = "تلفن ثابت")]
        public string PhoneNumber { get; set; }
        [Display(Name = "کد ملی")]
        public string NationalCode { get; set; }
        [Display(Name = "گروه")]
        public string cGroup { get; set; }
        [Display(Name = "عکس")]
        public byte[] Picture { get; set; }
    }
}

namespace PhoneBook.Models.DomainModel
{
    [MetadataType(typeof(EntityModels.TblUserMetaData))]
    public partial class TblUser
    {

    }
}