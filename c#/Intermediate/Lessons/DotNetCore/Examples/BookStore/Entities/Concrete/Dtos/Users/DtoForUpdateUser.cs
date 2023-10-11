﻿namespace Entity.Concrete.Dtos.Users
{
    public record DtoForUpdateUser
    {
        public string Name { get; init; }
        public string Surname { get; init; }
        public string Username { get; init; }
        public string Password { get; init; }
        public string Email { get; init; }
    }
}
