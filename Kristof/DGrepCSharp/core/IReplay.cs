using System;
namespace DGRepCSharp 
{
	/**
	 * <summary>
	 * Interface for different Replay instances which can be used
	 * by a Replayer program/controller.
	 * </summary>
	 */
	public interface IReplay
	{
		void Start();
		
		void Stop();
	}
}

