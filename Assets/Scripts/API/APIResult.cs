


namespace Trail.API
{
	public struct APIResult
	{
		public Result Result;
		public int    StatusCode;
		public int    ErrorCode;
		public string ErrorMessage;

		public APIResult(API iAPI)
		{
			Result       = iAPI.Result;
			StatusCode   = (int)iAPI.StatusCode;
			ErrorCode    = iAPI.ErrorCode;
			ErrorMessage = iAPI.ErrorMessage;
		}
	}
	public enum Result
	{
		NONE = 0,
		SUCCESS,
		CANCEL,
		ABORT,
		ERROR,
	}
}