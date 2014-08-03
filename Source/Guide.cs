
namespace TrialModeBuddy
{
	/// <summary>
	/// All this thing does is store a boolean for trial mode.
	/// </summary>
	public static class Guide
	{
		/// <summary>
		/// flag for whether or not it is trial mode.
		/// </summary>
		private static bool _isTrialMode = true;

		/// <summary>
		/// Gets or sets a value indicating trial mode.
		/// </summary>
		/// <value><c>true</c> if is trial mode; otherwise, <c>false</c>.</value>
		public static bool IsTrialMode 
		{
			get
			{
				return _isTrialMode;
			}
			set
			{
				_isTrialMode = value;
			}
		}
	}
}