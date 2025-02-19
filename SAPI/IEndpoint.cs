﻿using System.Net;

namespace SAPI.Endpoints
{
	public enum Method
	{
		GET,
		POST,
		PUT,
		PATCH,
		DELETE,
		OPTIONS,
		HEAD
	}
	
	public interface IEndpoint
	{
		string url { get; set; }
		Method method { get; set; }
		
		/// <summary>
		/// In task you execute code to satisfy the request
		/// </summary>
		/// <param name="request">Request info from server</param>
		/// <param name="response">Response is used to communicate to client</param>
		void Task(ref HttpListenerRequest request, ref HttpListenerResponse response);
	}
}

