using System;
using System.Collections.Generic;
using System.Text;

namespace GameDevAssistPack
{
	public class RegisteredException : Exception
	{
		public RegisteredException() : base("등록되지 않은 프로그램이 이 명령을 실행하려고 합니다.")
		{
			HResult = 0x12409;
		}
	}
}
