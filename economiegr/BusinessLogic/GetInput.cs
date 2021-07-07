using economiegr.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VDS.RDF.Parsing;
using VDS.RDF.Query;

namespace economiegr.BusinessLogic
{

  public class GetInput
  {

    //	HttpContext httpContext = new BasicHttpContext();
    public String compl_cohort = "";
    public String compl_onephase;
    public String compl_programme = "";
    public String compl_semester = "";
    public String compl_course = "";
    public String compl_project = "";
    public String compl_skill = "";
    public String compl_solo = "";
    public String compl_phase = "";
    public String compl_skills = "";
    public String compl_tools = "";
    public String compl_act_str = "";
    public String compl_act_str_type = "";
    public String compl_tool = "";
    public String compl_evaluation = "";
    public String compl_resource = "";
    public String compl_basedon = "";
    public String compl_eduuse = "";
    public String compl_inter_type = "";
    public String compl_resourcetype = "";
    public String compl_time = "";
    public String compl_rights = "";
    public String compl_competency = "";
    public String compl_projectwork = "";
    public String compl_coursework = "";
    public String compl_supervisor = "";
    public String compl_censor = "";
    public String compl_extevaluation = "";
    public String compl_meeting = "";
    public String compl_knowledge = "";
    public String compl_participation = "";
    public String sem_cohort = "";
    public String sem_programme = "";
    public String sem_act_str = "";
    public String sem_semester = "";
    public String sem_course = "";
    public String sem_project = "";
    public String sem_skill = "";
    public String sem_solo = "";
    public String sem_phase = "";
    public String sem_onephase = "";
    public String sem_act_str_type = "";
    public String sem_tool = "";
    public String sem_competency = "";
    public String sem_projectwork = "";
    public String sem_coursework = "";
    public String sem_supervisor = "";
    public String sem_censor = "";
    public String sem_extevaluation = "";
    public String sem_meeting = "";
    public String sem_knowledge;
    public String sem_participation = "";
    public String sem_evaluation = "";
    public String sem_resource = "";
    public String sem_basedon = "";
    public String sem_eduuse = "";
    public String sem_inter_type = "";
    public String sem_resourcetype = "";
    public String sem_time = "";
    public String sem_rights = "";
    public String base_uri = "http://pbl3_semannot/";
    public String main_uri = "";
    public String main_triple;
    public String total_semantic;
    public String new_act_str;
    public String new_act_str2;
    public String new_phase;
    public String new_skills;
    public String new_tools;
    public String new_act_str_type;
    public int max = 50;
    public int Min = 1;
    public int random = (int)(new Random().Next() * 50 + 1);
    public int ran;
    public List<String> act_list;
    public List<String> act_type_list;
    public List<String> phase_list;
    public List<String> skills_list;
    public List<String> tools_list;
    public List<String> sem_act_list;
    public String all_act_str;
    public String all_phase;
    public String all_skills;
    public String all_tools;
    public String all_act_str_type;
    public String pubby_link;
    public List<String> list_uris = new List<string>();
    public String append;
    public String compl_activity;
    public String sem_activity;
    public String interim_object_actstrtype;
    public String interim_phase;
    public String interim_skills;
    public String interim_tools;
    public String interim_object_actstr;


