

using CompanyInfo.Common.DTOs;
using CompanyInfo.Data.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Collections;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace CompanyInfo.Data.Services
{
    public class DbService : IDbService
    {
        private readonly CompanyInfoContext _db;
        private readonly IMapper _mapper;

        public DbService(CompanyInfoContext db, IMapper mapper) => (_db, _mapper) = (db, mapper);

        public async Task<List<TDto>> GetAsync<TEntity, TDto>() where TEntity : class, IEntity where TDto : class
        {
            var entities = await _db.Set<TEntity>().ToListAsync();
            return _mapper.Map<List<TDto>>(entities);
        }
        public async Task<List<TDto>> ConnectionGetAsync<TReferenceEntity, TDto>() where TReferenceEntity : class, IReferenceEntity where TDto : class
        {
            var entities = await _db.Set<TReferenceEntity>().ToListAsync();
            return _mapper.Map<List<TDto>>(entities);
        }
        private async Task<TEntity?> SingleAsync<TEntity>(Expression<Func<TEntity, bool>> expression) where TEntity : class, IEntity =>
            await _db.Set<TEntity>().SingleOrDefaultAsync(expression);
        public async Task<TDto> SingleAsync<TEntity, TDto>(Expression<Func<TEntity, bool>> expression) where TEntity : class, IEntity where TDto : class
        {
            var entity = await SingleAsync(expression);
            return _mapper.Map<TDto>(entity);
        }
        public async Task<bool> AnyAsync<TEntity>(Expression<Func<TEntity, bool>> expression) where TEntity : class, IEntity =>
            await _db.Set<TEntity>().AnyAsync(expression);
        public async Task<bool> SaveChangesAsync() => await _db.SaveChangesAsync() >= 0;
        public async Task<TEntity> AddAsync<TEntity, TDto>(TDto dto) where TEntity : class where TDto : class
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _db.Set<TEntity>().AddAsync(entity);
            return entity;
        }
        public void Update<TEntity, TDto>(int id, TDto dto) where TEntity : class, IEntity where TDto : class
        {
            var entity = _mapper.Map<TEntity>(dto);
            entity.Id = id;
            _db.Set<TEntity>().Update(entity);
        }
        public async Task<bool> DeleteAsync<TEntity>(int id) where TEntity : class, IEntity
        {
            try
            {
                var entity = await SingleAsync<TEntity>(e => e.Id.Equals(id));
                if (entity is null) return false;
                _db.Remove(entity);
            }
            catch { throw; }

            return true;
        }
        public bool Delete<TReferenceEntity, TDto>(TDto dto) where TReferenceEntity : class where TDto : class
        {
            try
            {
                var entity = _mapper.Map<TReferenceEntity>(dto);
                if (entity is null) return false;
                _db.Remove(entity);
            }
            catch { throw; }

            return true;
        }


        public async Task<List<FullEmployee>> GetEmployee()
        {

            var employees = await _db.Employees
                .Join(_db.Departaments, emp => emp.DepartamentId, d => d.Id, (emp, d) => new { emp, d })
                .Join(_db.DepartamentsNames, d => d.d.DepartamentNameID, dn => dn.Id, (d, dn) => new { d, dn })
                .Join(_db.Companies, d => d.d.d.CompanyID, c => c.Id, (d, c) => new { d, c })
                .Join(_db.Positions, e => e.d.d.emp.Id, p => p.EmployeeId, (e, p) => new { e, p })
                .Join(_db.Jobs, p => p.p.JobId, j => j.Id, (p, j) => new { p, j })
                .Select(res => new FullEmployee()
                {
                    Id = res.p.e.d.d.emp.Id,
                    FirstName = res.p.e.d.d.emp.FirstName,
                    LastName = res.p.e.d.d.emp.LastName,
                    Salary = res.p.e.d.d.emp.Salary,
                    JobTitle = res.j.JobName,
                    DepartamentName = res.p.e.d.dn.DepartamentName,
                    Company = res.p.e.c.CompanyName,
                    Office = res.p.e.c.MainOffice,
                    UnionMember = res.p.e.d.d.emp.UnionMember
                }
                ).ToListAsync();
            return employees;
        }
       

    }
}
