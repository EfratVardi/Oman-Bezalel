//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Repository
    {
        public int IdRepository { get; set; }
        public Nullable<int> IdConversation { get; set; }
        public Nullable<int> IdFaculty { get; set; }
        public Nullable<int> SumPeople { get; set; }
    
        public virtual Conversation Conversation { get; set; }
    }
}
