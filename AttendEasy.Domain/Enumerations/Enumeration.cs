

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
    public enum AttendAndAbsenceType
    {
        Login,
        Exit,
        Delay,
        Absence,
        Attend
    }
}
