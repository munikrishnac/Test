
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using Secura;
using VehicleApi.Models.Models;

namespace GetDetails
{
    public class GetDetails
    {
        private static readonly string DatabaseconnString = ConfigurationManager.ConnectionStrings["anpr_connectionstring"].ConnectionString;
        
        public static CombineClass Alarm()
        {
            CombineClass combineClass = new CombineClass();
            using (IDbConnection dbConnection = new MySqlConnection(DatabaseconnString))
            {
                try
                {
                    dbConnection.Open();
                    string sql = "";
                    sql = "SELECT ID,JunctionID,JunctionName,JunctionLocation,Latitude,Longitude,CameraImageLocation,SourceLocation,AreaID,JunctionIP,AreaCode " +
                            " FROM junctionmaster where IsDelete=0 order by ID";
                    combineClass.junctionMaster = dbConnection.Query<JunctionMaster>(sql);

                    sql = "SELECT ID,Name,JunctionId,Latitude,Longitude,IsDelete,CameraName " +
                            " FROM polemaster  where IsDelete=0 ";
                    combineClass.poleMaster = dbConnection.Query<PoleMaster>(sql);

                    sql = "SELECT CameraGuid,CameraName,SourceVMS,ChannelWidth,AnalyticsConfig,CameraURl,Pushed " +
                            " FROM camera where IsDelete=0 ";
                    combineClass.camera = dbConnection.Query<Camera>(sql);

                    sql = "SELECT PoleCameraMappingId,CameraGUID,CameraName,IsDelete FROM polecameramapping where IsDelete=0 ";
                    combineClass.poleCameraMapping = dbConnection.Query<PoleCameraMapping>(sql);

                    return combineClass;
                }
                catch (Exception ex)
                {
                    throw new NotImplementedException();
                }
                finally
                {
                    if (dbConnection.State == ConnectionState.Open)
                    {
                        dbConnection.Close();
                    }
                }
            }            
        }
    }
}
