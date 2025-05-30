﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;



public partial class BookingContext : DbContext
{
    public BookingContext()
    {
    }

    public BookingContext(DbContextOptions<BookingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Bruger> Brugers { get; set; }

    public virtual DbSet<Fag> Fags { get; set; }

    public virtual DbSet<Hold> Holds { get; set; }

    public virtual DbSet<Lokale> Lokales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Boooking;Integrated Security=True;Encrypt=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Booking__3214EC07EF78F349");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Bruger).WithMany(p => p.Bookings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BrugerId");

            entity.HasOne(d => d.Lokale).WithMany(p => p.Bookings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LokaleId");
        });

        modelBuilder.Entity<Bruger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bruger__3214EC07368D8A53");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Fag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fag__3214EC07D32A27CD");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Bruger).WithMany(p => p.Fags)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BrugerId2");

            entity.HasOne(d => d.Hold).WithMany(p => p.Fags)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HoldId");
        });

        modelBuilder.Entity<Hold>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hold__3214EC072F5A64CF");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Lokale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Lokale__3214EC074B54446D");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}