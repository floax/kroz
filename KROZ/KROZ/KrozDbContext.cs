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
        public DbSet<Characters.Character> characters { get; set; }
        public DbSet<Characters.PJ> players { get; set; }
        public DbSet<Characters.PNJ> monsters { get; set; }

        //Object and UsableItem Tables
        public DbSet<Items.Item> items { get; set; }
        public DbSet<Items.UsableItem> usableitems { get; set; }
        public DbSet<Items.Weapon> weapons { get; set; }
        public DbSet<Menus.Inventory> inventory { get; set; }

        //Location Tables
        public DbSet<Location.Map> maps { get; set; }
        public DbSet<Location.Cell> cells { get; set; }
    }
}
