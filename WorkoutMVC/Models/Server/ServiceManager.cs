using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.Net;
using System.Configuration;
using LibMyWorkout.Domain;
using System.Collections;

namespace WorkoutMVC.Models.Server
{
    public class ServiceManager
    {
        
        public Hashtable createUser(Hashtable hashTable)
        {
            User user = null;
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Hashtable rtTable = new Hashtable();
            bool status = false;
            string errorMessage = "";
            NetworkStream stream = null;

            try
            {
                int port = Int32.Parse(ConfigurationManager.AppSettings["Port"]);
                IPAddress ipAddress = IPAddress.Parse(ConfigurationManager.AppSettings["IPAddress"]);
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, port);
                socket.Connect(ipEndPoint);

                stream = new NetworkStream(socket);
                BinaryReader reader = new BinaryReader(stream);
                BinaryWriter writer = new BinaryWriter(stream);
                BinaryFormatter fm = new BinaryFormatter();
                fm.AssemblyFormat = FormatterAssemblyStyle.Simple;

                writer.Write("AddUser");
                writer.Flush();
                fm.Serialize(stream, hashTable);
                stream.Flush();

                string userNameTaken = reader.ReadString();

                if(userNameTaken.Equals("User Created"))
                {
                    user = (User) fm.Deserialize(stream);
                    status = true;
                    rtTable.Add("User", user);
                }else if(userNameTaken.Equals("UserName Taken"))
                {
                    status = false;
                    errorMessage = "UserName Taken";
                }


            }catch(Exception ex)
            {
                Console.WriteLine("Error : ServiceManager : createuser : " + ex.Message);
            }
            finally
            {
                stream.Close();
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }

            rtTable.Add("Status", status);
            rtTable.Add("ErrorMessage", errorMessage);

            return rtTable;
        }
        
        public Hashtable getUser(string userName, string password)
        {
            User user = null;
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Hashtable rtTable = new Hashtable();
            bool status = false;
            string errorMessage = "";
            NetworkStream stream = null;

            try
            {
                int port = Int32.Parse(ConfigurationManager.AppSettings["Port"]);
                IPAddress ipAddress = IPAddress.Parse(ConfigurationManager.AppSettings["IPAddress"]);
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, port);
                socket.Connect(ipEndPoint);

                stream = new NetworkStream(socket);
                BinaryReader reader = new BinaryReader(stream);
                BinaryWriter writer = new BinaryWriter(stream);
                BinaryFormatter fm = new BinaryFormatter();
                fm.AssemblyFormat = FormatterAssemblyStyle.Simple;

                writer.Write("GetUser");
                writer.Flush();
                writer.Write(userName);
                writer.Write(password);
                writer.Flush();

                string message = reader.ReadString();

                if (message.Equals("User Found"))
                {
                    user = (User)fm.Deserialize(stream);
                    status = true;
                    rtTable.Add("User", user);
                }
                else if (message.Equals("User Not Found"))
                {
                    errorMessage = "Wrong Username or Password";
                    Console.WriteLine(errorMessage);
                    status = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : ServiceManager : getUser : " + ex.Message);
            }
            finally
            {
                stream.Close();
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }

            rtTable.Add("Status", status);
            rtTable.Add("ErrorMessage", errorMessage);

            return rtTable;
        }


    }
}