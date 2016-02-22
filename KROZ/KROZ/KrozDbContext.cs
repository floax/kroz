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
        DbSet<Characters.Character> characters;
        DbSet<Characters.PJ> players;
        DbSet<Characters.PNJ> monsters;

        //Object and UsableItem Tables
        DbSet<Items.Item> items; 
        DbSet<Items.UsableItem> usableitems;
        DbSet<Items.Weapon> weapons;

        //Location Tables
        DbSet<Location.Map> maps;
        DbSet<Location.Cell> cells;
    }
}
