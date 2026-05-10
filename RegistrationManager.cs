using System;
using System.Data;

namespace DentalClinicApp
{
    internal class RegistrationManager
    {
        public int GetNextID(string tableName, string idColumn)
        {
            try
            {
                if (string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(idColumn))
                {
                    return 1;
                }

                string query = $"SELECT MAX({idColumn}) FROM {tableName}";

                DataTable dt = DBHelper.GetData(query);

                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    return Convert.ToInt32(dt.Rows[0][0]) + 1;
                }
                return 1;
            }
            catch
            {
                return 1;
            }
        }

        public int RegisterPatient(string name, string gender, DateTime bdate, string city, string country, string blood, string phone)
        {
            int newID = GetNextID("Patient", "Patient_ID");

            string sqlPatient = $"INSERT INTO Patient (Patient_ID, Name, Gender, Bdate, City, Country, Blood_Type) " +
                               $"VALUES ({newID}, '{name}', '{gender}', '{bdate:yyyy-MM-dd}', '{city}', '{country}', '{blood}')";
            DBHelper.SetData(sqlPatient);

            string sqlPhone = $"INSERT INTO Patient_Phone (Patient_ID, Phone_Number) VALUES ({newID}, '{phone}')";
            DBHelper.SetData(sqlPhone);
            return newID;
        }

        public int RegisterDoctor(string name, string gender, string speciality, string email)
        {
            int newID = GetNextID("Doctor", "Doctor_ID");
            string sql = $"INSERT INTO Doctor (Doctor_ID, Name, Gender, Speciality, Email) " +
                         $"VALUES ({newID}, '{name}', '{gender}', '{speciality}', '{email}')";
            DBHelper.SetData(sql);
            return newID;
        }

        public int RegisterReceptionist(string name, string gender, DateTime bdate, string email)
        {
            int newID = GetNextID("Receptionist", "Receptionist_ID");

            string sql = $"INSERT INTO Receptionist (Receptionist_ID, Name, Gender, Bdate, Email) " +
                         $"VALUES ({newID}, '{name}', '{gender}', '{bdate:yyyy-MM-dd}', '{email}')";

            DBHelper.SetData(sql);
            return newID;
        }
    }
}