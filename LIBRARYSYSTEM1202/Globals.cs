using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;



namespace LIBRARYSYSTEM1202
{
    class Globals
    {
        DBConnect dbConn;
        SqlCommand CMD;
        SqlDataReader Reader;
        public static string ID,proctoprint,history;
        string fcode;
        public Globals()
        {
            dbConn = new DBConnect(); if (dbConn.connection.State != ConnectionState.Open) dbConn.Open();
        }
        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        public string base64Encode(string data) //Encryption
        {
            try
            {
                byte[] encData_byte = new byte[data.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(data);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception e)
            {
                throw new Exception("Error in base64Encode" + e.Message);
            }
        }
        public string base64Decode2(string sData) //Decryption
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(sData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }
        public void Gen_Code(TextBox CodeTxt, string table, string field, string Prefix)
        {


            CMD = new SqlCommand("SELECT TOP 1 " + field + " FROM " + table + " WHERE LEN(" + field + ") = 7 ORDER BY " + field + " DESC", dbConn.connection);
            Reader = CMD.ExecuteReader();
            if (Reader.Read())
            {
                string strid = Reader[field].ToString().Substring(2, 5);
                int id = Convert.ToInt32(strid);
                id++;
                CodeTxt.Text = string.Format("{0:" + Prefix + "00000}", id);
            }
            else
            {
                CodeTxt.Text = string.Format("{0:" + Prefix + "00000}", 1);
            }
        }
        public void LoadER(string Table, string field, string field2, string fieldtofind, ComboBox combovalue)
        {
            CMD = new SqlCommand("SELECT distinct(" + field + ")," + field2 + " FROM " + Table + " where " + fieldtofind + " = '" + combovalue.Text + "' ORDER BY Track ASC", dbConn.connection);
            Reader = CMD.ExecuteReader();

            while (Reader.Read())
            {
                combovalue.Items.Add(Reader["Track"]);


            }
        }

        public void UpdateCode(string table, string prefix, string value, string fieldtoinc)
        {

            CMD = new SqlCommand("SELECT * FROM " + table + "  WHERE " + prefix + " = '" + value + "' ", dbConn.connection);
            Reader = CMD.ExecuteReader();
            if (Reader.Read())
            {
                string dcode = Reader[fieldtoinc].ToString();
                int newcode = Convert.ToInt32(dcode);
                newcode = newcode + 1;
                string ncode = newcode.ToString();
                int nameLength = ncode.Length;
                if (nameLength == 1)
                {
                    fcode = "000000" + ncode;
                }

                if (nameLength == 2)
                {
                    fcode = "00000" + ncode;
                }
                if (nameLength == 3)
                {
                    fcode = "0000" + ncode;
                }
                if (nameLength == 4)
                {
                    fcode = "0000" + ncode;
                }
                CMD = new SqlCommand("UPDATE " + table + " SET " + fieldtoinc + " =  '" + fcode + "' where " + prefix + " = '" + value + "' ", dbConn.connection);
                CMD.ExecuteNonQuery();
            }

        }


    }
    
}
