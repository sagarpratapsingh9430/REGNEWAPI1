using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace REGNEWAPI1.Models
{
    public class Apicontext : DbContext
    {

        public Apicontext(DbContextOptions<Apicontext> options) : base(options)
        {

        }
        public DbSet<ApiModel> MVCDemo8 { get; set; }

    }

}