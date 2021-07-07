using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace economiegr.ViewModels
{
  public class SetAllVariables
  {
    public String ch_activity;
    public String ch_lamethod;
    public String technology;
    public String data;
    public String ch_step;
    public int ch_act_id;
    public int ch_lamethod_id;
    public int technology_id;
    public int data_id;
    public int ch_step_id;

    public SetAllVariables()
    {
    }

    public String getActivity()
    {
      return this.ch_activity;
    }

    public void setActivity(String ch_activity)
    {
      this.ch_activity = ch_activity;
    }

    public String getLamethod()
    {
      return this.ch_lamethod;
    }

    public void setLamethod(String ch_lamethod)
    {
      this.ch_lamethod = ch_lamethod;
    }

    public String getCh_activity()
    {
      return this.ch_activity;
    }

    public void setCh_activity(String ch_activity)
    {
      this.ch_activity = ch_activity;
    }

    public String getCh_lamethod()
    {
      return this.ch_lamethod;
    }

    public void setCh_lamethod(String ch_lamethod)
    {
      this.ch_lamethod = ch_lamethod;
    }

    public String getTechnology()
    {
      return this.technology;
    }

    public void setTechnology(String technology)
    {
      this.technology = technology;
    }

    public String getData()
    {
      return this.data;
    }

    public void setData(String data)
    {
      this.data = data;
    }

    public String getCh_step()
    {
      return this.ch_step;
    }

    public void setCh_step(String ch_step)
    {
      this.ch_step = ch_step;
    }

    public int getCh_act_id()
    {
      return this.ch_act_id;
    }

    public void setCh_act_id(int ch_act_id)
    {
      this.ch_act_id = ch_act_id;
    }

    public int getCh_lamethod_id()
    {
      return this.ch_lamethod_id;
    }

    public void setCh_lamethod_id(int ch_lamethod_id)
    {
      this.ch_lamethod_id = ch_lamethod_id;
    }

    public int getTechnology_id()
    {
      return this.technology_id;
    }

    public void setTechnology_id(int technology_id)
    {
      this.technology_id = technology_id;
    }

    public int getData_id()
    {
      return this.data_id;
    }

    public void setData_id(int data_id)
    {
      this.data_id = data_id;
    }

    public int getCh_step_id()
    {
      return this.ch_step_id;
    }

    public void setCh_step_id(int ch_step_id)
    {
      this.ch_step_id = ch_step_id;
    }
  }

}
