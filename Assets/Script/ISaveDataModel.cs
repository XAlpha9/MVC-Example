using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace XAlpha.ExMain.Module.SaveData
{
    public interface ISaveDataModel : IBaseModel
    {
        int Coin { get; }
    }
}
