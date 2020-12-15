﻿using Services.Configs;
using Services.PlayerData;
using Zenject;

namespace Installers
{
    public class MainSceneInstaller : MonoInstaller<MainSceneInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<IConfigsLoadingService>().To<ResourcesConfigsLoadingService>().AsSingle();
            Container.Bind<IPlayerDataLoadingService>().To<PlayerPrefsPlayerDataLoadingService>().AsSingle();
            Container.Bind<IPlayerDataSavingService>().To<PlayerPrefsPlayerDataSavingService>().AsSingle();

            Container.BindInterfacesAndSelfTo<ConfigsService>().AsSingle();
            Container.BindInterfacesAndSelfTo<PlayerDataService>().AsSingle();
        }
    }
}
