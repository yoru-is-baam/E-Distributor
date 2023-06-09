//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class WarehouseReceipt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WarehouseReceipt()
        {
            this.IncludeImportedItems = new HashSet<IncludeImportedItem>();
        }
    
        public int WarehouseReceiptId { get; set; }
        public int TotalQuantity { get; set; }
        public int TotalPrice { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public string WarehouseStaffId { get; set; }
        public string AccountantId { get; set; }
    
        public virtual Accountant Accountant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncludeImportedItem> IncludeImportedItems { get; set; }
        public virtual WarehouseStaff WarehouseStaff { get; set; }
    }
}
