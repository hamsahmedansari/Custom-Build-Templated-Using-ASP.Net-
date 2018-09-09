using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Connection
/// HAMS AHMED ANSARI
/// </summary>
public class Connection
{
    private string strConnectionString;
    public SqlConnection OpenConnection()
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = strConnectionString;
        conn.Open();
        return conn;
    }
    public SqlParameter CreateStringParameter(string parameterName, object parameterValue, int parameterSize)
    {
        SqlParameter parameter = new SqlParameter();
        parameter.ParameterName = parameterName;
        parameter.SqlDbType = SqlDbType.VarChar;
        parameter.Size = parameterSize;
        parameter.Value = parameterValue;
        return parameter;
    }
    public SqlParameter CreateTextParameter(string parameterName, object parameterValue)
    {
        SqlParameter parameter = new SqlParameter();
        parameter.ParameterName = parameterName;
        parameter.SqlDbType = SqlDbType.Text;
        //parameter.Size = parameterSize;
        parameter.Value = parameterValue;
        return parameter;
    }
    public SqlParameter CreateIntegerParameter(string parameterName, object parameterValue)
    {
        SqlParameter parameter = new SqlParameter();
        parameter.ParameterName = parameterName;
        parameter.SqlDbType = SqlDbType.Int;
        parameter.Value = parameterValue;
        return parameter;
    }
    public SqlParameter CreateDecimalParameter(string parameterName, object parameterValue)
    {
        SqlParameter parameter = new SqlParameter();
        parameter.ParameterName = parameterName;
        parameter.SqlDbType = SqlDbType.Decimal;
        parameter.Value = parameterValue;
        return parameter;
    }
    public SqlParameter CreateMoneyParameter(string parameterName, object parameterValue)
    {
        SqlParameter parameter = new SqlParameter();
        parameter.ParameterName = parameterName;
        parameter.SqlDbType = SqlDbType.Money;
        parameter.Value = parameterValue;
        return parameter;
    }
    public SqlParameter CreateDateParameter(string parameterName, object parameterValue)
    {
        SqlParameter parameter = new SqlParameter();
        parameter.ParameterName = parameterName;
        parameter.SqlDbType = SqlDbType.DateTime;
        parameter.Value = parameterValue;
        return parameter;
    }
    public SqlParameter CreateBooleanParameter(string parameterName, object parameterValue)
    {
        SqlParameter parameter = new SqlParameter();
        parameter.ParameterName = parameterName;
        parameter.SqlDbType = SqlDbType.Bit;
        parameter.Value = parameterValue;
        return parameter;
    }
    public SqlParameter CreateNvarCharParameter(string parameterName, object parameterValue)
    {
        SqlParameter parameter = new SqlParameter();
        parameter.ParameterName = parameterName;
        parameter.SqlDbType = SqlDbType.NVarChar;
        parameter.Value = parameterValue;
        return parameter;
    }
    public Connection(string strConnection)
    {
        this.strConnectionString = strConnection;
    }
}
