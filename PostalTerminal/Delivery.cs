//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PostalTerminal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Delivery
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Delivery()
        {
            this.DeliveryStates = new HashSet<DeliveryState>();
            this.Emails = new HashSet<Email>();
        }
    
        public int Id { get; set; }
        public string clientID { get; set; }
        public string paymentID { get; set; }
        public string registrationID { get; set; }
        public string receiverName { get; set; }
        public string receiverSurname { get; set; }
        public string registrationDate { get; set; }
        public string weight { get; set; }
        public string emailSent { get; set; }
    
        public virtual DeliveryRegistration DeliveryRegistration { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryState> DeliveryStates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Email> Emails { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
