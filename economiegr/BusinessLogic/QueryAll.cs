using economiegr.Models;
using economiegr.ViewModels;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace economiegr.BusinessLogic
{

  public class QueryAll
  {
    public List<SetAllVariables> GetFeeds(SqlConnection connection,string activity)
    {
      string query = "SELECT DISTINCT * FROM [greeceprojectdb].[testultimcurs].[relations] rel INNER JOIN [greeceprojectdb].[testultimcurs].[la_method] lam ON rel.lamid = lam.idla_method INNER JOIN [greeceprojectdb].[testultimcurs].[activity] act ON rel.actid = act.idactivity INNER JOIN [greeceprojectdb].[testultimcurs].[technology] tec ON rel.techid = tec.idtechnology INNER JOIN [greeceprojectdb].[testultimcurs].[pbl_step] ON rel.stepid=pbl_step.idpbl_step INNER JOIN [greeceprojectdb].[testultimcurs].[data] dat ON rel.dataid=dat.iddata WHERE rel.stepid IN ( SELECT idpbl_step FROM [greeceprojectdb].[testultimcurs].[pbl_step] WHERE step_name = '"+ activity + "');";
        List<SetAllVariables> QAll = new List<SetAllVariables>();
      using (connection)
      {
        SqlCommand command = new SqlCommand(
          query,
          connection);
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows)
        {
          while (reader.Read())
          {
            SetAllVariables QObjectAll = new SetAllVariables();
            //QObject.setSkill(reader.getString("skill_name"));
            QObjectAll.setLamethod(reader.GetValue(7).ToString());
            QObjectAll.setActivity(reader.GetValue(9).ToString());
            QObjectAll.setData(reader.GetValue(16).ToString());
            QObjectAll.setTechnology(reader.GetValue(11).ToString());
            QObjectAll.setCh_step(reader.GetValue(9).ToString());
            //QObject.setSkill(reader.getString("skill_name"));
            //QObject.setCh_step(reader.getString("step_name"));
            QObjectAll.setCh_act_id(int.Parse(reader.GetValue(8).ToString()));
            QObjectAll.setCh_lamethod_id(int.Parse(reader.GetValue(6).ToString()));
            QObjectAll.setCh_step_id(int.Parse(reader.GetValue(13).ToString()));
            QObjectAll.setData_id(int.Parse(reader.GetValue(15).ToString()));
            QObjectAll.setTechnology_id(int.Parse(reader.GetValue(4).ToString()));
            QAll.Add(QObjectAll);
          }
        }
        else
        {
          Console.WriteLine("No rows found.");
        }
        reader.Close();
        return QAll;
      }
    }
    public List<SetAllVariables> GetFeedsShow()
    {
      FeedAll feedObject2 = new FeedAll();

      string chosenAct = feedObject2.getAct_str();
      //String chosenLA = feedObject2.getLamethod();
      string chosenstep = feedObject2.getAct_str_type();
      string query3 = "";
      string query4 = "";
      int stepid = 0;
      string new_phase = "test";
      string new_act = "it";
      FeedAll feedObject = new FeedAll();

      //	System.out.println("chosen skill is "+chosenSkill);
      List<SetAllVariables> QAll = new List<SetAllVariables>();

      try
      {
        new_phase = (feedObject.getAct_str_type().Substring(1, feedObject.getAct_str_type().Length - 1));
        new_act = (feedObject.getAct_str().Substring(1, feedObject.getAct_str().Length - 1));

        //String query2 = "SELECT DISTINCT idla_method, idactivity, idpbl_step, iddata,step_name, techid, activity_name, lamethod_name, tech_name, data_name FROM relations rel "
        //    + " INNER JOIN la_method lam ON rel.lamid = lam.idla_method"
        //    + " INNER JOIN activity act ON rel.actid = act.idactivity"
        //    + " INNER JOIN technology tec ON rel.techid = tec.idtechnology"
        //    + " INNER JOIN pbl_step ON rel.stepid=pbl_step.idpbl_step"
        //    + " INNER JOIN data dat ON rel.dataid=dat.iddata "
        //    + "WHERE rel.stepid IN ( SELECT idpbl_step FROM pbl_step WHERE step_name = " + new_phase + ")";



        string query2 = @"SELECT DISTINCT 'idla_method', 'idactivity', 'idpbl_step', 'iddata,step_name', 'techid', 'activity_name', 'lamethod_name', 'tech_name', 'data_name' FROM [greeceprojectdb].[testultimcurs].[relations] rel INNER JOIN [greeceprojectdb].[testultimcurs].[la_method] lam ON rel.lamid = lam.idla_method INNER JOIN [greeceprojectdb].[testultimcurs].[activity] act ON rel.actid = act.idactivity INNER JOIN [greeceprojectdb].[testultimcurs].[technology] tec ON rel.techid = tec.idtechnology INNER JOIN [greeceprojectdb].[testultimcurs].[pbl_step] ON rel.stepid=pbl_step.idpbl_step INNER JOIN [greeceprojectdb].[testultimcurs].[data] dat ON rel.dataid=dat.iddata WHERE rel.stepid IN ( SELECT idpbl_step FROM [greeceprojectdb].[testultimcurs].[pbl_step] WHERE step_name = '" + new_phase + @"');";

        String total_query = query2 + query4;

        string connectionString = @"Server=DESKTOP-F56NIVV;Database=greeceprojectdb;Trusted_Connection=True;";

        string commandText = query2 + query4;


        using (SqlConnection conn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand("SELECT * FROM relations", conn))
        {
          conn.Open();
          var model = cmd.ExecuteNonQuery();
          conn.Close();


          //while (rs.next())
          //{
          //  SetAllVariables QObjectAll = new SetAllVariables();
          //  //QObject.setSkill(rs.getString("skill_name"));
          //  QObjectAll.setLamethod(rs.getString("lamethod_name"));
          //  QObjectAll.setActivity(rs.getString("activity_name"));
          //  QObjectAll.setData(rs.getString("data_name"));
          //  QObjectAll.setTechnology(rs.getString("tech_name"));
          //  QObjectAll.setCh_step(rs.getString("step_name"));
          //  //QObject.setSkill(rs.getString("skill_name"));
          //  //QObject.setCh_step(rs.getString("step_name"));
          //  QObjectAll.setCh_act_id(rs.getInt("idactivity"));
          //  QObjectAll.setCh_lamethod_id(rs.getInt("idla_method"));
          //  QObjectAll.setCh_step_id(rs.getInt("idpbl_step"));
          //  QObjectAll.setData_id(rs.getInt("iddata"));
          //  QObjectAll.setTechnology_id(rs.getInt("techid"));
          //  QAll.Add(QObjectAll);
          // }

          return QAll;
        }
      }
      catch (Exception e)
      {
        throw e;
      }
    }


  }
}
