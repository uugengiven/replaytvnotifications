using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;



namespace ReplayTVNotifications.Models
{
    public class Notification
    {
        public int id { get; set; }
        public string type { get; set; }
        [Display(Name = "Value")]
        public string value { get; set; }
        [Display(Name = "Date/Time")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy HH:mm}")]
        public string time { get; set; }
        [Display(Name = "Enabled")]
        public bool enabled { get; set; }
    }

    public class NotificationDbContext : DbContext
    {
        public System.Data.Entity.DbSet<ReplayTVNotifications.Models.Notification> Notifications { get; set; }
    }
}