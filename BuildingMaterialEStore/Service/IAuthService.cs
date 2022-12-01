using BmesReBuildingMaterialEStorestApi.Messages.Response.User;
using BuildingMaterialEStore.Messages.Request.User;
using BuildingMaterialEStore.Messages.Response.User;
using System.Threading;
using System.Threading.Tasks;

namespace BuildingMaterialEStore.Service
{
    public interface IAuthService
    {
        Task<RegisterResponse> RegisterAsync(RegisterRequest request, CancellationToken cancellationToken = default);
        Task<LogInResponse> LogInAsync(LogInRequest request, CancellationToken cancellationToken = default);
    }
}
