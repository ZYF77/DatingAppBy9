using System;
using API.Entities;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    //通过构造函数为dbcontext提供选项，为dbcontext提供connection string
    // public AppDbContext(DbContextOptions options) : base(options) //将选项传给dbcontext本身
    // {
    public DbSet<AppUser> Users { get; set; }
}


// public class AppDbContext : DbContext
// {
//     public AppDbContext(DbContextOptions options) : base(options)
//     {
        
//     }    
// }