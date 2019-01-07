using GigHub_BC5.Repositories;

namespace GigHub_BC5.Persistence
{
    public interface IUnitOfWork
    {
        IGigRepository Gigs { get; }
        IAttendanceRepository Attendances { get; }
        IGenreRepository Genres { get; }
        IFollowingRepository Followings { get; }
        void Complete();
    }
}
