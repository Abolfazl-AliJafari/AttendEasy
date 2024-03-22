

namespace AttendEasy.Domain.Enumerations
{
    public enum DeadParentStatus
    {
        None,
        Father,
        Mother,
        Both
    }
    public enum ScoreUpdateType
    {
        Plus,
        Mines
    }
    public enum DisciplinaryType
    {
        Encouragement,
        Punishment
    }

    public enum TrafficType
    {
        Login,
        Exit
    }
    public enum AttendAndAbsenceType
    {
        EarlyExited,
        EndShiftExit,
        EndShiftAutoExit,
        Delay,
        Absence,
        Attend
    }
}
