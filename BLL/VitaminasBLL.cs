using Microsoft.EntityFrameworkCore;
using Parcial2_Oly.Data;

public class VitaminasBLL
    {
        private ApplicationDbContext _contexto;
        public VitaminasBLL(ApplicationDbContext contexto) 
        {
            _contexto = contexto;
        }
        public bool Guardar(Vitaminas vitaminas)
        {
            if (!Existe(vitaminas.VitaminaId))
                return this.Insertar(vitaminas);
            else
                return this.Modificar(vitaminas);

        }
        public bool Existe(int vitaminaId)
        {
            return _contexto.Vitaminas.Any(o => o.VitaminaId == vitaminaId);
        }
        private bool Insertar(Vitaminas vitaminas)
        {
            _contexto.Vitaminas.Add(vitaminas);
            return _contexto.SaveChanges() > 0;
        }
        public bool Modificar(Vitaminas vitaminas)
        {
            _contexto.Entry(vitaminas).State = EntityState.Modified;
            return _contexto.SaveChanges() > 0;
        }
        public Vitaminas? Buscar(int vitaminaId)
        {
            return _contexto.Vitaminas
                    .Where(o => o.VitaminaId == vitaminaId)
                    .AsNoTracking()
                    .SingleOrDefault();

        }
        public bool Eliminar(Vitaminas vitaminas)
        {
            _contexto.Entry(vitaminas).State = EntityState.Deleted;
            return _contexto.SaveChanges() > 0;
        }
    }
        