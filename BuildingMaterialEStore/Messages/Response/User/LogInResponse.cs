using BuildingMaterialEStore.Messages.Response.Product;

namespace BuildingMaterialEStore.Messages.Response.User
{
    public class LogInResponse : ResponseBase
    {
        public string Token { get; set; }
    }
}
