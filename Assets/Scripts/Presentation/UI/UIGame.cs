using Domain.Enum;
using Services.UISystem.Abstract;

namespace Presentation.UI
{
    public class UIGame : EachUIPanel<UIGame>
    {
        public override UiPanelNames PanelName => UiPanelNames.UIGame;
    }
}