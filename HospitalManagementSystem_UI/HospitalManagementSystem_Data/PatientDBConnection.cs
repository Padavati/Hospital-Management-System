using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HospitalManagementSystem_Entity;
using System.Data.SqlClient;

namespace HospitalManagementSystem_Data
{
    public class PatientDBConnection
    {
        string sqlConnectionStr = "Data Source=LAPTOP-DL0P9UEA;Initial Catalog=HMS;Integrated Security=True";
        public string InsertPatientInfo(PatientInfo patientInfoObj)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter("Insert into PatientInfo values('" + patientInfoObj.PatientName + "','" + patientInfoObj.Issue + "','" + patientInfoObj.ReferralDoct + "',"+patientInfoObj.EmpID+","+patientInfoObj.EmpName+",'"+patientInfoObj.PatientStatus+"')", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return "Doctor Information Inserted Successfully";
        }
        public string UpdatePatientInfo(PatientInfo patientInfoObj)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter("Update PatientInfo set PatientName='" + patientInfoObj.PatientName + "',Issue='" + patientInfoObj.Issue + "',ReferralDoct='" + patientInfoObj.ReferralDoct + "',EmpID=" + patientInfoObj.EmpID + "',EmpName='"+patientInfoObj.EmpName+"',PatientStatus='"+patientInfoObj.PatientStatus+ "' where PatientID=" + patientInfoObj.PatientID + "", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return "Doctor Information Updated Successfully";
        }
        public DataTable EditPatientInfoByID(int PatientID)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(" select*from PatientInfo where PatientID=" + PatientID + "", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return dataTableObj;
        }
        public DataTable SelectPatientInfo()
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(" select*from PatientInfo", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return dataTableObj;
        }
        public string DeletePatientInfoByID(int PatientID)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(" Delete from DoctorInfo where PatientID=" + PatientID + "", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return "Deleted Successfully";
        }

    }
}
