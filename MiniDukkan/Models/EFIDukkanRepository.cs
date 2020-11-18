using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniDukkan.Models
{
    public class EFIDukkanRepository : IDukkanRepository
    {
        
        
        private MiniDukkanContext Context;

        public EFIDukkanRepository(MiniDukkanContext ctx )
        {
            Context = ctx;    
        }
      public  IQueryable<Urun> Urunler => Context.Urunler;
    }
}
