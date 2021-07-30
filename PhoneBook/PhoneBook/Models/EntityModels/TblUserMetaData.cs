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
        [StringLength(50, ErrorMessage = "{0} باید بین 3 الی 50 کاراکتر باشد. ", MinimumLength = 3)]
        [Required(ErrorMessage ="نام را وارد کنید")]
        public string Firstname { get; set; }

        [Display(Name = "نام خانوادگی")]
        [StringLength(50, ErrorMessage = "{0} باید بین 3 الی 50 کاراکتر باشد. ", MinimumLength = 3)]
        [Required(ErrorMessage = "نام خانوادگی را وارد کنید")]
        public string Lastname { get; set; }

        [Display(Name = "موبایل")]
        [StringLength(11, ErrorMessage = "{0} باید 11 رقم باشد. ", MinimumLength = 11)]
        [Required(ErrorMessage = "موبایل را وارد کنید")]
        [Range(0, double.MaxValue, ErrorMessage = "برای شماره همراه عدد وارد کنید.")]
        public string Mobile { get; set; }

        [Display(Name = "تلفن ثابت")]
        [StringLength(13, ErrorMessage = "{0} به همراه کد شهر بین 11 الی 13 کاراکتر باشد. ", MinimumLength = 11)]
        [Required(ErrorMessage = "تلفن ثابت را وارد کنید")]
        [Range(0, double.MaxValue, ErrorMessage = "برای شماره تلفن عدد وارد کنید.")]
        public string PhoneNumber { get; set; }
        
        [Display(Name = "کد ملی")]
        [StringLength(10, ErrorMessage = "{0} باید 10 رقم باشد بدون خط تیره. ", MinimumLength = 10)]
        [Required(ErrorMessage = "کد ملی را وارد کنید")]
        public string NationalCode { get; set; }
        [Display(Name = "گروه")]
        [StringLength(50, ErrorMessage = "{0} باید بین 3 الی 50 کاراکتر باشد. ", MinimumLength = 3)]
        [Required(ErrorMessage = "گروه را وارد کنید")]
        public string cGroup { get; set; }
        //[Display(Name = "کدعکس")]
        //public byte[] Picture { get; set; }
        [Display(Name = "تصویر")]
        public string ImageName { get; set; }
        [Display(Name = "توضیحات")]
        [StringLength(1500, ErrorMessage = "{0} باید بین 0 الی 1500 کاراکتر باشد. ", MinimumLength = 0)]
        public string Descriptions { get; set; }
    }
}

namespace PhoneBook.Models.DomainModel
{
    [MetadataType(typeof(EntityModels.TblUserMetaData))]
    public partial class TblUser
    {

    }
}