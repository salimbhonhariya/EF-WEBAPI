using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.WebApi.Models
{
    public class FilterHook
    {
        public int ID { get; set; }
        public string TransactionId { get; set; }
        public string contextID { get; set; }
        public string AppID { get; set; }
        public string WebhookURL { get; set; }
        public string signatureProvider { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }
}
