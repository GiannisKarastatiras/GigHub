using GigHub_BC5.Models;
using System.Collections.Generic;

namespace GigHub_BC5.Repositories
{
    public interface IAttendanceRepository
    {
        IEnumerable<Attendance> GetFutureAttendances(string userId);
        Attendance GetAttendance(int gigId, string userId);
    }
}
