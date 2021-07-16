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
        [Required(ErrorMessage ="نام را وارد کنید")]
        public string Firstname { get; set; }
        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "نام خانوادگی را وارد کنید")]
        public string Lastname { get; set; }
        [Display(Name = "موبایل")]
        [Required(ErrorMessage = "موبایل را وارد کنید")]
        public string Mobile { get; set; }
        [Display(Name = "تلفن ثابت")]
        [Required(ErrorMessage = "تلفن ثابت را وارد کنید")]
        public string PhoneNumber { get; set; }
        [Display(Name = "کد ملی")]
        [Required(ErrorMessage = "کد ملی را وارد کنید")]
        public string NationalCode { get; set; }
        [Display(Name = "گروه")]
        [Required(ErrorMessage = "گروه را وارد کنید")]
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