using TrackerService.Models.HubModels;

namespace TrackerService.Hub
{
	public interface IHubClient 
		// definition of client side methods
		// the methods in the client must be named the same way
	{
		public Task ClientMethod(BroadcastModel req);


	}
}