    public void createResults(String got_cohort, String got_programme, String got_act_str, String semester,
                               String course, String project, String skill, String solo, String phase,
                               String skills, String tools, String act_str_type, String act_str,
                               String tool, String evaluation, String resource, String basedon,
                               String eduuse, String inter_type, String resourcetype, String time,
                               String rights, String searchfield, String competency, String projectwork,
                               String coursework, String supervisor, String censor, String extevaluation, String meeting,
                               String knowledge, String participation, String activity)
    {

      FeedAll feedObject = new FeedAll();
      feedObject.setIn_cohort(got_cohort);
      feedObject.setIn_programme(got_programme);
      FeedAll.setBasedon(basedon);
      FeedAll.setKnowledge(knowledge);
      FeedAll.setCourse(course);
      FeedAll.setEduuse(eduuse);
      FeedAll.setEvaluation(evaluation);
      FeedAll.setInter_type(inter_type);
      FeedAll.setPhase(phase);
      FeedAll.setOnephase(phase);
      FeedAll.setSkills(skills);
      FeedAll.setTools(tools);
      FeedAll.setProject(project);
      FeedAll.setAct_str(got_act_str);
      FeedAll.setResourcetype(resourcetype);
      FeedAll.setRights(rights);
      FeedAll.setSemester(semester);
      FeedAll.setSkill(skill);
      FeedAll.setSolo(solo);
      FeedAll.setTime(time);
      FeedAll.setTool(tool);
      FeedAll.setAct_str_type(act_str_type);
      FeedAll.setPubby_link(searchfield);
      FeedAll.setCompetency(competency);
      FeedAll.setProjectwork(projectwork);
      FeedAll.setCoursework(coursework);
      FeedAll.setSupervisor(supervisor);
      FeedAll.setCensor(censor);
      FeedAll.setExtevaluation(extevaluation);
      FeedAll.setMeeting(meeting);
      FeedAll.setParticipation(participation);
      FeedAll.setActivity(activity);
      FeedAll.setResource(resource);
      //	pubby_link =
      new_act_str = (feedObject.getAct_str().Substring(1, feedObject.getAct_str().Length - 1));
      new_act_str2 = new_act_str.Replace("\"", "");
      new_act_str_type = (feedObject.getAct_str_type().Substring(1, feedObject.getAct_str_type().Length - 1));
      //		if(feedObject.getPhase().equals(null))
      //		new_phase ="";
      //	new_phase = (feedObject.getPhase().Substring(1, feedObject.getPhase().Length-1));
      if (FeedAll.getSkills().Equals(null))
        new_skills = "";
      new_skills = (FeedAll.getSkills().Substring(1, FeedAll.getSkills().Length - 1));
      if (FeedAll.getTools().Equals(null))
        new_tools = "";
      new_tools = (FeedAll.getTools().Substring(1, FeedAll.getTools().Length - 1));
      act_list = new List<string>(new_act_str2.Split(","));
      act_type_list = new List<string>((new_act_str_type.Split(",")));
      //	phase_list = new ArrayList(Arrays.asList(new_phase.split(",")));
      skills_list = new List<string>((new_skills.Split(",")));
      tools_list = new List<string>((new_tools.Split(",")));
      ran = act_list.Count();
      //ran = got_act_str.Length;
      compl_cohort = feedObject.getIn_cohort();
      compl_onephase = FeedAll.getOnephase();
      compl_programme = feedObject.getIn_programme();
      compl_semester = FeedAll.getSemester();
      compl_course = FeedAll.getCourse();
      compl_project = FeedAll.getProject();
      compl_skill = FeedAll.getSkill();
      compl_solo = FeedAll.getSolo();
      compl_phase = FeedAll.getPhase();
      compl_skills = FeedAll.getSkills();
      compl_tools = FeedAll.getTools();
      compl_act_str_type = feedObject.getAct_str_type();
      compl_act_str = feedObject.getAct_str();
      compl_tool = FeedAll.getTool();
      compl_evaluation = FeedAll.getEvaluation();
      compl_resource = FeedAll.getResource();
      compl_basedon = FeedAll.getBasedon();
      compl_eduuse = FeedAll.getEduuse();
      compl_inter_type = FeedAll.getInter_type();
      compl_resourcetype = FeedAll.getResourcetype();
      compl_time = FeedAll.getTime();
      compl_rights = FeedAll.getRights();
      compl_competency = FeedAll.getCompetency();
      compl_projectwork = FeedAll.getProjectwork();
      compl_coursework = FeedAll.getCoursework();
      compl_supervisor = FeedAll.getSupervisor();
      compl_censor = FeedAll.getCensor();
      compl_extevaluation = FeedAll.getExtevaluation();
      compl_meeting = FeedAll.getMeeting();
      compl_knowledge = FeedAll.getKnowledge();
      compl_participation = FeedAll.getParticipation();
      compl_activity = FeedAll.getActivity();



      String compl_cohort2 = compl_cohort.Replace("\\s", "");
      String compl_programme2 = compl_programme.Replace("\\s", "");
      //compl_semester= compl_semester.replaceAll("\\s","");
      String compl_course2 = compl_course.Replace("\\s", "");
      String compl_project2 = compl_project.Replace("\\s", "");
      compl_skill = compl_skill.Replace("\\s", "");
      //	compl_solo= compl_solo.replaceAll("\\s","");
      //compl_phase= compl_phase.replaceAll("\\s","");
      String compl_skills2 = compl_skills.Replace("\\s", "");
      String compl_tools2 = compl_tools.Replace("\\s", "");
      String compl_act_str2 = compl_act_str.Replace("\\s", "");
      String compl_act_str_type2 = compl_act_str_type.Replace("\\s", "");
      String compl_semester2 = compl_semester.Replace("\\s", "");
      String compl_evaluation2 = compl_evaluation.Replace("\\s", "");
      String compl_resource2 = compl_resource.Replace("\\s", "");
      compl_basedon = compl_basedon.Replace("\\s", "");
      String compl_eduuse2 = compl_eduuse.Replace("\\s", "");

      compl_resourcetype = compl_resourcetype.Replace("\\s", "");
      //	 compl_time= compl_time.replaceAll("\\s","");
      compl_rights = compl_rights.Replace("\\s", "");
      String compl_competency2 = compl_competency.Replace("\\s", "");
      String compl_projectwork2 = compl_projectwork.Replace("\\s", "");
      String compl_coursework2 = compl_coursework.Replace("\\s", "");
      //	compl_supervisor= compl_supervisor.replaceAll("\\s","");
      //	 compl_censor= compl_censor.replaceAll("\\s","");
      //	compl_extevaluation= compl_extevaluation.replaceAll("\\s","");
      //	compl_meeting= compl_meeting.replaceAll("\\s","");
      String compl_knowledge2 = compl_knowledge.Replace("\\s", "");
      //		compl_participation= compl_participation.replaceAll("\\s","");
      Random rand = new Random();
      int r = rand.Next(50) + 1;

      //main_uri is a combination of project work and course URIs
      main_uri = "<" + base_uri + r + "/learningobject/" + compl_projectwork2.Substring(0, Math.Min(compl_projectwork2.Length, 10)) + compl_course2.Substring(0, Math.Min(compl_course2.Length, 10)) + r + "> " + "";
      string newuri = "";
      newuri = main_uri;
      list_uris.Add(newuri.ToString());

      //we retrieve the URIs and we search the labels based on the search field
      //if (!String.IsNullOrEmpty(searchfield))
      //{
      //  SparqlQueryParser parser = new SparqlQueryParser();

      //  string queryString = "SELECT ?Published_URI WHERE { GRAPH <http://example/sem3> 	{ ?Published_URI ?prop ?Label FILTER regex(?Label, " + "'" + searchfield + "'" + ")}}";
      //  SparqlQuery q = parser.ParseFromString(queryString);
      //  SparqlResultSet results = q.
      //  Query query = QueryFactory.create(queryString);
      //  QueryExecution qexec = QueryExecutionFactory.create(query);

      //  while (results.hasNext())
      //  {

      //    {
      //      QuerySolution soln = results.nextSolution();
      //      RDFNode x = soln.get("Published_URI");
      //      System.out.println("rdfs" + x.toString());// Get a result variable by name.

      //    }
      //  }
      //}

      if (!compl_cohort.Equals(null))
        sem_cohort = "<" + base_uri + r + "/cohort/" + compl_cohort2.Substring(0, Math.Min(compl_cohort2.Length, 5)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://purl.org/vocab/aiiso/schema#KnowledgeGrouping>; \r\n " +
               // "<http://purl.org/vocab/aiiso/schema#name> "+"\""+compl_cohort+"\""+". \r\n ";
               "<http://purl.org/vocab/aiiso/schema#name> " + "\"" + compl_cohort + "\"" + ". \r\n ";

      //for programme: RDF types: http://purl.org/vocab/aiiso/schema#Programme and http://linkedscience.org/teach/ns#StudyProgram
      //property <http://purl.org/vocab/aiiso/schema#name>
      if (!compl_programme.Equals(null))
        sem_programme = "<" + base_uri + r + "/programme/" + compl_programme2.Substring(0, Math.Min(compl_programme2.Length, 5)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://purl.org/vocab/aiiso/schema#Programme>;  <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://linkedscience.org/teach/ns#StudyProgram> ; " +
                "<http://purl.org/vocab/aiiso/schema#name> " + "\"" + compl_programme + "\"" + ". ";

      //for semester: RDF types: http://purl.org/vocab/aiiso/schema#KnowledgeGrouping and http://purl.org/dc/terms/extent								//property <http://purl.org/vocab/aiiso/schema#name>
      if (!compl_semester.Equals(""))
        sem_semester = "<" + base_uri + r + "/semester/" + compl_semester2.Substring(0, Math.Min(compl_semester2.Length, 10)) + r + ">  <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://purl.org/vocab/aiiso/schema#KnowledgeGrouping>; <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://purl.org/dc/terms/extent> ; <http://purl.org/vocab/aiiso/schema#name> " + "\"" + compl_semester + "\"" + ". ";


      //for course: RDF types: http://linkedscience.org/teach/ns#Course and http://purl.org/vocab/aiiso/schema#Course and http://courseware.rkbexplorer.com/ontologies/courseware#Course
      //properties: courseware#has-title and teach/ns#courseTitle and teach/ns#academicTerm
      if (!compl_course.Equals(""))
        sem_course = "<" + base_uri + r + "/course/" + compl_course2.Substring(0, Math.Min(compl_course2.Length, 5)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://linkedscience.org/teach/ns#Course> ;  <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://purl.org/vocab/aiiso/schema#Course> ; <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://courseware.rkbexplorer.com/ontologies/courseware#Course> ; " +
             "<http://linkedscience.org/teach/ns#courseTitle> " + "\"" + compl_course + "\"" + "; " +
             "<http://courseware.rkbexplorer.com/ontologies/courseware#has-title> " + "\"" + compl_course + "\"" + "; " +
             //	 "<http://courseware.rkbexplorer.com/ontologies/courseware#course-objectives> "+"<" + base_uri + "skill/"+compl_skill.Substring(0, Math.Min(compl_skill.Length, 5)) + "> ;"+
             "<http://linkedscience.org/teach/ns#academicTerm> <" + base_uri + r + "/semester/" + compl_semester2.Substring(0, Math.Min(compl_semester2.Length, 10)) + r + "> . ";


      //for project: RDF types: http://www.lornet.org/LOCO#Method and http://xmlns.com/foaf/spec/Project
      //property: foaf/spec/#name
      if (!compl_project.Equals(""))
        sem_project = "<" + base_uri + r + "/project/" + compl_project2.Substring(0, Math.Min(compl_project2.Length, 5)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://www.lornet.org/LOCO#Method> ;  <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://xmlns.com/foaf/spec/Project> ; <http://xmlns.com/foaf/spec/#name> " + "\"" + compl_project + "\"" + ". ";

      if (!compl_projectwork.Equals(""))
        sem_projectwork = "<" + base_uri + r + "/projectwork/" + compl_projectwork2.Substring(0, Math.Min(compl_projectwork2.Length, 5)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://www.lornet.org/LOCO#Play> ; <http://www.lornet.org/LOCO#title> " + "\"" + compl_projectwork + "\"" + ".";

      if (!compl_competency.Equals(""))
        sem_competency = "<" + base_uri + r + "/competency/" + compl_competency2.Substring(0, Math.Min(compl_competency2.Length, 5)) + r + ">  <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://www.lornet.org/LOCO#LearningObjective> ; <http://www.lornet.org/LOCO#title> " + "\"" + compl_competency + "\"" + ".";

      //	sem_meeting = "<" + base_uri +r + compl_meeting.Substring(0, Math.Min(compl_meeting.Length, 5)) + r + ">  <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://purl.org/dc/dcmitype/Event> ;  <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://www.lornet.org/LOCO#Conference> ; <http://www.lornet.org/LOCO#isOfConferenceType> " +"\""+  compl_meeting +"\""+ "; <http://purl.org/dc/terms/description> " +"\""+  compl_meeting+"\""+ ".";


      //			all_phase ="<" + base_uri+r+phase_list.FirstOrDefault().Substring(1, Math.Min(phase_list.FirstOrDefault().Length, 5)) +r+ "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Classification> .  <" + base_uri+r+phase_list.FirstOrDefault().Substring(1, Math.Min(phase_list.FirstOrDefault().Length, 5)) +r+ "> <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationDescription>  "+phase_list.FirstOrDefault()+".  ";

      //	for(int i=1;i<phase_list.Count();i++)
      //	{
      //	all_phase +="<" + base_uri + r+phase_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(phase_list.FirstOrDefault(m=>m==i.ToString()).Length, 5)) + r+"> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Classification> .  <" + base_uri + r+phase_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(phase_list.FirstOrDefault(m=>m==i.ToString()).Length, 5)) + r+"> <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationDescription>  "+phase_list.FirstOrDefault(m=>m==i.ToString())+".  ";
      //	}

      if (!compl_onephase.Equals(""))
        sem_onephase = "<" + base_uri + r + "/phase/" + compl_onephase.Substring(0, Math.Min(compl_onephase.Length, 5)) + r + ">  <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Classification> ; <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationDescription>  " + "\"" + compl_onephase + "\"" + ". ";


      all_act_str_type = "<" + base_uri + r + "/activitystrtype/" + act_type_list.FirstOrDefault().Substring(1, Math.Min(act_type_list.FirstOrDefault().Length, 5)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Classification> . <" + base_uri + r + "/activitystrtype/" + act_type_list.FirstOrDefault().Substring(1, Math.Min(act_type_list.FirstOrDefault().Length, 5)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type>  <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#TaxonPath> . <" + base_uri + r + "/activitystrtype/" + act_type_list.FirstOrDefault().Substring(1, Math.Min(act_type_list.FirstOrDefault().Length, 5)) + r + "> <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationDescription>  " + act_type_list.FirstOrDefault() + ". <" + base_uri + r + "/activitystrtype/" + act_type_list.FirstOrDefault().Substring(1, Math.Min(act_type_list.FirstOrDefault().Length, 5)) + r + "> <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonpathSource> " + act_type_list.FirstOrDefault() + " . ";

      for (int i = 0; i < act_type_list.Count(); i++)
      {
        all_act_str_type += "<" + base_uri + r + "/activitystrtype/" + act_type_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(act_type_list.FirstOrDefault(m=>m==i.ToString()).Length, 5)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Classification> . <" + base_uri + r + "/activitystrtype/" + act_type_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(act_type_list.FirstOrDefault(m=>m==i.ToString()).Length, 5)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type>  <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#TaxonPath> . <" + base_uri + r + "/activitystrtype/" + act_type_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(act_type_list.FirstOrDefault(m=>m==i.ToString()).Length, 5)) + r + "> <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationDescription>  " + act_type_list.FirstOrDefault(m=>m==i.ToString()) + ". <" + base_uri + r + "/activitystrtype/" + act_type_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(act_type_list.FirstOrDefault(m=>m==i.ToString()).Length, 5)) + r + ">  <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonpathSource> " + act_type_list.FirstOrDefault(m=>m==i.ToString()) + " . ";
      }



      all_act_str = "<" + base_uri + r + "/activitytype/" + act_list.FirstOrDefault().Substring(1, Math.Min(act_list.FirstOrDefault().Length, 3)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://www.lornet.org/LOCO#LearningActivity> . <" + base_uri + r + "/activitytype/" + act_list.FirstOrDefault().Substring(1, Math.Min(act_list.FirstOrDefault().Length, 3)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type>  <http://slor.sourceforge.net/ontology/lom.owl#InteractivityTypeVocabulary> . <" + base_uri + r + "/activitytype/" + act_list.FirstOrDefault().Substring(1, Math.Min(act_list.FirstOrDefault().Length, 3)) + r + ">  <http://www.lornet.org/LOCO#hasLearningObjective> " + "<" + base_uri + r + "/competency/" + compl_competency2.Substring(0, Math.Min(compl_competency2.Length, 5)) + r + "> .  ";

      for (int i = 0; i < act_list.Count(); i++)
      {
        all_act_str += "<" + base_uri + r + "/activitytype/" + act_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(act_list.FirstOrDefault(m=>m==i.ToString()).Length, 3)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://www.lornet.org/LOCO#LearningActivity> . <" + base_uri + r + "/activitytype/" + act_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(act_list.FirstOrDefault(m=>m==i.ToString()).Length, 3)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type>  <http://slor.sourceforge.net/ontology/lom.owl#InteractivityTypeVocabulary> . <" + base_uri + r + "/activitytype/" + act_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(act_list.FirstOrDefault(m=>m==i.ToString()).Length, 3)) + r + "> <http://www.lornet.org/LOCO#hasLearningObjective> " + "<" + base_uri + r + "/competency/" + compl_competency2.Substring(0, Math.Min(compl_competency2.Length, 5)) + r + "> .  ";
        //sem_act_list.set(i, "<"+base_uri+act_list.FirstOrDefault(m=>m==i.ToString()).Substring(0, Math.Min(act_list.FirstOrDefault(m=>m==i.ToString()).Length,0))+"> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalInteractivityType> ;");

      }



      all_skills = "<" + base_uri + r + "/skills/" + skills_list.FirstOrDefault().Substring(1, Math.Min(skills_list.FirstOrDefault().Length, 5)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://data.europa.eu/esco/#Skill/> . <" + base_uri + r + "/skills/" + skills_list.FirstOrDefault().Substring(1, Math.Min(skills_list.FirstOrDefault().Length, 5)) + r + ">  <http://data.europa.eu/esco/model#Label>  " + skills_list.FirstOrDefault() + ".  ";

      for (int i = 0; i < skills_list.Count(); i++)
      {
        all_skills += "<" + base_uri + r + "/skills/" + skills_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(skills_list.FirstOrDefault(m=>m==i.ToString()).Length, 5)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://data.europa.eu/esco/#Skill/> .  <" + base_uri + r + "/skills/" + skills_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(skills_list.FirstOrDefault(m=>m==i.ToString()).Length, 5)) + r + "> <http://data.europa.eu/esco/model#Label>  " + skills_list.FirstOrDefault(m=>m==i.ToString()) + ".  ";
      }

      all_tools = "<" + base_uri + r + "/tools/" + tools_list.FirstOrDefault().Substring(1, Math.Min(tools_list.FirstOrDefault().Length, 3)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://www.lornet.org/LOCO#Tool> .  <" + base_uri + r + "/tools/" + tools_list.FirstOrDefault().Substring(1, Math.Min(tools_list.FirstOrDefault().Length, 3)) + r + ">  <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://purl.org/dc/dcmitype/Software> .  <" + base_uri + r + "/tools/" + tools_list.FirstOrDefault().Substring(1, Math.Min(tools_list.FirstOrDefault().Length, 3)) + r + ">  <http://purl.org/dc/elements/1.1/title>  " + tools_list.FirstOrDefault() + ".  ";

      for (int i = 0; i < tools_list.Count(); i++)
      {
        all_tools += "<" + base_uri + r + "/tools/" + tools_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(tools_list.FirstOrDefault(m=>m==i.ToString()).Length, 3)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://www.lornet.org/LOCO#Tool> .  <" + base_uri + r + "/tools/" + tools_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(tools_list.FirstOrDefault(m=>m==i.ToString()).Length, 3)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://purl.org/dc/dcmitype/Software> .   <" + base_uri + r + "/tools/" + tools_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(tools_list.FirstOrDefault(m=>m==i.ToString()).Length, 3)) + r + "> <http://purl.org/dc/elements/1.1/title>  " + tools_list.FirstOrDefault(m=>m==i.ToString()) + ".  ";
      }


      /*	if(!compl_skill.equals(""))
        sem_skill = "<" + base_uri + r+"skill/"+compl_skill.Substring(0, Math.Min(compl_skill.Length, 5)) + r+"> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://data.europa.eu/esco/model#Skill> ; <http://www.w3.org/2004/02/skos/core#prefLabel> "+compl_skill+".  ";

        if(!compl_solo.equals(""))

        sem_solo = "<" + base_uri + r+"solo/"+compl_solo.Substring(1, Math.Min(compl_solo.Length, 5)) + r+"> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Taxon> ;  <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonEntry> "+compl_solo+".  ";
        else
          sem_solo="";
      */
      if (!compl_evaluation.Equals(null))
        sem_evaluation = "<" + base_uri + r + "/evaluation/" + compl_evaluation2.Substring(0, Math.Min(compl_evaluation2.Length, 5)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://courseware.rkbexplorer.com/ontologies/courseware#Assessment-Method> .  <" + base_uri + r + "/evaluation/" + compl_evaluation2.Substring(0, Math.Min(compl_evaluation2.Length, 5)) + r + "> <http://courseware.rkbexplorer.com/ontologies/courseware#has-title>  " + "\"" + compl_evaluation + "\"" + ".  ";


      if (!compl_knowledge.Equals(null))
        sem_knowledge = "<" + base_uri + r + "/knowledge/" + compl_knowledge2.Substring(0, Math.Min(compl_knowledge2.Length, 5)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://purl.org/vocab/aiiso/schema#knowledgeGrouping> ;   " +
                "<http://purl.org/vocab/aiiso/schema#name> " + "\"" + compl_knowledge + "\"" + ". ";

      //	if(!compl_activity.equals(null))
      // sem_activity = "<" + base_uri +r + compl_activity.Substring(0, Math.Min(compl_activity.Length, 5)) + r +">  <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://www.lornet.org/LOCO#Activity> ; <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://ns.inria.fr/ludo/v1/docs/xapi.html#Activity> ; <http://www.lornet.org/LOCO#hasActivityDescription> "+"\""+compl_activity+"\""+".  ";


      sem_resource = "<" + base_uri + r + "/resource/" + compl_resource2.Substring(0, Math.Min(compl_resource2.Length, 5)) + r + "> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://linkedscience.org/teach/ns/#Material> . <" + base_uri + r + "/resource/" + compl_resource2.Substring(0, Math.Min(compl_resource2.Length, 5)) + r + ">   <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://www.lornet.org/LOCO#Resource> . <" + base_uri + r + "/resource/" + compl_resource2.Substring(0, Math.Min(compl_resource2.Length, 5)) + r + ">  <http://dublincore.org/dcx/lrmi-terms/#targetName> " + "\"" + compl_resource + "\"" + ". "
      + "<" + base_uri + r + "/resource/" + compl_resource2.Substring(0, Math.Min(compl_resource2.Length, 5)) + r + "> <http://dublincore.org/dcx/lrmi-terms/#learningResourceType> " + "\"" + compl_resourcetype + "\"" + " ."
      + "<" + base_uri + r + "/resource/" + compl_resource2.Substring(0, Math.Min(compl_resource2.Length, 5)) + r + "> <http://dublincore.org/dcx/lrmi-terms/#isBasedOnUrl> " + "\"" + compl_basedon + "\"" + " ."
      + "<" + base_uri + r + "/resource/" + compl_resource2.Substring(0, Math.Min(compl_resource2.Length, 5)) + r + "> <http://dublincore.org/dcx/lrmi-terms/#educationalUse> " + "\"" + compl_eduuse + "\"" + " ."
      + "<" + base_uri + r + "/resource/" + compl_resource2.Substring(0, Math.Min(compl_resource2.Length, 5)) + r + "> <http://dublincore.org/dcx/lrmi-terms/#interactivityType> " + "\"" + compl_inter_type + "\"" + " ."
      + "<" + base_uri + r + "/resource/" + compl_resource2.Substring(0, Math.Min(compl_resource2.Length, 5)) + r + "> <http://dublincore.org/dcx/lrmi-terms/#timeRequired> " + "\"" + compl_time + "\"" + " ."
      + "<" + base_uri + r + "/resource/" + compl_resource2.Substring(0, Math.Min(compl_resource2.Length, 5)) + r + "> <http://dublincore.org/dcx/lrmi-terms/#useRightsUrl> " + "\"" + compl_rights + "\"" + " .";

      // sem_coursework = "<"+base_uri +r + compl_coursework.Substring(0, Math.Min(compl_coursework.Length, 5))+r+">  <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://purl.org/vocab/aiiso/schema#Module> ; <http://purl.org/vocab/aiiso/schema#name> "+"\""+ compl_coursework+"\""+ ".";

      if (act_type_list.Count() == 1)
        interim_object_actstrtype = main_uri + "<http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalInteractivityType> " + "<" + base_uri + r + "/activitystrtype/" + act_type_list.FirstOrDefault().Substring(1, Math.Min(act_type_list.FirstOrDefault().Length, 3)) + r + "> . " + "";
      //connection of main_uri with these concepts
      if (act_type_list.Count() > 1)
        interim_object_actstrtype = main_uri + "<http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalInteractivityType> " + "<" + base_uri + r + "/activitystrtype/" + act_type_list.FirstOrDefault().Substring(1, Math.Min(act_type_list.FirstOrDefault().Length, 3)) + r + "> . " + "";

      for (int i = 0; i < act_type_list.Count(); i++)
      {
        interim_object_actstrtype += main_uri + "<http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalInteractivityType> " + "<" + base_uri + r + "/activitystrtype/" + act_type_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(act_type_list.FirstOrDefault(m=>m==i.ToString()).Length, 3)) + r + "> ." + "";
      }

      if (act_list.Count() == 1)
        interim_object_actstr = main_uri + "<http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalInteractivityType> " + "<" + base_uri + r + "/activitystrtype/" + act_type_list.FirstOrDefault().Substring(1, Math.Min(act_list.FirstOrDefault().Length, 3)) + r + "> . " + "";
      //connection of main_uri with these concepts
      if (act_list.Count() > 1)
        interim_object_actstr = main_uri + "<http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalInteractivityType> " + "<" + base_uri + r + "/activitystrtype/" + act_type_list.FirstOrDefault().Substring(1, Math.Min(act_list.FirstOrDefault().Length, 3)) + r + "> . " + "";

      for (int i = 0; i < act_list.Count(); i++)
      {
        interim_object_actstr += main_uri + "<http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalInteractivityType> " + "<" + base_uri + r + "/activitytype/" + act_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(act_list.FirstOrDefault(m=>m==i.ToString()).Length, 3)) + r + "> ." + "";
      }

      /*		if(phase_list.Count()==1)
          interim_phase = main_uri + "<http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classification> <"+base_uri +r+ phase_list.FirstOrDefault().Substring(1,  Math.Min(phase_list.FirstOrDefault().Length, 5))+r+"> . "+ "" ;

          if(phase_list.Count()>1)
            interim_phase = main_uri + "<http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classification> <"+base_uri +r+ phase_list.FirstOrDefault().Substring(1,  Math.Min(phase_list.FirstOrDefault().Length, 5))+r+"> . "+ "" ;
          for (int i=1; i<phase_list.Count(); i++){
            interim_phase+= main_uri + "<http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classification> <"+base_uri +r+ phase_list.FirstOrDefault(m=>m==i.ToString()).Substring(1,  Math.Min(phase_list.FirstOrDefault(m=>m==i.ToString()).Length, 5))+r+"> . "+ "" ;
          }
        */

      if (skills_list.Count() > 1)
        interim_skills = main_uri + "<http://courseware.rkbexplorer.com/ontologies/courseware#course-objectives> <" + base_uri + r + "/skills/" + skills_list.FirstOrDefault().Substring(1, Math.Min(skills_list.FirstOrDefault().Length, 5)) + r + "> . " + "";

      if (skills_list.Count() == 1)
        interim_skills = main_uri + "<http://courseware.rkbexplorer.com/ontologies/courseware#course-objectives> <" + base_uri + r + "/skills/" + skills_list.FirstOrDefault().Substring(1, Math.Min(skills_list.FirstOrDefault().Length, 5)) + r + "> . " + "";
      for (int i = 1; i < skills_list.Count(); i++)
      {
        interim_skills += main_uri + "<http://courseware.rkbexplorer.com/ontologies/courseware#course-objectives> <" + base_uri + r + "/skills/" + skills_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(skills_list.FirstOrDefault(m=>m==i.ToString()).Length, 5)) + r + "> . " + "";
      }

      if (tools_list.Count() > 1)
        interim_tools = main_uri + "<http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#singleTechnicalRequirement> <" + base_uri + r + "/tools/" + tools_list.FirstOrDefault().Substring(1, Math.Min(tools_list.FirstOrDefault().Length, 3)) + r + "> . " + "";

      if (tools_list.Count() == 1)
        interim_tools = main_uri + "<http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#singleTechnicalRequirement> <" + base_uri + r + "/tools/" + tools_list.FirstOrDefault().Substring(1, Math.Min(tools_list.FirstOrDefault().Length, 3)) + r + "> . " + "";
      for (int i = 1; i < tools_list.Count(); i++)
      {
        interim_tools += main_uri + "<http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#singleTechnicalRequirement> <" + base_uri + r + "/tools/" + tools_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(tools_list.FirstOrDefault(m=>m==i.ToString()).Length, 3)) + r + "> . " + "";
      }




      /*						total_semantic=main_triple

                +sem_programme
                +sem_semester
                +sem_course
                +sem_project
                +sem_solo
                +all_phase
                +all_skills
                +all_tools
                +all_act_str_type
                +all_act_str
                +sem_resource
                + sem_activity
                + sem_competency
                + sem_projectwork
                + sem_knowledge ;


        */


      // semantic description of each concept individually



      // relation of LOM with each of the concepts

      //RDF type of main_uri
      main_triple = main_uri + "<http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#LearningObject> ."
              + main_uri + "<http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://jelenajovanovic.net/ontologies/loco/alocom-core/ns#LearningObject> ."

              + main_uri + "<http://purl.org/vocab/aiiso/schema#part_of> <" + base_uri + r + "/cohort/" + compl_cohort2.Substring(0, Math.Min(compl_cohort2.Length, 5)) + r + "> ."
      //relation of main uri with programme
      + main_uri + "<http://purl.org/vocab/aiiso/schema#part_of> <" + base_uri + r + "/programme/" + compl_programme2.Substring(0, Math.Min(compl_programme2.Length, 5)) + r + "> ."

      //relation of main uri with course
      + main_uri + "<http://purl.org/vocab/aiiso/schema#part_of> <" + base_uri + r + "/course/" + compl_course2.Substring(0, Math.Min(compl_course2.Length, 5)) + r + "> ."

      //relation with semester
      //	+main_uri
      //relation of main uri with project
      + main_uri + "<http://purl.org/vocab/aiiso/schema#part_of> <" + base_uri + r + "/project/" + compl_project2.Substring(0, Math.Min(compl_project2.Length, 5)) + r + "> ."

      //relation of main uri with project work
      + main_uri + "<http://purl.org/vocab/aiiso/schema#part_of> <" + base_uri + r + "/projectwork/" + compl_projectwork2.Substring(0, Math.Min(compl_projectwork2.Length, 5)) + r + "> ."
      //relation of main uri with phase
      + main_uri + "<http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classification> <" + base_uri + r + "/phase/" + compl_onephase.Substring(0, Math.Min(compl_onephase.Length, 5)) + r + "> ."
      // +interim_phase
      + interim_object_actstrtype
      + interim_skills
      + interim_object_actstr
      + interim_tools
      + main_uri + " <http://jelenajovanovic.net/ontologies/loco/alocom-core/ns#ContentUnit> " + " <" + base_uri + r + "/resource/" + compl_resource2.Substring(0, Math.Min(compl_resource2.Length, 5)) + r + "> ."
      + main_uri + " <http://jelenajovanovic.net/ontologies/loco/alocom-core/ns#hasLearningObjective> <" + base_uri + r + "/competency/" + compl_competency2.Substring(0, Math.Min(compl_competency2.Length, 5)) + r + "> ."
      + main_uri + " <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotation>  <" + base_uri + r + "/evaluation/" + compl_evaluation2.Substring(0, Math.Min(compl_evaluation2.Length, 5)) + r + "> ."
      + main_uri + " <http://jelenajovanovic.net/ontologies/loco/alocom-core/ns#hasLearningObjective> <" + base_uri + r + "/knowledge/" + compl_knowledge2.Substring(0, Math.Min(compl_knowledge2.Length, 5)) + r + "> .";
      // relation of concepts with each other

      //relation project to project work

      //relation of phase (onephase) with PBL steps (act_type_list)
      for (int i = 0; i < act_type_list.Count(); i++)
        main_triple += "<" + base_uri + r + "/phase/" + compl_onephase.Substring(0, Math.Min(compl_onephase.Length, 5)) + r + "> <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonPath> <" + base_uri + r + "/activitystrtype/" + act_type_list.FirstOrDefault(m=>m==i.ToString()).Substring(1, Math.Min(act_type_list.FirstOrDefault(m=>m==i.ToString()).Length, 5)) + r + "> .";

      main_triple += "<" + base_uri + r + "/project/" + compl_project2.Substring(0, Math.Min(compl_project2.Length, 5)) + r + "> <http://www.lornet.org/LOCO#hasPlay> <" + base_uri + r + "/projectwork/" + compl_projectwork2.Substring(0, Math.Min(compl_projectwork2.Length, 5)) + r + "> .";

      total_semantic = main_triple
          + sem_cohort
          + sem_programme
          + sem_semester
          + sem_course
          + sem_project
          + sem_projectwork
          + all_skills
          // +all_phase
          + all_act_str_type
          + all_act_str
          + all_tools
          + sem_resource
          + sem_competency
          + sem_evaluation
          + sem_onephase
          + sem_knowledge;
      FeedAll.setComplete_triple(total_semantic);

      //System.out.println("cohort is " + compl_cohort);
      //UpdateRequest request = UpdateFactory.create("INSERT DATA { graph <http://example/sem3> { " + total_semantic + "}}");



      //UpdateRequest update = UpdateFactory.create("INSERT DATA { graph <http://example/sem3> { " + total_semantic + "}}");
      //UpdateProcessor processor2 = UpdateExecutionFactory.createRemote(update, "http://egov.dai.uom.gr:3030/ds/update");
      //processor2.execute();


    }

  }


}
