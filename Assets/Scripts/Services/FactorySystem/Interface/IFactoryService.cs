﻿using System.Threading.Tasks;
using Domain.Enum;
using Domain.Interface;

namespace Services.FactorySystem.Interface
{
    public interface IFactoryService
    {
        IFactoryObject GetDataModel(FactoryDataModelTypes dataModelType);
        IFactoryObject GetUiElement(UiElementNames uiElementName);
        IFactoryObject GetUiPage(UiPanelNames panelName);
        Task LoadUiElements();
        Task LoadUiPanels();
    }
}