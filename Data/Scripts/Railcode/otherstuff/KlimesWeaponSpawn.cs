using System;
using System.Collections.Generic;
using Sandbox.Game.Entities;
using Sandbox.Game;

using Sandbox.ModAPI;
using VRageMath;
using VRage.ModAPI;
using VRage.ObjectBuilders;
using VRage.Game.Components;
using Sandbox.Definitions;
//using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using ParallelTasks;
using VRage.Game;
using VRage.Game.ModAPI;
using VRage.Game.ModAPI.Interfaces;
using Sandbox.Game.Lights;

using System.Threading;
using System.Text;
using VRage.Utils;
using VRage.Library.Utils;
using Sandbox.Game.SessionComponents;
using Sandbox.Graphics;
using VRage;
using Sandbox.Game.Entities.Cube;
using VRage.Game.Entity;


namespace bob
{
    /*
    [MySessionComponentDescriptor(MyUpdateOrder.BeforeSimulation | MyUpdateOrder.AfterSimulation)]
    public class blblblbl : MySessionComponentBase
    {

        public override void Init(MyObjectBuilder_SessionComponent sessionComponent)
        {
            MyVisualScriptLogicProvider.PlayerSpawned += PlayerSpawned;
            //MyAPIGateway.Entities.OnEntityAdd += alternativeSpawn;
        }

        public override void LoadData()
        {
            //MyAPIGateway.Entities.OnEntityAdd += alternativeSpawn;
            //MyAPIGateway.Entities.OnEntityAdd += alternativeSpawn;

        }

        public override void UpdateBeforeSimulation()
        {

        }

        private void PlayerSpawned(long playerId)
        {
            MyAPIGateway.Utilities.ShowNotification("entity added", 60);

            if (MyAPIGateway.Session.IsServer)
            {
                //MyVisualScriptLogicProvider.ClearAllToolbarSlots(playerId);
                MyDefinitionId reuse_def;

                if (MyDefinitionId.TryParse("MyObjectBuilder_PhysicalGunObject/Ven_RWR_M8_Item", out reuse_def))
                {
                    MyVisualScriptLogicProvider.AddToPlayersInventory(playerId, reuse_def, 1);
                }
                if (MyDefinitionId.TryParse("MyObjectBuilder_AmmoMagazine/556", out reuse_def))
                {
                    MyVisualScriptLogicProvider.AddToPlayersInventory(playerId, reuse_def, 3);
                }
                if (MyDefinitionId.TryParse("MyObjectBuilder_ConsumableItem/Medkit", out reuse_def))
                {
                    MyVisualScriptLogicProvider.AddToPlayersInventory(playerId, reuse_def, 3);
                }
            }
        }
        
        private void alternativeSpawn(IMyEntity ent)
        {
            MyAPIGateway.Utilities.ShowNotification("entity added", 60);
            //(MyAPIGateway.Session.IsServer &&
            if (ent is IMyCharacter)
            {
                IMyPlayer player = MyAPIGateway.Players.GetPlayerControllingEntity(ent);
                if (player == null || MyAPIGateway.Session == null)
                    return;
                MyAPIGateway.Utilities.ShowNotification("we tried", 6000);
                long playerId = player.IdentityId;
                MyVisualScriptLogicProvider.ClearAllToolbarSlots(playerId);
                MyDefinitionId reuse_def;
                MyVisualScriptLogicProvider.SendChatMessage("NEW SPAWN: " + playerId);

                if (MyDefinitionId.TryParse("MyObjectBuilder_PhysicalGunObject/Ven_RWR_M8_Item", out reuse_def))
                {
                    MyVisualScriptLogicProvider.AddToPlayersInventory(playerId, reuse_def, 1);
                    MyVisualScriptLogicProvider.SetToolbarSlotToItem(0, reuse_def, playerId);
                }
                if (MyDefinitionId.TryParse("MyObjectBuilder_AmmoMagazine/NATO_5p56x45mm", out reuse_def))
                {
                    MyVisualScriptLogicProvider.AddToPlayersInventory(playerId, reuse_def, 3);
                }
                if (MyDefinitionId.TryParse("MyObjectBuilder_ConsumableItem/Medkit", out reuse_def))
                {
                    MyVisualScriptLogicProvider.AddToPlayersInventory(playerId, reuse_def, 3);
                    MyVisualScriptLogicProvider.SetToolbarSlotToItem(1, reuse_def, playerId);
                }
            }
        }

        protected override void UnloadData()
        {
            MyVisualScriptLogicProvider.PlayerSpawned -= PlayerSpawned;
            //MyAPIGateway.Entities.OnEntityAdd -= alternativeSpawn;
        }
    }*/
}