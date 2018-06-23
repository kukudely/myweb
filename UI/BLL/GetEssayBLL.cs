using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GetEssayBLL
    {
        GetEssayDAL dal = new GetEssayDAL();
        public GetEssay GetSingleEssayById(int id)
        {

            return dal.GetSingleEssayById(id);

        }
        public List<GetEssay> GetEssayByAuthor(string author)
        {

            return dal.GetEssayByAuthor(author).Count > 0 ? dal.GetEssayByAuthor(author) : null;

        }
        public List<GetEssay> GetAllEssay()
        {
            return dal.GetAllEssay().Count > 0 ? dal.GetAllEssay() : null;
        }
        public bool DeleteEssay(int Id)
        {
            return dal.DeleteEssay(Id) > 0;
        }
        public bool AddEssay(string title,string author)
        {
            return dal.AddEssay(title, author)>0;
        }
    }
}
