﻿namespace Antertainment.DAL.Entities;

public class User
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
}