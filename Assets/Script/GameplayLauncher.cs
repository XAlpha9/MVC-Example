using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using XAlpha.ExMain.Boot;
using XAlpha.ExMain.Module.ClickGame;
using XAlpha.ExMain.Module.Soundfx;
using XAlpha.ExMain.Gameplay;

namespace XAlpha.ExMain.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        private ClickGameController _Game;
        public override string SceneName => "Gameplay";
        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]
            {
                new GameplayConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {

            return new IController[]
            {
                new ClickGameController(),
                new SoundfxController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _Game.SetView(_view.ClickGameView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}

