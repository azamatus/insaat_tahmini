using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace insaat
{
    class DatabaseOperations
    {
        OleDbConnection connection;
        OleDbCommand command;

        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Aza\Projects\insaat\insaat\insaat.accdb");
            command = connection.CreateCommand();
        }

        public DatabaseOperations()
        {
            ConnectTo();
        }

        public void Insert(Customers customer)
        {
            try
            {
                command.CommandText =
                    string.Format(
                        "INSERT INTO Customers (Name, Nesne, Contractor,TypeOfWork, Brigade) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                        customer.Name, customer.Nesne, customer.Contractor, customer.TypeOfWork, customer.Brigade);
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        
        public List<Customers> fillDGV()
        {
            List<Customers> customersList = new List<Customers>();

            try
            {
                command.CommandText = "SELECT * FROM Customers";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Customers customers = new Customers();

                    customers.Id = Convert.ToInt32( reader["Id"].ToString());
                    customers.Name = reader["Name"].ToString();
                    customers.Nesne = reader["Nesne"].ToString();
                    customers.Contractor = reader["Contractor"].ToString();
                    customers.TypeOfWork = reader["TypeOfWork"].ToString();
                    customers.Brigade = reader["Brigade"].ToString();
                    
                    customersList.Add(customers);
                }
                return customersList;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
 
        }

        public void UpdateCustomer(Customers newCustomer)
        {
            try
            {
                command.CommandText =
                    string.Format(
                        "UPDATE Customers SET Name= '{0}', Nesne= '{1}', Contractor='{2}', TypeOfWork='{3}', Brigade='{4}' WHERE Id= "+newCustomer.Id,
                        newCustomer.Name, newCustomer.Nesne, newCustomer.Contractor, newCustomer.TypeOfWork,
                        newCustomer.Brigade);
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void DeleteCustomer(int customer_id)
        {
            try
            {
                command.CommandText = "DELETE FROM Customers WHERE Id= "+customer_id;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void InsertMaterials()
        {
            
        }

        public void InsertSectionsMaterials(MaterialsSections materialsSections)
        {
            try
            {
                command.CommandText = string.Format("INSERT INTO MaterialsSections (SectionName) Values('{0}')", materialsSections.SectionName);
                command.CommandType = CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<MaterialsSections> SelectSectionsMaterials()
        {
            List<MaterialsSections> materialsSectionsList = new List<MaterialsSections>();
            try
            {
                command.CommandText = "SELECT * FROM MaterialsSections";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    MaterialsSections materialsSections = new MaterialsSections();

                    materialsSections.Id = Convert.ToInt32(reader["Id"].ToString());
                    materialsSections.SectionName = reader["SectionName"].ToString();
                    materialsSectionsList.Add(materialsSections);
                }
                return materialsSectionsList;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void UpdateMaterialsSections(MaterialsSections materialsSections)
        {
            try
            {
                command.CommandText =
                    string.Format(
                        "UPDATE MaterialsSections SET SectionName= '{0}' WHERE Id= " + materialsSections.Id,
                        materialsSections.SectionName);
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void DeleteMaterialsSections(int materialsSectionsId)
        {
            try
            {
                command.CommandText = "DELETE FROM MaterialsSections WHERE Id= " + materialsSectionsId;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

    }
}
