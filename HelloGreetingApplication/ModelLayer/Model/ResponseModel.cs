﻿using System;
namespace ModelLayer.Model
{
	public class ResponseModel<T>
	{
		public bool Success { get; set; } = false;
		public string Message { get; set; } = "";
		public T Data { get; set; } = default(T);
	}
}

