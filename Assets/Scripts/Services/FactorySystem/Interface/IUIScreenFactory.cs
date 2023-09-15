﻿using System.Threading.Tasks;
using Domain.Enum;
using Domain.Interface;

namespace Services.FactorySystem.Interface
{
    public interface IUIScreenFactory
    {
        Task<IFactoryObject> GetUiScreen(UiPanelNames panelName);
    }
}