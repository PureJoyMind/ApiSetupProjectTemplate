using Microsoft.AspNetCore.SignalR;
using TrackerService.Models.HubModels;

namespace TrackerService.Hub
{
    public class DefaultHub : Hub<IHubClient>
    {
		public async Task SendAsync(BroadcastModel req)
		{
			await Clients.All.ClientMethod(req);
		}
	}

}
