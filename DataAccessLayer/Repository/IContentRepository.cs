using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repository
{
    public interface IContentRepository
    {
        IEnumerable<Content> GetAllContents();
        Content GetContentById(int id);
        void CreateContent(Content content);
        void EditContent(Content content);
        void DeleteContent(Content content);
        void save();

        bool ContentExist(int id);

        IEnumerable<Content> Last3Contents();
        IEnumerable<Content> MostVisitedContent();
        IEnumerable<Content> SearchedContent(string search);

    }
}
