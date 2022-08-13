using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using XAlpha.ExMain.Module.ClickGame;

namespace XAlpha.ExMain.Module.Game
{
    public class ClickGameModel : BaseModel, IClickGameModel
    {
        public int Coin { get; private set; }

        public void SetCoin(int coin)
        {
            Coin = coin;
            SetDataAsDirty();
        }

        public void AddCoin()
        {
            Coin++;
            SetDataAsDirty();
        }

        public void SubstractCoin()
        {
            Coin--;
            SetDataAsDirty();
        }
    }
}

