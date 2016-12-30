using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        
        DateTime? CreateDate { set; get; }
        [MaxLength(256)]
        string CreateBy { set; get; }
        DateTime? UpdateDate { set; get; }
        [MaxLength(256)]
        string UpdateBy { set; get; }

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        bool Status { set; get; }
    }
}