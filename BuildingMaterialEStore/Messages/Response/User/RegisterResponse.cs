using BuildingMaterialEStore.Messages.Response.Product;

namespace BmesReBuildingMaterialEStorestApi.Messages.Response.User
{
    public class RegisterResponse : ResponseBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
