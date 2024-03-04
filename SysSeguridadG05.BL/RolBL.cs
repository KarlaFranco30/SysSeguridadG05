﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias
using SysSeguridadG05.DAL;
using SysSeguridadG05.EN;

namespace SysSeguridadG05.BL
{
    public class RolBL
    {
        public async Task<int> CrearAsync(Rol pRol)
        {
            return await RolDAL.CrearAsync(pRol);
        }

        public async Task<int> ModificarAsync(Rol pRol)
        {
            return await RolDAL.ModificarAsync(pRol);
        }

        public async Task<int> DeleteAsync(Rol pRol)
        {
            return await RolDAL.DeleteAsync(pRol);
        }

        public async Task<Rol> ObtenerPorId(Rol pRol)
        {
            return await RolDAL.ObtenerPorId(pRol);
        }

        public async Task<List<Rol>> ObtenerTodosAsync()
        {
            return await RolDAL.ObtenerTodosAsync();
        }

        public async Task<List<Rol>> BuscarAsync(Rol pRol)
        {
            return await RolDAL.BuscarAsync(pRol);
        }

    }
}