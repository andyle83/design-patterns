namespace DesignPatterns.StructuralPatterns.Bridge
{
    /// <summary>
    /// Bridge pattern:
    /// Decouple abstraction from its implementation so that we can have various ways of implementation
    ///
    /// An example: student, teacher can use different kind of storages.
    /// - BaseRepository -> inherit -> StudyRepository / TeacherRepository
    /// - BaseRepository -> invoke -> StorageRepostory -> File / Database Storage
    /// </summary>
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}