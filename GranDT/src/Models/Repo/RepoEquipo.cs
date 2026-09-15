using Interface;

using Repo;

public class RepoEquipo : IRepoEquipo
{
    private List<Equipo> equipos = new List<Equipo>();

    public void AgregarEquipo(Equipo equipo)
    {
        equipos.Add(equipo);
    }

    public void EliminarEquipo(Equipo equipo)
    {
        equipos.Remove(equipo);
    }

    public void ActualizarEquipo(Equipo equipo)
    {
        var index = equipos.FindIndex(e => e.Nombre == equipo.Nombre);
        if (index != -1)
        {
            equipos[index] = equipo;
        }
    }

    public List<Equipo> ObtenerEquipos()
    {
        return equipos;
    }
}