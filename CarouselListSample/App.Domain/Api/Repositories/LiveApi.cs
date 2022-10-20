using Domain.Api.Interfaces;
using Domain.Models;
using Newtonsoft.Json;
using Olive;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zebble;

namespace Domain.Api.Repositories
{
    public class LiveApi : BaseApi, ILiveApi
    {
        private string baseUrl = "https://gist.githubusercontent.com/Mohsens22/d86950de0661b2b9f5dc6cdabcc9e71f/raw/50a989ae82b4b09f091ee8dc31a7f1d3f0304ab5/categories.json";

        public List<Category> categories { get; private set; }
        public async Task<List<Category>> GetCategories()
        {
            var temp = await Zebble.Device.Network.FromCacheOrDownload(new Uri(baseUrl), 2, 60);
            return categories = JsonConvert.DeserializeObject<List<Category>>(Encoding.UTF8.GetString(temp));
        }

        public Task<Category> GetCategory(string Name)
        {
            throw new NotImplementedException();
        }

        public Task<Subject> GetSubject(string Name)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Subject>> GetSubjects(string CategoryName)
        {
            return categories.SelectMany(x => x.Subjects).ToList();
        }

        public Task<WordInfo> GetWordInfo(string WordText)
        {
            throw new NotImplementedException();
        }

        public Task<List<WordInfo>> GetWordInfos(string SubjectName)
        {
            throw new NotImplementedException();
        }
    }
}
