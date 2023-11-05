using System;
using Classroom.Helpers;
using Classroom.Helpers.Constants;
namespace Classroom.Exceptions
	
{
	public class RegisterFailedExceptions : Exception
	{

		public RegisterFailedExceptions() : this(AccountMessages.RegisterEmailSuccess);
		{

		}

        public RegisterFailedExceptions(string msj) : base(msj)
		{

		}



    }
}

