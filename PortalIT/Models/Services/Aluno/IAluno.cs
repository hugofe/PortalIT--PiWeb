using PortalIT.Models.Domain;

namespace PortalIT.Services.Services
{
    public interface IAluno
    {
        Aluno Create(Aluno aluno);

        Aluno Update(Aluno aluno);

        Aluno Read(int id);

        Aluno Delete(int id);

        Aluno[] List();
    }
}
