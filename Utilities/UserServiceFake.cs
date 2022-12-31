using System;
namespace c_sharp_entity_framework.Utilities
{
    public class UserServiceFake : IUserService
    {
        public string GetUserId()
        {
            return "Fellipe 2";
        }
    }
}

