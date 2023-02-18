using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MessageSender.Controllers
{
    public class MessageController : Controller
    {
        public IMessageSender MessageSender { get; set; }

        public MessageController(IMessageSender messageSender)
        {
            MessageSender = messageSender;
        }

        [HttpPost]
        public async Task Post()
        {
            await MessageSender.Send("Hello world");
        }
    }
}
