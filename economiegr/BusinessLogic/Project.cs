using economiegr.Models;
using economiegr.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace economiegr.BusinessLogic
{
  public static class Project
  {




    public static List<FeedObjects> GetFeeds()
    {

      using (greeceprojectdbContext connection = new greeceprojectdbContext())
      {

        List<FeedObjects> feedData = new List<FeedObjects>();

        try
        {
          //var ps = connection.prepareStatement("SELECT activity_name, idactivity FROM activity");
          //ResultSet rs = ps.executeQuery();

          var activities = connection.Activities.Select(m => new { m.ActivityName, m.Idactivity }).ToList();

          foreach (var activity in activities)
          {
            FeedObjects feedObject = new FeedObjects();
            feedObject.setActname(activity.ActivityName);
            feedObject.setActid(activity.Idactivity);
            feedData.Add(feedObject);
          }
        }
        catch (Exception var6)
        {
          throw var6;
        }

        return feedData;
      }

    }
  }
}