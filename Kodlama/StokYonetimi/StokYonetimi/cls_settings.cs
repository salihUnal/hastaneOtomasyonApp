﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Data.SqlClient;

namespace StokYonetimi
{
    public static class cls_settings
    {
       public static string connectionString = "";

       private static string _server;

       public static string Server
       {
           get { return _server; }
           set { _server = value; }
       }

       public static string _database;

       public static string Database
       {
           get { return _database; }
           set { _database = value; }
       }

       public static string _user;

       public static string User
       {
           get { return _user; }
           set { _user = value; }
       }

       public static string _password;

       public static string Password
       {
           get { return _password; }
           set { _password = value; }
       }

       public static bool _security;

       public static bool Security
       {
           get { return _security; }
           set { _security = value; }
       }

       public static bool SettingsOku()
       {

           string sec;
           byte _sec;

           DataSet ds = new DataSet();
           if (File.Exists(Application.StartupPath + "\\Settings.xml") == false)
           {
               DosyaOlustur();
           }
           ds.ReadXml(Application.StartupPath + "\\Settings.xml");
           _server = ds.Tables[0].Rows[0][0].ToString();
           _database = ds.Tables[0].Rows[0][1].ToString();
           _user = ds.Tables[0].Rows[0][2].ToString();
           _password = ds.Tables[0].Rows[0][3].ToString();
           sec = ds.Tables[0].Rows[0][4].ToString();

           if (sec != "")
           {
               _sec = Convert.ToByte(sec);

               if (_sec == 0)
                   _security = false;
               else
                   _security = true;
           }

           if (TestConnection(ConnectionString()) == true)
           {
               connectionString = ConnectionString();
               return true;
           }
           else
               return false;

       }

       public static void DosyaOlustur()
       {
           XmlTextWriter textWriter = new XmlTextWriter(Application.StartupPath + "\\Settings.xml", System.Text.Encoding.GetEncoding(1254));
           textWriter.Formatting = Formatting.Indented;
           textWriter.WriteStartDocument(false);
           textWriter.WriteStartElement("ConnSettings");
           textWriter.WriteStartElement("Settings");
           textWriter.WriteElementString("Server", "");
           textWriter.WriteElementString("DataBase", "");
           textWriter.WriteElementString("User", "");
           textWriter.WriteElementString("Password", "");
           textWriter.WriteElementString("Security", "");

           textWriter.Flush();
           textWriter.Close();
       }

       public static bool TestConnection(string ConnectionString)
       {
           SqlConnection conn = new SqlConnection(ConnectionString);
           try
           {

               conn.Open();
               conn.Close();
               return true;
           }
           catch (Exception)
           {
               return false;
           }

       }

       public static string ConnectionString()
       {
           if (_security == false)
           {               
               return "Server=" + _server + ";initial catalog=" + _database + ";User ID=" + _user + ";Password=" + _password + ";Pooling=false";
           }
           else
           {
               return "Data Source=" + _server +
                  ";Initial Catalog=" + _database +
                  ";Integrated Security=SSPI";
           }
       }
    }


}
