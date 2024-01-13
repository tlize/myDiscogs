using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace myDiscogs.Data
{
    public class myDiscogsContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public myDiscogsContext() : base("name=myDiscogsContext")
        {
        }

        public System.Data.Entity.DbSet<myDiscogs.Models.CollectionValue> CollectionValues { get; set; }

        public System.Data.Entity.DbSet<myDiscogs.Models.Wantlist.PaginatedWantlist> PaginatedWantlists { get; set; }

        public System.Data.Entity.DbSet<myDiscogs.Models.Wantlist.Want> Wants { get; set; }
    }
}
