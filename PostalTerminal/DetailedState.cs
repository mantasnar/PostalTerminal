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
    
    public partial class DetailedState
    {
        public int Id { get; set; }
        public string isWorking { get; set; }
        public string faultCode { get; set; }
        public string isFull { get; set; }
        public string needsService { get; set; }
    
        public virtual PostalTerminal PostalTerminal { get; set; }
        public virtual faultCodes faultCode1 { get; set; }
    }
}