﻿namespace BepInEx.Configuration
{
	/// <summary>
	/// Base type of all classes represeting and enforcing acceptable values of config settings.
	/// </summary>
	public abstract class AcceptableValueBase
	{
		/// <summary>
		/// Change the value to be acceptable, if it's not already.
		/// </summary>
		public abstract object Clamp(object value);

		/// <summary>
		/// Check if the value is an acceptable value.
		/// </summary>
		public abstract bool IsValid(object value);

		/// <summary>
		/// Get the string for use in config files.
		/// </summary>
		public abstract string ToSerializedString();
	}
}