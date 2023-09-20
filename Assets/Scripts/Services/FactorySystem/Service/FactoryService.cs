﻿using System.Threading.Tasks;
using Domain.Enum;
using Domain.Interface;
using Services.FactorySystem.Interface;
using Zenject;

namespace Services.FactorySystem.Service
{
    public class FactoryService : IFactoryService
    {
        private readonly IDataModelFactory _dataModelFactory;
        private readonly IUIElementFactory _uiElementFactory;
        private readonly IUIScreenFactory _uiScreenFactory;
        private readonly DiContainer _diContainer;

        public FactoryService(IDataModelFactory dataModelFactory,
            IUIElementFactory uiElementFactory,
            IUIScreenFactory uiScreenFactory,
            DiContainer diContainer)
        {
            _dataModelFactory = dataModelFactory;
            _uiElementFactory = uiElementFactory;
            _uiScreenFactory = uiScreenFactory;
            _diContainer = diContainer;
        }

        public async Task LoadUiElements()
        {
            await _uiElementFactory.LoadAllUIs();
        }

        public async Task LoadUiPanels()
        {
            await _uiScreenFactory.LoadAllUIs();
        }

        public IFactoryObject GetUiElement(UiElementNames uiElementName)
        {
            return _uiElementFactory.GetUiElement(uiElementName);
        }

        public IFactoryObject GetUiPage(UiPanelNames panelName)
        {
            return _uiScreenFactory.GetUiScreen(panelName);
        }
        
        public IFactoryObject GetDataModel(FactoryDataModelTypes dataModelType)
        {
            return _dataModelFactory.GetDataModel(dataModelType);
        }
    }
}