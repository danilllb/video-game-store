using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vidddeeoo_sttore.Models
{
    public class game
{   
    public virtual int Id { get; set; }

        public virtual String Name { get; set; }
        public virtual String Description { get; set; }
        public virtual String MinimunRequirements { get; set; }
        public virtual Decimal Price { get; set; }
        public virtual String Developer { get; set; }


    }
}
