﻿using EnglishTrainer.Entities.Models;

namespace EnglishTrainer.Contracts.EntitiesServices
{
    public interface IExampleService
    {
        IEnumerable<Example> GetAll(Guid wordId, bool trackChanges);

        Example Get(Guid wordId, Guid id, bool trackChanges);
        void CreateForWord(Guid wordId, Example example);
        void DeleteExample(Example example);
    }
}
