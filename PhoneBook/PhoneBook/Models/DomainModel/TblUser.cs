//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhoneBook.Models.DomainModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblUser
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Mobile { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalCode { get; set; }
        public string cGroup { get; set; }
        public byte[] Picture { get; set; }
    }
}
