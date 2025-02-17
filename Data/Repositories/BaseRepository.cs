﻿using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Data.Repositories;

public abstract class BaseRepository<TEntity>(DataContext context) : IBaseRepository<TEntity> where TEntity : class //säkerställer att det är en klass
{
    private readonly DataContext _context = context;
    private readonly DbSet<TEntity> _dbSet = context.Set<TEntity>();

    //CREATE
    //Virtual gör det möjligt att skriva över/göra eventuella justeringar som önskas i de olika repositories 
    public virtual async Task<TEntity> CreateAsync(TEntity entity)
    {
        if (entity == null)
            return null!;
        try
        {


            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;

        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error creating {nameof(TEntity)} :: {ex.Message}");
            return null!;
        }
    }


    //READ
    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }



    public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
    {//Skickar ned  entity får tillbaka ett bool värde ovan om hittad eller ej. Gjort denna mer flexibel.

        if (expression == null)
            return null!;

        return await _dbSet.FirstOrDefaultAsync(expression) ?? null!;
    }



    //UPDATE
    public virtual async Task<TEntity> UpdateAsync(Expression<Func<TEntity, bool>> expression, TEntity updatedEntity)
    {

        if (updatedEntity == null)
            return null!;
        try
        {
            var existingEntity = await _dbSet.FirstOrDefaultAsync(expression) ?? null!;
            if (existingEntity == null)
                return null!;


            _context.Entry(existingEntity).CurrentValues.SetValues(updatedEntity);
            await _context.SaveChangesAsync();
            return existingEntity;

        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error updating {nameof(TEntity)} :: {ex.Message}");
            return null!;
        }
    }


    //DELETE
    public virtual async Task<bool> DeleteAsync(Expression<Func<TEntity, bool>> expression)
    {

        if (expression == null)
            return false!;

        try
        {
            var existingEntity = await _dbSet.FirstOrDefaultAsync(expression) ?? null!;
            if (existingEntity == null)
                return false;

            _dbSet.Remove(existingEntity);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error deleting {nameof(TEntity)} :: {ex.Message}");
            return false;
        }

    }

    //Kontrollerar om finns eller inte, bara hämta om den finns, kolla av det innan.nedan skickar då bool värde (any)
    public virtual async Task<bool> AlreadyExistsAsync(Expression<Func<TEntity, bool>> expression)
    {
        return await _dbSet.AnyAsync(expression);
    }
}
