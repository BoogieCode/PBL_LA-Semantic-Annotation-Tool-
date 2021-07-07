using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace economiegr.ViewModels
{
  public class FeedObjects
  {
    private int actid;
    private String actname;
    private int skillid;
    private String skillname;
    private int LAid;
    private String LAname;
    private String tool;
    private int toolid;

    public FeedObjects()
    {
    }

    public int getActid()
    {
      return this.actid;
    }

    public void setActid(int actid)
    {
      this.actid = actid;
    }

    public String getActname()
    {
      return this.actname;
    }

    public void setActname(String actname)
    {
      this.actname = actname;
    }

    public int getSkillid()
    {
      return this.skillid;
    }

    public void setSkillid(int skillid)
    {
      this.skillid = skillid;
    }

    public String getSkillname()
    {
      return this.skillname;
    }

    public void setSkillname(String skillname)
    {
      this.skillname = skillname;
    }

    public int getLAid()
    {
      return this.LAid;
    }

    public void setLAid(int lAid)
    {
      this.LAid = lAid;
    }

    public String getLAname()
    {
      return this.LAname;
    }

    public void setLAname(String lAname)
    {
      this.LAname = lAname;
    }

    public String getTool()
    {
      return this.tool;
    }

    public void setTool(String tool)
    {
      this.tool = tool;
    }

    public int getToolid()
    {
      return this.toolid;
    }

    public void setToolid(int toolid)
    {
      this.toolid = toolid;
    }
  }
}
