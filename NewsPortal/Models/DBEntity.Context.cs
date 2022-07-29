﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewsPortal.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBEntities : DbContext
    {
        public DBEntities()
            : base("name=DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Contact> Contacts { get; set; }
    
        public virtual int proc_InsertContact(string name, string email, string subject, string messege, Nullable<System.DateTime> createDate)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var subjectParameter = subject != null ?
                new ObjectParameter("subject", subject) :
                new ObjectParameter("subject", typeof(string));
    
            var messegeParameter = messege != null ?
                new ObjectParameter("messege", messege) :
                new ObjectParameter("messege", typeof(string));
    
            var createDateParameter = createDate.HasValue ?
                new ObjectParameter("createDate", createDate) :
                new ObjectParameter("createDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_InsertContact", nameParameter, emailParameter, subjectParameter, messegeParameter, createDateParameter);
        }
    }
}
