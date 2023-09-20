using Domain.Data;

namespace Services.ConfigService.Interface
{
    public interface IGameConfigService
    {
        ActionResult IsConfigLoaded { get; }
        void LoadGameConfig();
    }
}