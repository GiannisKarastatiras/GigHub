using GigHub_BC5.Models;

namespace GigHub_BC5.Repositories
{
    public interface IFollowingRepository
    {
        Following GetFollowing(string followerId, string followeeId);
    }
}
