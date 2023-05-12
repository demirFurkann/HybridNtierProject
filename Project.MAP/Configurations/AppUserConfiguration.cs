using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public   class AppUserConfiguration:BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Profile).WithOne(x => x.AppUser).HasForeignKey<AppUserProfile>(x => x.ID);
            //Birebir ilişki için ayarımızı burada yaptık

            //Bizim AppUser class'ıımızın  bizim yazdıgımız property'lerin  yanı sıra Microsft'un Identity kütüphanesinden gelen propert'leride olacaktir...Identity'den gelen bu property'lerin içerisinde primary key olan ve Id ismine sahip olan bir property daha olacaktır...Dolayasıyla bu class, tabloya cevrilirken hem bizim ID property'miz hem de Identity'nin gönderdiği Id property'si SQL'deki Incasesensitive durumu yüzünden aynı sütün sayılarak bizde migration durumunda bir tabloda aynı isimde iki sütün olamaz diye bir hata çikaricaktir...Dolayısıyla bizim burada ID'miz C#'ta kalacak ve onun SQL'e gönderilmesi(Kendi ID'imizi) engellememiz gerekecektir... 
            builder.Ignore(x => x.ID);
        }
    }
}
