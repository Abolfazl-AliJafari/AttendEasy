using System;
namespace AttendEasy.Domain.Entities
{
	public class Setting
	{
		public Setting()
		{
		}

		public string SchoolName { get; set; }
		public string StartShiftTime { get; set; }
		public string EndShiftTime { get; set; }
		public AttendAndAbsenceReason ExitDefaultReason { get; set; }
		
		public AttendAndAbsenceReason DelayDefaultReason { get; set; }
		public AttendAndAbsenceReason AbsenceDefaultReason { get; set; }
		public bool SendDelaySms { get; set; }
		public bool SendExitSms { get; set; }
		public bool SendAbsenceSms{ get; set; }
		public string SmsUrl { get; set; }
		public bool IsSmsEnable { get; set; }

	}
}

