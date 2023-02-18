using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MessageSender.Controllers
{
    [Route("api/[controller]")]
    public class MessageController : Controller
    {
        public IMessageSender MessageSender { get; set; }

        public MessageController(IMessageSender messageSender)
        {
            MessageSender = messageSender;
        }

        [HttpPost]
        public async Task Send(string message)
        {
            await MessageSender.Send(message);
        }
    }
}
