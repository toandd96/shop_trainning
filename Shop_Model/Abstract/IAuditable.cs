﻿using System;

namespace Shop_Model.Models
{
    public interface IAuditable
    {
        DateTime? CreateDate { get; set; }
        string CreateBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdateBy { get; set; }
        string MetaKeyword { get; set; }
        string MetaKeyDescription { get; set; }
        bool Status { get; set; }
    }
}