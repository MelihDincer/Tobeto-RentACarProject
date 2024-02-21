using Business.Requests.Car;
using Business.Responses.Car;
using Core.Utilities.Results;

namespace Business.Abstracts
{
    public interface ICarService
    {
        Task<IDataResult<List<GetAllCarResponse>>> GetAllAsync();
        Task<CreateCarResponse> AddAsync(CreateCarRequest request);
    }
}
