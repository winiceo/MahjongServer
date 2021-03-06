﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZyGames.Framework.Game.Contract;
using ZyGames.Framework.Game.Service;

namespace GameServer.CsScript.Action
{
    /// <summary>
    /// 广播牌
    /// </summary>
    class Action3000 : BaseStruct
    {
        private int brand;
        private int playerid;

        public Action3000(HttpGet httpGet) : base(3000, httpGet)
        {
        }

        public override bool GetUrlElement()
        {
            httpGet.GetInt("brand", ref brand);
            httpGet.GetInt("playerid", ref playerid);
            return true;
        }

        public override void BuildPacket()
        {
            PushIntoStack(brand);
            PushIntoStack(playerid);
        }

        public override bool TakeAction()
        {

            return true;
        }
    }
}
