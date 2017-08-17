using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBlog.Models.ORM.Entity
{
    public class BaseEntity
    {
        public int ID { get; set; }

        DateTime? _addDate = DateTime.Now;
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }
        bool _isDeleted = false;
        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }
        public DateTime? DeleteDate { get; set; }
    }
}