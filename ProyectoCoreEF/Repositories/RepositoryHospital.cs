using ProyectoCoreEF.Data;
using ProyectoCoreEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCoreEF.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;

        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }
        //METODO PARA DEVOLVER TODOS LOS HOSPITALES
        public List<Hospital> GetHospitales()
        {
            //LAS CONSULTAS LINQ SE ALMACENAN EN UN NUEVO TIPO DE DATO. ES UN TIPO DINAMICO LLAMADO var
            var consulta = from datos in this.context.Hospitales
                           select datos;
            return consulta.ToList();
        }
        public Hospital FindHospital(int id)
        {
            var consulta = from datos in this.context.Hospitales
                           where datos.IdHospital == id
                           select datos;

            //PUDIERA SER QUE NO DEVOLVIERA HOSPITALES. DEBEMOS AVERIGUAR SI EXISTE UN HOSPITAL O NO DENTRO DE LA CONSULTA.
            if (consulta.Count() == 0)
            {
                return null;
            }
            else
            {
                //DEVOLVEMOS EL PRIMER Y UNICO HOSPITAL QUE EXISTE CON ESE ID
                return consulta.First();
            }
        }
    }
}
