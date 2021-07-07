using Amazon.Athena.Model;
using economiegr.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.Query;

namespace economiegr.BusinessLogic
{

  public class GetSearchSPARQL
  {
    public List<string> uris = new List<string>();

    [Obsolete]
    public static void createResults(string searchfield)
    {
      FeedAll feedObject = new FeedAll();
      string search = "cour";


      TripleStore store = new TripleStore();

      //Assume that we fill our Store with data from somewhere

      //Execute a raw SPARQL Query
      //Should get a SparqlResultSet back from a SELECT query
      Object results = store.ExecuteQuery("select distinct ?main ?label where{ graph <http://example/sem3> { ?main <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#LearningObject> . ?main ?b ?c . ?c ?prop ?label . FILTER regex(?label, " + "'" + searchfield + "'" + ", 'i')}}");
      if (results is SparqlResultSet)
      {
        //Print out the Results
        SparqlResultSet rset = (SparqlResultSet)results;
        foreach (SparqlResult result in rset)
        {
          Console.WriteLine(result.ToString());
        }
      }




    }
  }
}
