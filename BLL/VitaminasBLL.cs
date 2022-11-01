using Microsoft.EntityFrameworkCore;
using Parcial2_Emely.Data;
    public class VitaminasBLL
    {
        private ApplicationDbContext _contexto;
        public VitaminasBLL(ApplicationDbContext contexto)
        {
            _contexto = contexto; 
        }


        public Vitaminas? Buscar(int vitaminaId)
        {
            var vitamina = _contexto.Vitaminas
                .Where( v => v.VitaminaId == vitaminaId)
                .SingleOrDefault();
            return vitamina;
        }

         public List<Vitaminas> GetList()
         {
            return _contexto.Vitaminas.AsNoTracking().ToList();
        }
    }
