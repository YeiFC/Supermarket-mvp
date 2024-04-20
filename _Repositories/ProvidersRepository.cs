using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp.Models;
using System.Data;

namespace Supermarket_mvp._Repositories
{
    internal class ProvidersRepository : BaseRepository, IProvidersRepository
    {
        public ProvidersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ProviderModel providersModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Provider VALUES (@name, @contactName, @contactPhone, @contactEmail)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providersModel.ProviderName;
                command.Parameters.Add("@contactName", SqlDbType.NVarChar).Value = providersModel.ProviderContactName;
                command.Parameters.Add("@contactPhone", SqlDbType.NVarChar).Value = providersModel.ProviderContactPhone;
                command.Parameters.Add("@contactEmail", SqlDbType.NVarChar).Value = providersModel.ProviderEmail;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Provider WHERE Provider_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProviderModel providersModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Provider
                                        SET Provider_Name = @name,
                                            Provider_Contact_Name = @contactName,
                                            Provider_Contact_Phone = @contactPhone,
                                            Provider_Email = @contactEmail
                                        WHERE Provider_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providersModel.ProviderName;
                command.Parameters.Add("@contactName", SqlDbType.NVarChar).Value = providersModel.ProviderContactName;
                command.Parameters.Add("@contactPhone", SqlDbType.NVarChar).Value = providersModel.ProviderContactPhone;
                command.Parameters.Add("@contactEmail", SqlDbType.NVarChar).Value = providersModel.ProviderEmail;
                command.Parameters.Add("@id", SqlDbType.Int).Value = providersModel.ProviderId;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProviderModel> GetAll()
        {
            var providersList = new List<ProviderModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Provider ORDER BY Provider_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providersModel = new ProviderModel();
                        providersModel.ProviderId = (int)reader["Provider_Id"];
                        providersModel.ProviderName = reader["Provider_Name"].ToString();
                        providersModel.ProviderContactName = reader["Provider_Contact_Name"].ToString();
                        providersModel.ProviderContactPhone = reader["Provider_Contact_Phone"].ToString();
                        providersModel.ProviderEmail = reader["Provider_Email"].ToString();
                        providersList.Add(providersModel);
                    }
                }
            }
            return providersList;
        }

        public IEnumerable<ProviderModel> GetByValues(string values)
        {
            var providersList = new List<ProviderModel>();
            int providerId = int.TryParse(values, out _) ? Convert.ToInt32(values) : 0;
            string providerName = values;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Provider
                                       WHERE Provider_Id = @Provider_Id OR Provider_Name LIKE @Provider_Name + '%'
                                       ORDER BY Provider_Id";
                command.Parameters.Add("@Provider_Id", SqlDbType.Int).Value = providerId;
                command.Parameters.Add("@Provider_Name", SqlDbType.NVarChar).Value = providerName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providersModel = new ProviderModel();
                        providersModel.ProviderId = (int)reader["Provider_Id"];
                        providersModel.ProviderName = reader["Provider_Name"].ToString();
                        providersModel.ProviderContactName = reader["Provider_Contact_Name"].ToString();
                        providersModel.ProviderContactPhone = reader["Provider_Contact_Phone"].ToString();
                        providersModel.ProviderEmail = reader["Provider_Email"].ToString();
                        providersList.Add(providersModel);
                    }
                }
            }
            return providersList;
        }
    }
}