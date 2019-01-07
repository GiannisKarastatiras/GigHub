using GigHub_BC5.Models;
using System.Collections.Generic;

namespace GigHub_BC5.Repositories
{
    public interface IGigRepository
    {
        IEnumerable<Gig> GetUpcomingGigsByArtist(string artistId);
        Gig GetGigWithAttendees(int gigId);
        Gig GetGig(int gigId);
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        void Add(Gig gig);
    }
}
