using AutoMapper;
using Business.AutoMapper;
using Core.DataAccess.DataBase.Abstracts;
using Core.Models.Entities.Abstracts;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Services.Specifics
{
    public class BaseMapperService<TDtoEntity, TEntity> : IService<TDtoEntity>
        where TDtoEntity : class, IEntity, new()
        where TEntity : class, new()
    {
        public string name;
        public IRepository<TEntity> _repository;
        public IMapper _mapper;
        public BaseMapperService(IRepository<TEntity> repository)
        {
            _repository = repository;
            name = typeof(TEntity).Name;
            _mapper = AutoMapperConfig.MapperConfiguration.CreateMapper();
        }

        public int Count()
        {
           return _repository.Count();
        }

        public int Count(Expression<Func<TDtoEntity, bool>> predicate)
        {
            Expression<Func<TEntity, bool>> expression = _mapper.Map<Expression<Func<TEntity, bool>>>(predicate); 
            return _repository.Count(expression);
        }

        public dynamic Delete(string id)
        {
            _repository.Delete(id);
            return _repository.Save();
        }

        public dynamic Delete(IEnumerable<string> ids)
        {
            foreach (string id in ids)
            {
                TEntity entity = _repository.GetSingle(id);
                if (entity!=null)
                {
                    _repository.Delete(id);
                }
            }
            return _repository.Save();
        }

        public IEnumerable<TDtoEntity> Get()
        {
            return _mapper.Map<IEnumerable<TDtoEntity>>(_repository.Get());
        }

        public IEnumerable<TDtoEntity> Get(int pag, int element)
        {
            return _mapper.Map<IEnumerable<TDtoEntity>>(_repository.Get(pag,element));
        }

        public IEnumerable<TDtoEntity> Get(Expression<Func<TDtoEntity, bool>> predicate)
        {
            Expression<Func<TEntity, bool>> expression = _mapper.Map<Expression<Func<TEntity, bool>>>(predicate);
            return _mapper.Map<IEnumerable<TDtoEntity>>(_repository.Get(expression));
        }

        public TDtoEntity GetSingle(string id)
        {
            return _mapper.Map<TDtoEntity>(_repository.GetSingle(id));
        }

        public TDtoEntity GetSingle(Expression<Func<TDtoEntity, bool>> predicate)
        {
            Expression<Func<TEntity, bool>> expression = _mapper.Map<Expression<Func<TEntity, bool>>>(predicate);
            return _mapper.Map<TDtoEntity>(_repository.GetSingle(expression));
        }

        public dynamic Insert(TDtoEntity entity)
        {
            TEntity Tentity = _mapper.Map<TEntity>(entity);
            _repository.Insert(Tentity);
            return _repository.Save();
        }

        public dynamic Insert(IEnumerable<TDtoEntity> list)
        {
            foreach (TDtoEntity entity in list)
            {
                TEntity Tentity = _mapper.Map<TEntity>(entity);
                _repository.Insert(Tentity);

            }
            return _repository.Save();
        }

        public dynamic Update(TDtoEntity entity)
        {
            TEntity search = _repository.GetSingle(entity._Id);
            if (search != null)
            {
                TEntity Tentity = _mapper.Map<TEntity>(entity);
                _repository.Update(Tentity);
            }
            return _repository.Save();
        }

        public dynamic Update(IEnumerable<TDtoEntity> list)
        {
            foreach (TDtoEntity entity in list)
            {
                TEntity search = _repository.GetSingle(entity._Id);
                if (search!=null)
                {
                    TEntity Tentity = _mapper.Map<TEntity>(entity);
                    _repository.Update(Tentity);
                }

            }
            return _repository.Save();
        }

    }
}
