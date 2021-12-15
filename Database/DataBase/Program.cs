using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using MySqlConnector;

namespace DataBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Computer> listComputers = new List<Computer>();
                string xmlDocument = File.ReadAllText(@"C:\Users\Liene\Desktop\.NET_practical_tasks\Database\xmlFile.xml");
                XmlDocument xmlDataDocument = new XmlDocument();
                xmlDataDocument.LoadXml(xmlDocument);
                XmlNodeList computerListNodes = xmlDataDocument.GetElementsByTagName("Computer");
                foreach (XmlElement computerNode in computerListNodes)
                {
                    Computer computer = new Computer();
                    computer.ID = Int32.Parse(computerNode.GetAttribute("ID"));
                    foreach (XmlElement computerElement in computerNode)
                    {
                        string elementText = computerElement.InnerText;
                        switch (computerElement.Name)
                        {
                            case "Name":
                                computer.Name = elementText;
                                break;
                            case "Developer":
                                computer.Developer = elementText;
                                break;
                            case "OS Family":
                                computer.OSFamily = elementText;
                                break;
                            case "Latest Version":
                                computer.LatestVersion = elementText;
                                break;
                        }
                    }
                    listComputers.Add(computer);
                }

                Migrate(listComputers);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        static void Migrate(List<Computer> computers)
        {
            MySqlConnection con = new MySqlConnection("Data Source=localhost;User ID=root;Database=dotnet2");
            con.Open();
            foreach (Computer computer in computers)
            {
                string query = "INSERT INTO computers (`Name`, `Developer`, `OSFamily`, `LatestVersion`, `External_ID`) " +
                    "VALUES (@name,@developer,@osFamily,@latestVersion,@external_id)";


                MySqlParameter nameParam = new MySqlParameter("@name", MySqlDbType.VarChar);
                MySqlParameter developer = new MySqlParameter("@developer", MySqlDbType.VarChar);
                MySqlParameter osFamily = new MySqlParameter("@osFamily", MySqlDbType.VarChar);
                MySqlParameter latestVersion = new MySqlParameter("@latestVersion", MySqlDbType.VarChar);
                MySqlParameter extId = new MySqlParameter("@external_id", MySqlDbType.Int32);

                var command = new MySqlCommand(query, con);
                command.Parameters.Add(nameParam);
                command.Parameters[0].Value = computer.Name;

                command.Parameters.Add(developer);
                command.Parameters[1].Value = computer.Developer;

                command.Parameters.Add(osFamily);
                command.Parameters[2].Value = computer.OSFamily;

                command.Parameters.Add(latestVersion);
                command.Parameters[3].Value = computer.LatestVersion;

                command.Parameters.Add(extId);
                command.Parameters[4].Value = computer.ID;

                command.Prepare();
                command.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
