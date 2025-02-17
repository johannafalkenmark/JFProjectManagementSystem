﻿using Data.Contexts;
using Data.Entities;
namespace Data.Repositories;

public class UserRepository(DataContext context) : BaseRepository<UserEntity>(context)

{
    private readonly DataContext _context = context;
}


