using SitemaDeTarefas.Models;

namespace SitemaDeTarefas.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UserModel>> GetAllUsers();

        Task<UserModel> GetUserById(int id);

        Task<UserModel> AddUser(UserModel user);

        Task<UserModel> UpdateUser(UserModel user, int id);

        Task<Boolean> DeleteUser(int id);
    }
}
