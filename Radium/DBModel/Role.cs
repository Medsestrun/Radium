//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Radium.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Role
    {
        public Role()
        {
            this.UserRole = new HashSet<UserRole>();
        }
    
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}