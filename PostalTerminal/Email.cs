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
    
    public partial class Email
    {
        public int Id { get; set; }
        public string clientID { get; set; }
        public string deliveryID { get; set; }
        public string sendTime { get; set; }
        public string text { get; set; }
        public string email { get; set; }
    
        public virtual Delivery Delivery { get; set; }
    }
}
