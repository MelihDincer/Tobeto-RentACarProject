using Business.Requests.Car;
using Business.Responses.Car;

namespace Business.Abstracts
{
    public interface ICarService
    {
        Task<List<GetAllCarResponse>> GetAllAsync();
        Task<CreateCarResponse> AddAsync(CreateCarRequest request);
    }
}
