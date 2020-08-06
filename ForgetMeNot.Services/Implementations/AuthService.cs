using System;
using ForgetMeNot.DAL;
using ForgetMeNot.DAL.Model;
using ForgetMeNot.Services.Interfaces;

namespace ForgetMeNot.Services.Implementations
{
    public class AuthService: IAuthService
    {
        private readonly EfCoreContext _context;

        public AuthService(EfCoreContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }
        public bool Authorize(string name)
        {
            var plant = new Plant
            {
                Name = "Storczyk"
            };

            try
            {
                using (var con = _context)
                {
                    con.Plants.Add(plant);
                    con.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
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