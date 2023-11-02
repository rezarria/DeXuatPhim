using System;
using DeXuatApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DeXuatApp.DbContexts;

public class MyIdentityDbContext : IdentityDbContext<User, Role, Guid>
{
    public MyIdentityDbContext(DbContextOptions<MyIdentityDbContext> options) : base(options)
    {
    }
}