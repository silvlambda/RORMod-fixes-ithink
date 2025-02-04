﻿using Microsoft.Xna.Framework;
using RiskOfTerrain.Content.Accessories;
using Terraria;
using Terraria.ID;

namespace RiskOfTerrain.Items.Accessories.T2Uncommon
{
    public class KjarosBand : ModAccessory
    {
        public override void SetStaticDefaults()
        {
            SacrificeTotal = 1;
            RORItem.GreenTier.Add(Type);
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.accessory = true;
            Item.rare = ItemRarityID.LightRed;
            Item.value = Item.sellPrice(gold: 3);
        }

        public override void OnKillEnemy(EntityInfo entity, OnKillInfo info)
        {
            if (info.lastHitDamage >= info.lifeMax * 0.6 && !info.friendly && !info.spawnedFromStatue && info.lifeMax > 5)
            {
                Projectile.NewProjectile(entity.GetSource_Accessory(Item), info.Center, Vector2.Zero, ProjectileID.SandnadoFriendly, 0, 0);
            }
        }
    }
}