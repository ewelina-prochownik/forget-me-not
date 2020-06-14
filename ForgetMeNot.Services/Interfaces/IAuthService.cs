using System.Threading.Tasks;

namespace ForgetMeNot.Services.Interfaces
{
    public interface IAuthService
    {
        bool Authorize(string name);
        string Name { get; }
    }
}