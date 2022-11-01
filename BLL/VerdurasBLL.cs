﻿using Microsoft.EntityFrameworkCore;
using Parcial2_Oly.Data;
using System.Linq.Expressions;

namespace Parcial2_Oly.BLL
{
    public class VerdurasBLL
    {
        
        private ApplicationDbContext _contexto;
        public VerdurasBLL(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        public bool Guardar(Verduras verduras)
        {
            if (!Existe(verduras.VerduraId))
                return this.Insertar(verduras);
            else
                return this.Modificar(verduras);

        }
        public bool Existe(int verduraId)
        {
            return _contexto.Verduras.Any(o => o.VerduraId == verduraId);
        }
        private bool Insertar(Verduras verduras)
        {
            _contexto.Verduras.Add(verduras);
            return _contexto.SaveChanges() > 0;
        }
        public bool Modificar(Verduras verduras)
        {
            _contexto.Entry(verduras).State = EntityState.Modified;
            return _contexto.SaveChanges() > 0;
        }
        public Verduras? Buscar(int verdurasId)
        {
            return _contexto.Verduras
                    .Where(o => o.VerduraId == verdurasId)
                    .AsNoTracking()
                    .SingleOrDefault();

        }
        public bool Eliminar(Verduras verduras)
        {
            _contexto.Entry(verduras).State = EntityState.Deleted;
            return _contexto.SaveChanges() > 0;
        }
        public List<Verduras> GetList(Expression<Func<Verduras, bool>> Criterio)
        {
            return _contexto.Verduras
                .AsNoTracking()
                .Where(Criterio)
                .ToList();
        }
    }
}

