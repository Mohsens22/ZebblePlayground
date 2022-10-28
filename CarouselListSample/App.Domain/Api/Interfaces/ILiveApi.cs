using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Api.Interfaces
{
    partial interface ILiveApi
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategory(string Name);
        Task<List<Subject>> GetSubjects(string CategoryName);
        Task<Subject> GetSubject(string Name);
        Task<List<WordInfo>> GetWordInfos(string SubjectName);
        Task<WordInfo> GetWordInfo(string WordText);
    }
}
