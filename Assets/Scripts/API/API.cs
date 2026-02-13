using System.Net;



namespace Trail.API
{
	public abstract class API
	{
		public Result         Result { get; protected set; }
		public HttpStatusCode StatusCode { get; protected set; }
		public int            ErrorCode { get; protected set; }
		public string         ErrorMessage { get; protected set; }
	}
}