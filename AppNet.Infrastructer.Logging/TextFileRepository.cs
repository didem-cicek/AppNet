using AppNet.Domain.Core;
using AppNet.Domain.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Logging
{
    public class TextFileRepository<TEntity> : IRepository<TEntity> where TEntity: BaseEntity
    {
        private static string FileName
        {
            get
            {
                return typeof(TEntity).FullName.Replace(".", "-") + ".txt";
            }
        }
        private static List<TEntity> list = new List<TEntity>();
        static TextFileRepository()
        {
            LoadListFromFile();
        }

        async public static Task LoadListFromFile()
        {
            if(!File.Exists(FileName))
            {
                list = new List<TEntity>();
                return;
            }

            var text = File.ReadAllText(FileName);
            list = JsonSerializer.Deserialize<List<TEntity>>(text);
        }
        async private static void WriteListToTxt()
        {
            var jsonText = JsonSerializer.Serialize(list);
            File.WriteAllText(FileName, jsonText);
        }

        async Task<TEntity> IRepository<TEntity>.Add(TEntity entity)
        {
            LoadListFromFile();
            list.Add(entity);
            WriteListToTxt();
            return entity;
        }

        async Task<bool> IRepository<TEntity>.Remove(int id)
        {
            LoadListFromFile();
            var deletedCategory = GetById(id);
            if (deletedCategory != null)
            {
                list.Remove((TEntity)deletedCategory);
                WriteListToTxt();
                return true;
            }
            return false;
        }

        private object GetById(int id)
        {
            LoadListFromFile();
            var category = list.FirstOrDefault(c => c.Id == id);
            return category;
        }

        async Task<TEntity> IRepository<TEntity>.GetById(int id)
        {
            LoadListFromFile();
            var category = list.FirstOrDefault(c => c.Id == id);
            return category;
        }

        //async Task<ICollection<TEntity>> IRepository<TEntity>.GetList(Func<TEntity, bool> expression)
        //{
        //    LoadListFromFile();
        //    return expression == null ? list : list.Where(expression).ToList();
        //}

        async Task<TEntity> IRepository<TEntity>.Update(int id, TEntity entity)
        {
            if (id != entity.Id)
            {
                throw new Exception("Id değerleri uyuşmuyor.");
            }

            LoadListFromFile();
            var updated = list.FirstOrDefault(c => c.Id == id);
            if (updated == null)
                throw new Exception("Güncellemek istenilen varlık bulunamadı.");

            list.Remove(updated);
            list.Add(entity);
            WriteListToTxt();
            return entity;
        }

        public ICollection<TEntity> GetList(Func<TEntity, bool> expression = null)
        {
            LoadListFromFile();
            return expression == null ? list : list.Where(expression).ToList();
        }
    }
}