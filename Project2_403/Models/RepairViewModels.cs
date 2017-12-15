using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Project2_403.Models
{
     public class RepairInfoViewModel
    {
        public int Id { get; set; }


        [Required]
        [Display(Name = "Serial Number")]
        public long RepairSerialNum { get; set; }

        [Required]
        [Display(Name = "Received By")]
        public string RepairSalesRepName { get; set; }

        [Required]
        [Display(Name = "Repaired By")]
        public string RepairTechName { get; set; }

        [Required]
        [Display(Name = "Drop-off Time")]
        public DateTime RepairDropTime { get; set; }

        [Required]
        [Display(Name = "Pick-Up Time")]
        public DateTime RepairPickTime { get; set; }

        [Required]
        [Display(Name = "Repaired Parts")]
        public string[] RepairedParts { get; set; }

    }



    public class RepairViewModel
    {

        public int Id { get; set; }

        

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Brand")]
        public string DeviceBrand { get; set; }

        [Required]
        [Display(Name = "Model")]
        public string DeviceModel { get; set; }

        [Required]
        [Display(Name = "Device Color")]
        public string DeviceColor { get; set; }

        [Required]
        [Display(Name = "Memory")]
        public int DeviceMemory { get; set; }

        [Required]
        [Display(Name = "Repair Type")]
        public string RepairType { get; set; }







    }
}