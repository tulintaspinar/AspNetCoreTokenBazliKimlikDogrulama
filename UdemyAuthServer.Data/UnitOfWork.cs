﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using UdemyAuthServer.Core.UnitOfWork;

namespace UdemyAuthServer.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
