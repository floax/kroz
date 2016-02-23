using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ
{
    public class KrozDbContext : DbContext
    {
        //Player and Monster Tables
        DbSet<Characters.Character> characters { get; set; }
        DbSet<Characters.PJ> players { get; set; }
        DbSet<Characters.PNJ> monsters { get; set; }

        //Object and UsableItem Tables
        DbSet<Items.Item> items { get; set; }
        DbSet<Items.UsableItem> usableitems { get; set; }
        DbSet<Items.Weapon> weapons { get; set; }

        //Location Tables
        DbSet<Location.Map> maps { get; set; }
        DbSet<Location.Cell> cells { get; set; }
    }
}
