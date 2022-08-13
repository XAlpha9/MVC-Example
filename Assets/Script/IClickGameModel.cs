using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;

namespace XAlpha.ExMain.Module.Game
{
    public interface IClickGameModel : IBaseModel
    {
        public int Coin { get; }

        //public event OnDataModified OnDataModified;
    }
}

