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
                        "INSERT INTO Customers (Name, Nesne, Contractor,TypeOfWork, Brigade, Tarih) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                        customer.Name, customer.Nesne, customer.Contractor, customer.TypeOfWork, customer.Brigade, customer.Tarih);
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
                    customers.Tarih = reader["Tarih"].ToString();
                    
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
                        "UPDATE Customers SET Name= '{0}', Nesne= '{1}', Contractor='{2}', TypeOfWork='{3}', Brigade='{4}', Tarih='{5}' WHERE Id= "+newCustomer.Id,
                        newCustomer.Name, newCustomer.Nesne, newCustomer.Contractor, newCustomer.TypeOfWork,
                        newCustomer.Brigade, newCustomer.Tarih);
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

        public List<Materials> SelectMaterials()
        {
            List<Materials> materialsList = new List<Materials>();

            try
            {
                command.CommandText =
                    "SELECT Materials.id, Materials.materialName, Materials.unit, Materials.price, MaterialsSections.sectionName FROM (Materials INNER JOIN MaterialsSections ON Materials.sectionId = MaterialsSections.id)";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Materials materials = new Materials();
                    
                    materials.Id = Convert.ToInt32(reader["Id"].ToString());
                    materials.MaterialName = reader["MaterialName"].ToString();
                    materials.Unit = reader["Unit"].ToString();
                    materials.Price = Convert.ToDouble(reader["Price"].ToString());
                    materials.Section = reader["SectionName"].ToString();
                    materialsList.Add(materials);
                }
                return materialsList;
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

        public void InsertMaterials(Materials materials)
        {
            try
            {
                command.CommandText =
                    string.Format(
                        "INSERT INTO Materials (MaterialName, Unit, Price, SectionId) VALUES ('{0}', '{1}', '{2}', '{3}')",
                        materials.MaterialName, materials.Unit, materials.Price, materials.SectionId);
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

        public void UpdateMaterials(Materials materials)
        {
            try
            {
                command.CommandText =
                    string.Format(
                        "UPDATE Materials SET MaterialName= '{0}', Unit= '{1}', Price='{2}', SectionId='{3}' WHERE Id= " + materials.Id,
                        materials.MaterialName, materials.Unit, materials.Price, materials.SectionId);
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

        public void DeletaMaterial(int material_id)
        {
            try
            {
                command.CommandText = "DELETE FROM Materials WHERE Id= " + material_id;
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

        public List<Works> SelectWorks()
        {
            List<Works> worksList = new List<Works>();

            try
            {
                command.CommandText =
                    "SELECT Works.id, Works.workName, Works.unit, Works.price, WorksSections.sectionName FROM (Works INNER JOIN WorksSections ON Works.sectionId = WorksSections.id)";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Works works = new Works();

                    works.Id = Convert.ToInt32(reader["Id"].ToString());
                    works.WorkName = reader["WorkName"].ToString();
                    works.Unit = reader["Unit"].ToString();
                    works.Price = Convert.ToDouble(reader["Price"].ToString());
                    works.Section = reader["SectionName"].ToString();
                    worksList.Add(works);
                }
                return worksList;
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

        public void InsertWorks(Works works)
        {
            try
            {
                command.CommandText =
                    string.Format(
                        "INSERT INTO Works (WorkName, Unit, Price, SectionId) VALUES ('{0}', '{1}', '{2}', '{3}')",
                        works.WorkName, works.Unit, works.Price, works.SectionId);
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

        public void UpdateWorks(Works works)
        {
            try
            {
                command.CommandText =
                    string.Format(
                        "UPDATE Works SET WorkName= '{0}', Unit= '{1}', Price='{2}', SectionId='{3}' WHERE Id= " + works.Id,
                        works.WorkName, works.Unit, works.Price, works.SectionId);
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

        public List<WorksSections> SelectSectionsWorks()
        {
            List<WorksSections> worksSectionsesList = new List<WorksSections>();
            try
            {
                command.CommandText = "SELECT * FROM WorksSections";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    WorksSections worksSections = new WorksSections();

                    worksSections.Id = Convert.ToInt32(reader["Id"].ToString());
                    worksSections.SectionName = reader["SectionName"].ToString();
                    worksSectionsesList.Add(worksSections);
                }
                return worksSectionsesList;
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

        public void DeleteWork(int work_id)
        {
            try
            {
                command.CommandText = "DELETE FROM Works WHERE Id= " + work_id;
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

        public void InsertSectionsWorks(WorksSections worksSections)
        {
            try
            {
                command.CommandText = string.Format("INSERT INTO WorksSections (SectionName) Values('{0}')", worksSections.SectionName);
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

        public void UpdateWorksSections(WorksSections worksSections)
        {
            try
            {
                command.CommandText =
                    string.Format(
                        "UPDATE WorksSections SET SectionName= '{0}' WHERE Id= " + worksSections.Id,
                        worksSections.SectionName);
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

        public void DeleteWorkSection(int workSectionId)
        {
            try
            {
                command.CommandText = "DELETE FROM WorksSections WHERE Id= " + workSectionId;
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

        public List<Estimate> SelectEstimateById(int customer_id)
        {
            List<Estimate> estimatesList = new List<Estimate>();
            try
            {
                command.CommandText =
                    "SELECT Estimates.id,  Estimates.customerId, Estimates.denotation, Estimates.unit, Estimates.quantity, Estimates.price, Estimates.total FROM Estimates INNER JOIN Customers ON Estimates.customerId = Customers.id WHERE Customers.id = " + customer_id.ToString();
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Estimate estimate = new Estimate();

                    estimate.Id = Convert.ToInt32(reader["Id"].ToString());
                    estimate.Denotation = reader["Denotation"].ToString();
                    estimate.Unit = reader["Unit"].ToString();
                    estimate.Quantity = Convert.ToDouble(reader["Quantity"].ToString());
                    estimate.Price = Convert.ToDouble(reader["Price"].ToString());
                    estimate.Total = Convert.ToDouble(reader["Total"].ToString());
                    estimate.CustomerId = Convert.ToInt32(reader["CustomerId"].ToString());
                    estimatesList.Add(estimate);
                }
                return estimatesList;
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

        public void InsertEstimate(Estimate estimate)
        {
            try
            {
                command.CommandText =
                    string.Format(
                        "INSERT INTO Estimates (Denotation, Unit, Quantity, Price, Total, CustomerId) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                        estimate.Denotation, estimate.Unit, estimate.Quantity, estimate.Price, estimate.Total, estimate.CustomerId);
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

        public List<Estimate> SelectEstimate()
        {
            List<Estimate> estimatesList = new List<Estimate>();
            try
            {
                command.CommandText = "SELECT * FROM Estimates";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Estimate estimate = new Estimate();

                    estimate.Id = Convert.ToInt32(reader["Id"].ToString());
                    estimate.Denotation = reader["Denotation"].ToString();
                    estimate.Unit = reader["Unit"].ToString();
                    estimate.Quantity = Convert.ToDouble(reader["Quantity"].ToString());
                    estimate.Price = Convert.ToDouble(reader["Price"].ToString());
                    estimate.Total = Convert.ToDouble(reader["Total"].ToString());
                    estimate.CustomerId = Convert.ToInt32(reader["CustomerId"].ToString());
                    estimatesList.Add(estimate);
                }
                return estimatesList;
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

        public void UpdateEstimate(Estimate estimate)
        {
            try
            {
                command.CommandText =
                    string.Format(
                        "UPDATE Estimates SET Denotation= '{0}', Unit= '{1}', Quantity='{2}', Price='{3}', Total='{4}' WHERE Id= " + estimate.Id,
                        estimate.Denotation, estimate.Unit, estimate.Quantity, estimate.Price, estimate.Total);
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
