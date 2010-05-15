using Newtonsoft.Json.Linq;
using Raven.Database;
using Raven.Database.Plugins;

namespace Raven.Bundles.Replication
{
    public class HideVirtuallyDeletedDocumentsReadTrigger : AbstractReadTrigger
    {
        public override ReadVetoResult AllowRead(string key, JObject document, JObject metadata, ReadOperation operation,
                                                 TransactionInformation transactionInformation)
        {
            JToken value;
            if (metadata.TryGetValue("Raven-Delete-Marker", out value))
                return ReadVetoResult.Ignore;
            return ReadVetoResult.Allowed;
        }
    }
}