﻿using System;
using Domain.Enum;

namespace Services.UISystem.Interface
{
    public interface IUIService
    {
        IUIScreen OpenPage(UiPanelNames panelName, Action onOpenPage, Action onClosePage);
        void ClosePage(UiPanelNames panelName, Action onClosePage);
    }
}