using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace DentalClinicApp
{
    internal class LoginLogic
    {
        public bool Authenticate(string role, string id)
        {
            string tableName = role;
            string idColumn = "";

            if (role == "Receptionist")
            {
                idColumn = "Receptionist_ID";
            }
            else if (role == "Doctor")
            {
                idColumn = "Doctor_ID";
            }
            else if (role == "Patient")
            {
                idColumn = "Patient_ID";
            }
            string query = $"SELECT * FROM {tableName} WHERE {idColumn} = '{id}'";

            DataTable dt = DBHelper.GetData(query);
            return dt.Rows.Count > 0;
        }
    }
}
