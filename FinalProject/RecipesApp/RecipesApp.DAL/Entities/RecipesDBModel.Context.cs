﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecipesApp.DAL.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RecipesDBEntities : DbContext
    {
        public RecipesDBEntities()
            : base("name=RecipesDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CategoryRecipe> CategoryRecipe { get; set; }
        public virtual DbSet<CommentsRecipe> CommentsRecipe { get; set; }
        public virtual DbSet<Ingredients> Ingredients { get; set; }
        public virtual DbSet<IngredientsRecipe> IngredientsRecipe { get; set; }
        public virtual DbSet<Ratings> Ratings { get; set; }
        public virtual DbSet<Recipe> Recipe { get; set; }
        public virtual DbSet<Subcategory> Subcategory { get; set; }
        public virtual DbSet<SubcategoryRecipe> SubcategoryRecipe { get; set; }
        public virtual DbSet<Instructions> Instructions { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
    }
}