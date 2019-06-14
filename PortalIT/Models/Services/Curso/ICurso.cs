using PortalIT.Models.Domain;

namespace PortalIT.Services.Services
{
    public interface ICurso
    {
        Curso Create(Curso curso);
        
        Curso Update(Curso curso);
        
        Curso Read(int id);
        
        Curso Delete(int id);
        
        Curso[] List();
    }
}
