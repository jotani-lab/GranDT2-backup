using System;
using System.Collections.Generic;
namespace Interface;
//
public interface IRepoEquipo
{   
    public void AgregarEquipo(Equipo equipo);
    public void EliminarEquipo(Equipo equipo);
    public void ActualizarEquipo(Equipo equipo);
    public List<Equipo> ObtenerEquipos();
}