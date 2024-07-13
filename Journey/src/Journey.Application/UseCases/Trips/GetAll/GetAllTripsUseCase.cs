using Journey.Communication.Responses;
using Journey.Infrastructure;

namespace Journey.Application.UseCases.Trips.GetAll
{
    public class GetAllTripsUseCase()
    {
        public ResponseTripsJson Execute()
        {
            JourneyDbContext DbContext = new();

            var trips = DbContext.Trips.ToList();

            return new ResponseTripsJson
            {
                Trips = trips.Select(trip => new ResponseShortTripJson
                {
                    Id = trip.Id,
                    EndDate = trip.EndDate,
                    Name = trip.Name,
                    StartDate = trip.StartDate
                }).ToList()
            };
        }
    }
}
