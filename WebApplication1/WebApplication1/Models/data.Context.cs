﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WebApplication1.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class dataEntities : DbContext
{
    public dataEntities()
        : base("name=dataEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<contact> contacts { get; set; }

    public virtual DbSet<ListPro> ListProes { get; set; }

    public virtual DbSet<news> news { get; set; }

    public virtual DbSet<partner> partners { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<introduce> introduces { get; set; }

    public virtual DbSet<Account> Accounts { get; set; }

}

}

