using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;


namespace Project2_403.Models
{
    public class RepairsModels
    {
                    [Key]
            public Guid RepairRecordId
            {
                get { return RepairRecordId; }
                set { this.RepairRecordId = new Guid(); }
            }

            public Device Device = new Device();
            public RepairInfoModel RepairInfo = new RepairInfoModel();
            public CustomerInfoModel customerInfo = new CustomerInfoModel();
            public string RepairStatus { get; set; }
            public string RepairComments { get; set; }

        }

        public class Device
        {
            [Key]
            public int DeviceId { get; set; }
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
        }


        public class RepairInfoModel
        {
            public Guid Id
            {

                get { return Id; }
                set { Id = new Guid(); }

            }
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


        public class CustomerInfoModel
        {
        [Key]
            [Required]
        public Guid CustomerId
        {
            get { return CustomerId; }
            set { this.CustomerId = new Guid(); }
        }

        public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Required]
            [Display(Name = "Phone Number")]
            public string PhoneNumber { get; set; }

        }
    
   

}