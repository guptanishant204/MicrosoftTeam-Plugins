using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Teams;
using Microsoft.Bot.Schema;

namespace Hackathon_TeamsPlugin
{
    /// <summary>
    /// An empty bot handler.
    /// You can add your customization code here to extend your bot logic if needed.
    /// </summary>
    public class TeamsBot : TeamsActivityHandler
    {
        protected override Task OnEventActivityAsync(ITurnContext<IEventActivity> turnContext, CancellationToken cancellationToken)
        {
            return base.OnEventActivityAsync(turnContext, cancellationToken);
        }

        protected override Task<InvokeResponse> OnInvokeActivityAsync(ITurnContext<IInvokeActivity> turnContext, CancellationToken cancellationToken)
        {
            return base.OnInvokeActivityAsync(turnContext, cancellationToken);
        }
    }
}
