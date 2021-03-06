﻿using Models.PlayerData;
using UniRx;
using UnityEngine;
using Zenject;

namespace Services.PlayerData
{
    public class PlayerDataService
    {
        public ReactiveProperty<PlayerDataModel> PlayerDataModel { get; private set; }

        [Inject]
        public void Construct(IPlayerDataSavingService playerDataSavingService)
        {
            Debug.Log($"{GetType().Name} initialization started");

            PlayerDataModel = new ReactiveProperty<PlayerDataModel>
            {
                Value = new PlayerDataModel(playerDataSavingService)
            };

            PlayerDataModel.Subscribe(playerDataModel =>
            {
                Debug.Log($"{nameof(playerDataModel)} changed");
            });

            Debug.Log($"{GetType().Name} initialization finished");
        }
    }
}