using laba20v3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba20v3.ViewModels
{
     class ViewNomen:ObservableCollection<nom>
    {
        public ViewNomen()
        {
            DbSet<nom> titles = tovar1.laba1920.nom;
            var queryTitle = from title in titles select title;
            foreach (nom titl in queryTitle)
                this.Add(titl);
        }
        
    }
}
