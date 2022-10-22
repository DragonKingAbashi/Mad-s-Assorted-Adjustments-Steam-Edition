﻿using System;
using System.Collections.Generic;
using System.Linq;
using Base.Core;
using Base.Defs;
using Base.UI;
using HarmonyLib;

namespace MadsAssortedAdjustment
{
    internal static class DataHelpers
    {
        public static void Print()
        {
            DefRepository defRepository = GameUtl.GameComponent<DefRepository>();


            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<VehicleSlotFacilityComponentDef>())
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");

                Logger.Info($"[DataHelpers_Print] GroundVehicleSlots: {def.GroundVehicleSlots}");
                Logger.Info($"[DataHelpers_Print] AircraftSlots: {def.AircraftSlots}");
                Logger.Info($"[DataHelpers_Print] AircraftHealAmount: {def.AircraftHealAmount}");
                Logger.Info($"[DataHelpers_Print] VehicleHealAmount: {def.VehicleHealAmount}");

                Logger.Info($"[DataHelpers_Print] ---");
            }
            */



            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<GeoMistGeneratorDef>())
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");

                Logger.Info($"[DataHelpers_Print] Resolution: {def.Resolution.x}, {def.Resolution.y}");
                Logger.Info($"[DataHelpers_Print] SpreadExponent: {def.SpreadExponent}");
                Logger.Info($"[DataHelpers_Print] KmPerHour: {def.KmPerHour}");

                Logger.Info($"[DataHelpers_Print] InitialMistExpansionRateKm: {def.InitialMistExpansionRateKm.Min}, {def.InitialMistExpansionRateKm.Max}");
                Logger.Info($"[DataHelpers_Print] MistExpansionDecelerationKm: {def.MistExpansionDecelerationKm.Min}, {def.MistExpansionDecelerationKm.Max}");
                Logger.Info($"[DataHelpers_Print] MaximumMistExpansionKm: {def.MaximumMistExpansionKm.Min}, {def.MaximumMistExpansionKm.Max}");

                Logger.Info($"[DataHelpers_Print] ---");
            }
            */

            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<ResearchDef>())
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");
                Logger.Info($"[DataHelpers_Print] Name: {def.ViewElementDef?.DisplayName1.Localize()}");
                Logger.Info($"[DataHelpers_Print] RevealText: {def.ViewElementDef?.RevealText.Localize()}");
                Logger.Info($"[DataHelpers_Print] UnlockText: {def.ViewElementDef?.UnlockText.Localize()}");
                Logger.Info($"[DataHelpers_Print] CompleteText: {def.ViewElementDef?.CompleteText.Localize()}");
                Logger.Info($"[DataHelpers_Print] BenefitsText: {def.ViewElementDef?.BenefitsText.Localize()}");

                Logger.Info($"[DataHelpers_Print] ---");
            }
            */

            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<DamageKeywordDef>())
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");

                Logger.Info($"[DataHelpers_Print] ---");
            }
            */

            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<RedeemableCodeDef>())
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");
                Logger.Info($"[DataHelpers_Print] Allowed: {def.Allowed}");
                Logger.Info($"[DataHelpers_Print] PlatformLimitation: {def.PlatformLimitation}");

                Logger.Info($"[DataHelpers_Print] GiftedItems: {def.GiftedItems.Select(i => i.name).Join()}");

                Logger.Info($"[DataHelpers_Print] ---");
            }
            */

            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<TacticalItemDef>())
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");
                Logger.Info($"[DataHelpers_Print] Armor: {def.Armor}");
                Logger.Info($"[DataHelpers_Print] ChargesMax: {def.ChargesMax}");

                Logger.Info($"[DataHelpers_Print] Name: {def.ViewElementDef?.DisplayName1.Localize()}");
                Logger.Info($"[DataHelpers_Print] Description: {def.ViewElementDef?.Description.Localize()}");
                Logger.Info($"[DataHelpers_Print] Tags: {def.Tags.Join()}");

                Logger.Info($"[DataHelpers_Print] ---"); 
            }
            */

            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<FrenzyStatusDef>())
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");
                Logger.Info($"[DataHelpers_Print] WillpowerCoefficient: {def.WillpowerCoefficient}");
                Logger.Info($"[DataHelpers_Print] SpeedCoefficient: {def.SpeedCoefficient}");
                Logger.Info($"[DataHelpers_Print] ---");
            }
            */

            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<WeaponDef>())
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");
                Logger.Info($"[DataHelpers_Print] Name: {def.ViewElementDef?.DisplayName1.Localize()}");

                Logger.Info($"[DataHelpers_Print] IsMountedToBody: {def.IsMountedToBody}");
                Logger.Info($"[DataHelpers_Print] UseAimIK: {def.UseAimIK}");

                Logger.Info($"[DataHelpers_Print] SpreadDegrees: {def.SpreadDegrees}");
                Logger.Info($"[DataHelpers_Print] SpreadRadius: {def.SpreadRadius}");
                Logger.Info($"[DataHelpers_Print] AccurateSpreadPerc: {def.AccurateSpreadPerc}");
                Logger.Info($"[DataHelpers_Print] ReturnFirePerc: {def.ReturnFirePerc}");
                Logger.Info($"[DataHelpers_Print] OverwatchFirePerc: {def.OverwatchFirePerc}");
                Logger.Info($"[DataHelpers_Print] NoReturnFireFromTargets: {def.NoReturnFireFromTargets}");
                Logger.Info($"[DataHelpers_Print] Tags: {def.Tags.Join()}");

                Logger.Info($"[DataHelpers_Print] ---");
            }
            */

            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<TacCharacterDef>().Where(d => d.IsHuman))
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");
                Logger.Info($"[DataHelpers_Print] Abilities: {def.Data.Abilites.Select(a => a.name).Join()}");
                Logger.Info($"[DataHelpers_Print] ---");
            }
            */

            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<GeoHavenDef>().ToList())
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");

                Logger.Info($"[DataHelpers_Print] RecruitmentBaseChance: {def.RecruitmentBaseChance}");
                Logger.Info($"[DataHelpers_Print] PhoenixSoldiersCap: {def.PhoenixSoldiersCap}");
                Logger.Info($"[DataHelpers_Print] MaxZones: {def.MaxZones}");
                Logger.Info($"[DataHelpers_Print] StarvationDeathsPart: {def.StarvationDeathsPart}");
                Logger.Info($"[DataHelpers_Print] StarvationMistDeathsPart: {def.StarvationMistDeathsPart}");
                Logger.Info($"[DataHelpers_Print] StarvationDeathsFlat: {def.StarvationDeathsFlat}");
                Logger.Info($"[DataHelpers_Print] StarvationMistDeathsFlat: {def.StarvationMistDeathsFlat}");

                Logger.Info($"[DataHelpers_Print] ---");
            }
            */

            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<TacticalAbilityDef>())
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");
                Logger.Info($"[DataHelpers_Print] Name: {def.ViewElementDef?.DisplayName1.Localize()} ({def.name})");
                Logger.Info($"[DataHelpers_Print] Desc: {def.ViewElementDef?.Description.Localize()}");

                Logger.Info($"[DataHelpers_Print] ActionPointCost: {def.ActionPointCost}");
                Logger.Info($"[DataHelpers_Print] WillPointCost: {def.WillPointCost}");
                Logger.Info($"[DataHelpers_Print] ---");
            }
            */

            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<GameDifficultyLevelDef>())
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");
                Logger.Info($"[DataHelpers_Print] StartingSupplies: {def.StartingSupplies}");
                Logger.Info($"[DataHelpers_Print] StartingMaterials: {def.StartingMaterials}");
                Logger.Info($"[DataHelpers_Print] StartingTech: {def.StartingTech}");
                Logger.Info($"[DataHelpers_Print] ExpEqualDistributionPart: {def.ExpEqualDistributionPart}");
                Logger.Info($"[DataHelpers_Print] SoldierSkillPointsPerMission: {def.SoldierSkillPointsPerMission}");
                Logger.Info($"[DataHelpers_Print] ExpConvertedToSkillpoints: {def.ExpConvertedToSkillpoints}");
                Logger.Info($"[DataHelpers_Print] MinPopulationThreshold: {def.MinPopulationThreshold}");

                Logger.Info($"[DataHelpers_Print] ---");
            }
            */

            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<AircraftBuffResearchRewardDef>())
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");
                Logger.Info($"[DataHelpers_Print] VehicleDef: {def.VehicleDef.name}");
                Logger.Info($"[DataHelpers_Print] ModData.SpeedMultiplier: {def.ModData.SpeedMultiplier}");
                Logger.Info($"[DataHelpers_Print] ModData.SpaceForUnits: {def.ModData.SpaceForUnits}");
                Logger.Info($"[DataHelpers_Print] ModData.RangeMultiplier: {def.ModData.RangeMultiplier}");

                Logger.Info($"[DataHelpers_Print] ---");
            }
            */

            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<TacCharacterDef>().Where(d => d.IsHuman))
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");
                Logger.Info($"[DataHelpers_Print] BonusStats: {def.Data.BonusStats}");
                Logger.Info($"[DataHelpers_Print] Armor: {String.Join(",", def.Data.BodypartItems.Select(i => i.name))}");
                Logger.Info($"[DataHelpers_Print] Equipment: {String.Join(",", def.Data.EquipmentItems.Select(i => i.name))}");
                Logger.Info($"[DataHelpers_Print] Inventory: {String.Join(",", def.Data.InventoryItems.Select(i => i.name))}");
                Logger.Info($"[DataHelpers_Print] ---");
            }
            */

            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<HealAbilityDef>().ToList())
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");
                Logger.Info($"[DataHelpers_Print] Description: {def.ViewElementDef?.Description?.LocalizeEnglish()}");

                Logger.Info($"[DataHelpers_Print] AdditionalEffectDef: {def.AdditionalEffectDef?.name}");

                Logger.Info($"[DataHelpers_Print] ---");
            }

            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<MultiEffectDef>().ToList())
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");
                //Logger.Info($"[DataHelpers_Print] Description: {def.ViewElementDef?.Description?.LocalizeEnglish()}");

                Logger.Info($"[DataHelpers_Print] EffectDefs: {String.Join(",", def.EffectDefs.Select(e => e.name))}");

                Logger.Info($"[DataHelpers_Print] ---");
            }
            */

            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<WeaponDef>())
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");
                //Logger.Info($"[DataHelpers_Print] Description: {def.ViewElementDef.Description.LocalizeEnglish()}");

                Logger.Info($"[DataHelpers_Print] DropOnActorDeath: {def.DropOnActorDeath}");
                Logger.Info($"[DataHelpers_Print] DestroyOnActorDeathPerc: {def.DestroyOnActorDeathPerc}");
                Logger.Info($"[DataHelpers_Print] DestroyWhenUsed: {def.DestroyWhenUsed}");
                Logger.Info($"[DataHelpers_Print] IsMountedToBody: {def.IsMountedToBody}");
                Logger.Info($"[DataHelpers_Print] BehaviorOnDisable: {def.BehaviorOnDisable}");

                Logger.Info($"[DataHelpers_Print] ---");
            }
            */

            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<TacMissionTypeDef>())
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");
                Logger.Info($"[DataHelpers_Print] Description: {def.Description.LocalizeEnglish()}");

                Logger.Info($"[DataHelpers_Print] DontRecoverItems: {def.DontRecoverItems}");
                Logger.Info($"[DataHelpers_Print] MaxPlayerUnits: {def.MaxPlayerUnits}");
                Logger.Info($"[DataHelpers_Print] AllowResourceCrateDeployment: {def.AllowResourceCrateDeployment}");
                Logger.Info($"[DataHelpers_Print] DifficultyThreatLevel: {def.DifficultyThreatLevel}");

                Logger.Info($"[DataHelpers_Print] ---");
            }
            */

            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<TimeRemainingFormatterDef>())
            {
                Logger.Info($"[DataHelpers_Print] Def: {def.name}");
                Logger.Info($"[DataHelpers_Print] Type: {def.GetType().Name}");
                Logger.Info($"[DataHelpers_Print] InfiniteText: {def.InfiniteText.Localize(null)}");

                Logger.Info($"[DataHelpers_Print] DaysText: {def.DaysText.Localize(null)}");
                Logger.Info($"[DataHelpers_Print] HoursText: {def.HoursText.Localize(null)}");

                Logger.Info($"[DataHelpers_Print] ---");
            }
            */

            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<ExperienceFacilityComponentDef>())
            {
                Logger.Info($"[DataHelpers_Print] def: {def.name}, Type: {def.GetType().Name}, SkillPointsPerDay: {def.SkillPointsPerDay}, ExperiencePerUser: {def.ExperiencePerUser}");
            }
            */

            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<HealFacilityComponentDef>())
            {
                Logger.Info($"[DataHelpers_Print] def: {def.name}, Type: {def.GetType().Name}, HealMutog: {def.HealMutog}, HealSoldier: {def.HealSoldier}, BaseHeal: {def.BaseHeal}, BaseStaminaHeal: {def.BaseStaminaHeal}");
            }
            */


            // Get vanilla descriptions
            /*
            foreach (var def in defRepository.DefRepositoryDef.AllDefs.OfType<ViewElementDef>())
            {
                Logger.Info($"[DataHelpers_Print] def: {def.name}, GUID: {def.Guid}");
                Logger.Info($"[DataHelpers_Print] DisplayName1: {def.DisplayName1.LocalizeEnglish()}");
                Logger.Info($"[DataHelpers_Print] DisplayName2: {def.DisplayName2.LocalizeEnglish()}");
                Logger.Info($"[DataHelpers_Print] Description: {def.Description.LocalizeEnglish()}");

                Logger.Info($"[DataHelpers_Print] SmallIcon: {def.SmallIcon}");
                Logger.Info($"[DataHelpers_Print] LargeIcon: {def.LargeIcon}");
                Logger.Info($"[DataHelpers_Print] InventoryIcon: {def.InventoryIcon}");
                Logger.Info($"[DataHelpers_Print] RosterIcon: {def.RosterIcon}");
            }
            */
        }



        // Get localization keys to use them elsewhere
        [HarmonyPatch(typeof(LocalizedTextBind), "Localize")]
        public static class LocalizedTextBind_Localize_Patch
        {
            public static bool Prepare()
            {
                return false;
            }

            public static void Postfix(LocalizedTextBind __instance, string __result)
            {
                try
                {
                    Logger.Info($"[DataHelpers][LocalizedTextBind_Localize_POSTFIX] LocalizationKey: {__instance.LocalizationKey}");
                    Logger.Info($"[DataHelpers][LocalizedTextBind_Localize_POSTFIX] Localization: {__result}");
                }
                catch (Exception e)
                {
                    Logger.Error(e);
                }
            }
        }
    }
}
