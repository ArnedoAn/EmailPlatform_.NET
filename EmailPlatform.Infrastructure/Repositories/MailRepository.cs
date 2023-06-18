using EmailPlatform.Core.Entities;
using EmailPlatform.Core.Interfaces;
using EmailPlatform.Infrastructure.Data;
using System.Data.SqlClient;
using System.Data;
using System;

namespace EmailPlatform.Infrastructure.Repositories
{
    public class MailRepository : IMailRepository
    {

        private readonly DbContext _dbContext = new();
        


        public Task DeleteMail(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Mail> GetMail(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Mail>> GetMails()
        {
            Console.WriteLine(_dbContext.ConnectionString());
            var mails = new List<Mail>();

            using (var connection = new SqlConnection(_dbContext.ConnectionString()))
            {
                await connection.OpenAsync();

                using (var cmd = new SqlCommand("sp_ListarMensajes", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using(var reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            Mail tempMail = new Mail();
                            tempMail.Id = reader.GetInt32("idMensaje");
                            tempMail.State = reader.GetBoolean("estado");
                            tempMail.Date = reader.GetDateTime("fecha");
                            tempMail.Body = reader.GetString("cuerpo");
                            tempMail.Subject = reader.GetString("asunto");
                            tempMail.ToUser = reader.GetString("to_user");
                            tempMail.FromUser = reader.GetString("from_user");

                            mails.Add(tempMail);
                        }
                    }

                }
            }

            return mails;
        }

        public Task<Mail> UpdateMail(Mail mail)
        {
            throw new NotImplementedException();
        }


    }
}
