﻿using IntegradorSofttekImanol.Models.Entities;

namespace IntegradorSofttekImanol.Models.Interfaces.RepoInterfaces
{
    /// <summary>
    /// This interface defines extra repository operations related to the Servicio entity
    /// </summary>
    public interface IServicioRepository : IRepository<Servicio>
    {
        /// <summary>
        /// Gets all the active services
        /// </summary>
        /// <returns>All the active services</returns>
        public Task<IEnumerable<Servicio>> GetActiveServiciosAsync();

    }
}
