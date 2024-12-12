using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class sqldata
{
    OracleConnection conn = new OracleConnection("Data Source = prod; User Id = jan_it; Password=Ya7Hum06Ey#wa6uM");
    OracleCommand cmd = new OracleCommand();
    OracleDataAdapter adp = new OracleDataAdapter();
    OracleDataReader rd;
    String PT;

    public DataSet sqlselect(String sql, String dsname)
    {
        DataSet dsna = new DataSet();
        adp = new OracleDataAdapter(sql, conn);
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
        adp.Fill(dsna, dsname);
        conn.Close();
        return dsna;
    }

    public DataTable sqlpass(String sql)
    {
        DataTable dt = new DataTable();
        adp = new OracleDataAdapter(sql, conn);
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
        adp.Fill(dt);
        return dt;
    }

    public OracleDataReader sqlread(String sql)
    {
        cmd = new OracleCommand(sql);
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
        cmd.Connection = conn;
        rd = cmd.ExecuteReader();
        return rd;
    }

    public OracleCommand sqlsave(String sql)
    {
        cmd = new OracleCommand(sql, conn);
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
        cmd.ExecuteNonQuery();
        return cmd;
    }

    public DataSet FlipDataSet(DataSet my_DataSet)
    {
        DataSet ds = new DataSet();
        DataTable table = new DataTable();
        DataRow r;
        foreach (DataTable dt in my_DataSet.Tables)
        {

            for (int i = 0; i <= dt.Rows.Count; i++)
            {
                table.Columns.Add(Convert.ToString(i));
            }

            for (int k = 0; k < dt.Columns.Count; k++)
            {
                r = table.NewRow();
                r[0] = dt.Columns[k].ToString();
                for (int j = 1; j <= dt.Rows.Count; j++)
                    r[j] = dt.Rows[j - 1][k];
                table.Rows.Add(r);
            }

        }
        ds.Tables.Add(table);
        return ds;
    }

    public String execproc(String sql)
    {
        cmd.CommandText = sql;
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
        cmd.Connection = conn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.ExecuteNonQuery();
        conn.Close();
        return sql;
    }
}