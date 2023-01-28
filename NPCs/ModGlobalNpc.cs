using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RiskOfTerrain.Buffs.Debuff;
using RiskOfTerrain.Content;
using RiskOfTerrain.Content.Accessories;
using RiskOfTerrain.Content.Elites;
using Terraria.GameContent.ItemDropRules;
using RiskOfTerrain.Items.Accessories.T1Common;
using RiskOfTerrain.Items.Consumable;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace RiskOfTerrain.NPCs
{
    public class ModGlobalNpc : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            // First, we need to check the npc.type to see if the code is running for the vanilla NPCwe want to change
            if (npc.type == NPCID.EyeOfCthulhu)
            {
                // This is where we add item drop rules for VampireBat, here is a simple example:
                npcLoot.Add(ItemDropRule.(ModContent.ItemType<Items.Accessories.T3Legendary.Aegis>()));
            }
            // We can use other if statements here to adjust the drop rules of other vanilla NPC
        }
    }
}