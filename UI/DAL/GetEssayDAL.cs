using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GetEssayDAL
    {
        public List<GetEssay> GetEssayByAuthor(string author)
        {

            string sql = "select id,title,author,textpath from UserEssay where author = @author";
            SqlParameter para = new SqlParameter("@author", author);
            SqlDataReader reader = SqlHelper.ExecuteReader(sql, para);
            List<GetEssay> essayList = new List<GetEssay>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    GetEssay essay = new GetEssay();
                    essay.Id = Convert.ToInt32(reader["id"]);
                    essay.Title = reader["title"].ToString();
                    essay.Author = reader["author"].ToString();
                    essay.Textpath = reader["textpath"].ToString();
                    essayList.Add(essay);
                }
            }
            reader.Close();
            return essayList;
        }
        public GetEssay GetSingleEssayById( int id)
        {
            string sql = "select id,title,author,textpath from UserEssay where id = @id";
            SqlParameter para = new SqlParameter("@id", id);
            SqlDataReader reader = SqlHelper.ExecuteReader(sql, para);
            GetEssay essay = null;
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    essay = new GetEssay();
                    essay.Id = Convert.ToInt32(reader["id"]);
                    essay.Title = reader["title"].ToString();
                    essay.Author = reader["author"].ToString();
                    essay.Textpath = reader["textpath"].ToString();
                    

                }
            }
            reader.Close();
            return essay;
        }
        public List<GetEssay> GetAllEssay()
        {
            string sql = "select * from UserEssay";
            List<GetEssay> essayList = new List<GetEssay>();
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        GetEssay ess = new GetEssay();
                        ess.Id = reader.GetInt32(0);
                        ess.Title = reader.GetString(1);
                        ess.Author = reader.GetString(2);
                        essayList.Add(ess);
                    }
                }
            }
            return essayList;
        }
        public int DeleteEssay(int Id)
        {
            string sql = "delete UserEssay where id=@ID";
            int count = SqlHelper.ExecuteNonQuery(sql, new SqlParameter("@ID", Id));
            return count;
        }
        public int AddEssay(string title,string author)
        {
            string sql = "insert into UserEssay values (@title,@author,@textpath)";
            SqlParameter[] para = {
                new SqlParameter("@title",title),
                new SqlParameter("@author",author),
                new SqlParameter("@textpath","/txt/t1.txt"),
            };
            int count = SqlHelper.ExecuteNonQuery(sql, para);
            return count;
        }
    }
}
