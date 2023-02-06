using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class ChildRepository : IChildRepository
    {
        private readonly Icontext _context;

        public ChildRepository(Icontext context)
        {
            _context = context;
        }

        public async Task<Child> AddAsync(int id, string lastName, string firstName, DateTime birthDate, User parent)
        {
            var child =new Child() { Id = id, LastName = lastName, FirstName = firstName,Parent = parent,BirthDate=birthDate};
            _context.Children.Add(child);
            await _context.SaveChangesAsync();
            return child;
        }

        public Task DeleteAsync(int id)
        {
          
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.ToListAsync();
        }

        public Task<Child> GetByIdAsync(int id)
        {
           
        }

        public Task<Child> UpdateAsync(int id, Child child)
        {
            throw new NotImplementedException();
        }
    }
}
