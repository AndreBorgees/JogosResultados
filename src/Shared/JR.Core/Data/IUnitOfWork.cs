﻿namespace JR.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
