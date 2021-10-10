using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Assignment.Models;
using Assignment.Persistance;

namespace Assignment.Data
{
    public class AdultData : IAdultData
    {
        private IList<Adult> adults;
        private FileContext content;

        public AdultData()
        {
            content = new FileContext();
            adults = content.Adults;
        }

        public IList<Adult> GetAdults()
        {
            return content.Adults;
        }

        public void AddAdult(Adult adult)
        {
            int max = content.Adults.Max(adult => adult.Id);
            adult.Id = (++max);
            content.Adults.Add(adult);
            content.SaveChanges();
        }

        public void RemoveAdult(Adult adult)
        {
            // Adult toRemove = adults.First(t => t.Id == id);
            content.Adults.Remove(adult);
            content.SaveChanges();
        }

        public void Update(Adult adult)
        {
            Adult update = adults.First(t => t.Id == adult.Id);
            update.FirstName = adult.FirstName;
            update.LastName = adult.LastName;
            update.HairColor = adult.HairColor;
            update.EyeColor = adult.EyeColor;
            update.Age = adult.Age;
            update.Height = adult.Height;
            update.Weight = adult.Weight;
            update.Sex = adult.Sex;
            update.JobTitle = adult.JobTitle;
            content.SaveChanges();
        }

        public Adult Get(int id)
        {
            return adults.FirstOrDefault(t => t.Id == id);
        }
    }
}