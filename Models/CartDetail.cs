//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EBooksWebApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CartDetail
    {
        public int cartDetailsID { get; set; }
        public int cartID_fk { get; set; }
        public int cusID_fk { get; set; }
        public int bookID_fk { get; set; }
        public System.DateTime addedDate { get; set; }
        public int quantity { get; set; }
    
        public virtual BookDetail BookDetail { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
