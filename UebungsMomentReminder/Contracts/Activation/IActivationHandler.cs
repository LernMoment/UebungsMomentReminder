using System.Threading.Tasks;

namespace UebungsMomentReminder.Contracts.Activation
{
    public interface IActivationHandler
    {
        bool CanHandle();

        Task HandleAsync();
    }
}
