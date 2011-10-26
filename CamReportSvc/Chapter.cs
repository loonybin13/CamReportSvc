using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace CamReportSvc
{
    [ServiceContract]
    public class Chapter : ReportBase
    {
        // TODO: Implement the collection resource that will contain the SampleItem instances

        [WebGet(UriTemplate = "")]
        public List<SampleItem> GetCollection()
        {
            // TODO: Replace the current implementation to return a collection of SampleItem instances
            return new List<SampleItem>() { new SampleItem() { Id = 1, StringValue = "Hello" } };
        }

        [WebInvoke(UriTemplate = "", Method = "POST")]
        public SampleItem Create(SampleItem instance)
        {
            // TODO: Add the new instance of SampleItem to the collection
            throw new NotImplementedException();
        }

        [WebGet(UriTemplate = "{id}")]
        public List<Prestige> Get(string id)
        {
            return new List<Prestige>() { new Prestige() { Amount = 30, Category = PrestigeCategory.Administration, Type = PrestigeType.General, Description = "ACC" }, new Prestige() { Amount = 30, Category = PrestigeCategory.Administration, Type = PrestigeType.General, Description = "ACC" } };
        }

        [WebInvoke(UriTemplate = "{id}", Method = "PUT")]
        public SampleItem Update(string id, SampleItem instance)
        {
            // TODO: Update the given instance of SampleItem in the collection
            throw new NotImplementedException();
        }

        [WebInvoke(UriTemplate = "{id}", Method = "DELETE")]
        public void Delete(string id)
        {
            // TODO: Remove the instance of SampleItem with the given id from the collection
            throw new NotImplementedException();
        }

    }
}
