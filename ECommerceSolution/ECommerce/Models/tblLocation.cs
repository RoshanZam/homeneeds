//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECommerce.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblLocation()
        {
            this.tblCustomers = new HashSet<tblCustomer>();
        }
    
        public int Location_ID { get; set; }
        public string Name { get; set; }
        public string Pincode { get; set; }
        public Nullable<int> Availablity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomer> tblCustomers { get; set; }
    }
}
