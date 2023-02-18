using System.Threading.Tasks;

namespace MessageSender.Controllers
{
    public interface IMessageSender
    {
        Task Send(string message);
    }
}