using System.Threading.Tasks;
using ForgetMeNot.Services.Interfaces;

namespace ForgetMeNot.Services.Implementations
{
    public class AuthService: IAuthService
    {
        public bool Authorize(string name)
        {
            var isEmpty = string.IsNullOrWhiteSpace(name);
            if (!isEmpty)
            {
                Name = name.Trim();
            }
            return !isEmpty;
        }

        public string Name { get; private set; }
    }
}