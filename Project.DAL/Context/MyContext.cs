using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Models;
using Project.MAP.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
    //Eğer kurmak istediğimiz veritabanı yapısında Identity kullacaksanız DBContext'ten miras alamayız...Çünkü Identity, kendi tablolarını hazır bir yapı olarak sunabilmesi adına IdentityDbContext'ten miras almaya yönlendirir...

    //Identity Normal şartlarda tablolarını temsil edecek classlar'a sahip olsa da bu tabloların primary keylerinin hangi tipte olacagini bilmez ve biz ifadede bulunmassak da gider primary keyleri nvarchar acar (burada string olarak görür deault olarak).... oyüzden biz eger özellikle bir domain entity'imize bir Identity sınıfından miras vererek actiysak bu demektir ki Identity ile sizin özellikleriniz birleşiyor(bkz.AppUser)...Dolayısıyla bu sınıf generic olarak IdentityDbContext sınıfının ilk generic argümani olarak verilebilir...
    public class MyContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new ProfileConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new OrderDetailConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> AppUserProfiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
