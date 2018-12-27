using System;

namespace DXWebApplication1 {
	public class MyCustomException : Exception {
		public MyCustomException() : base("MyCustomException occured.") { }
	}
}