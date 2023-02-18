using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using System.Threading.Tasks;

namespace MessageSender.Controllers
{
    public class AzureQueueSender : IMessageSender
    {
        public IConfiguration Configuration { get; set; }

        public AzureQueueSender(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task Send(string message)
        {
            var connectionString = Configuration.GetValue<string>("QueueConnectionString");
            await SendMessage(connectionString, message);
        }

        public static async Task SendMessage(string ConnectionString, string message)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(ConnectionString);
            storageAccount.CreateCloudQueueClient();
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            CloudQueue queue = queueClient.GetQueueReference("alexeiqueue");
            CloudQueueMessage cloudQueueMessage = new CloudQueueMessage(message);
            await queue.AddMessageAsync(cloudQueueMessage);
        }
    }
}
