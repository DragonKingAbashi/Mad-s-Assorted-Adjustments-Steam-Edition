﻿using System;
using PhoenixPoint.Geoscape.View.ViewModules;
using PhoenixPoint.Geoscape.Levels;
using PhoenixPoint.Common.Core;
using PhoenixPoint.Geoscape.View.ViewControllers.Research;
using PhoenixPoint.Geoscape.View.ViewControllers.Manufacturing;
using PhoenixPoint.Common.Entities.Items;
using UnityEngine;
using PhoenixPoint.Geoscape.Entities;
using Base.Core;
using HarmonyLib;
using static System.Net.Mime.MediaTypeNames;
using UnityEngine.UI;
using Text = UnityEngine.UI.Text;

namespace MadsAssortedAdjustment.Patches
{
    internal static class DetailedResearchAndProduction
    {
        private static float totalResearch = 0;
        private static float totalProduction = 0;



        [HarmonyPatch(typeof(ResearchListItem), "SetTime")]
        public static class ResearchListItem_SetTime_Patch
        {


            public static void Postfix(ResearchListItem __instance, Text timeText)
            {
                try
                {
                    int itemResearchCost = __instance.Research.ResearchCost;
                    Logger.Debug($"[ResearchListItem_SetTime_POSTFIX] itemResearchCost:  {itemResearchCost}");

                    /*
                    //float num = __instance.Research.Faction.Research.GetHourlyResearchProduction(__instance.Research.ResearchDef);
                    //num += __instance.Research.Faction.Research.GetAlliesContribution(__instance.Research);

                    MethodInfo ___GetHourlyResearchProduction = typeof(Research).GetMethod("GetHourlyResearchProduction", BindingFlags.NonPublic | BindingFlags.Instance);
                    MethodInfo ___GetAlliesContribution = typeof(Research).GetMethod("GetAlliesContribution", BindingFlags.NonPublic | BindingFlags.Instance);
                    float hourlyResearchProduction = (float)___GetHourlyResearchProduction.Invoke(__instance.Research.Faction.Research, new object[] { __instance.Research.ResearchDef });
                    hourlyResearchProduction += (float)___GetAlliesContribution.Invoke(__instance.Research.Faction.Research, new object[] { __instance.Research });
                    int dailyResearchProduction = (int)hourlyResearchProduction * 24;

                    Logger.Debug($"[ResearchListItem_SetTime_POSTFIX] hourlyResearchProduction:  {hourlyResearchProduction}");
                    Logger.Debug($"[ResearchListItem_SetTime_POSTFIX] dailyResearchProduction:  {dailyResearchProduction}");
                    */

                    string org = timeText.text;
                    string add = $"{itemResearchCost} RP";

                    timeText.text = $"{add} ~ {org}";
                }
                catch (Exception e)
                {
                    Logger.Error(e);
                }
            }
        }



        [HarmonyPatch(typeof(GeoManufactureItem), "Init", new Type[] { typeof(ItemDef), typeof(GeoFaction), typeof(UIModuleManufacturing.UIMode), typeof(ItemStorage), typeof(VehicleEquipmentStorage), typeof(bool) })]
        public static class GeoManufactureItem_Init_Patch
        {

            public static void Postfix(GeoManufactureItem __instance, ItemDef item, GeoFaction faction, UIModuleManufacturing.UIMode mode)
            {
                try
                {
                    if (mode != UIModuleManufacturing.UIMode.Manufacture)
                    {
                        return;
                    }

                    ManufacturableItem manufacturableItem = faction.Manufacture.GetManufacturableItemByDef(__instance.ItemDef);
                    TimeUnit totalTime = faction.Manufacture.GetTotalTime(manufacturableItem);

                    if (manufacturableItem == null || totalTime == TimeUnit.Zero)
                    {
                        return;
                    }

                    int itemManufactureCost = manufacturableItem.CostInManufacturePoints;
                    //Logger.Info($"[GeoManufactureItem_Init_POSTFIX] itemManufactureCost:  {itemManufactureCost}");

                    if (itemManufactureCost > 0)
                    {
                        string org = __instance.ManufactureTimeText.text;
                        string add = $"{itemManufactureCost} MP";

                        __instance.ManufactureTimeText.text = $"{add} ~ {org}";
                    }
                }
                catch (Exception e)
                {
                    Logger.Error(e);
                }
            }
        }



        [HarmonyPatch(typeof(UIModuleInfoBar), "UpdateResourceInfo")]
        public static class UIModuleInfoBar_UpdateResourceInfo_Patch
        {

            public static void Postfix(UIModuleInfoBar __instance, GeoFaction faction)
            {
                try
                {
                    //Logger.Debug($"[UIModuleInfoBar_UpdateResourceInfo_POSTFIX] faction: {faction.Name.LocalizeEnglish()}");

                    // Create a bit more space for the additional text
                    LayoutElement layoutProduction = __instance.ProductionRoot.GetComponent<LayoutElement>();
                    layoutProduction.preferredWidth = 150f;
                    layoutProduction.minWidth = 150f;
                    LayoutElement layoutResearch = __instance.ResearchRoot.GetComponent<LayoutElement>();
                    layoutResearch.preferredWidth = 150f;
                    layoutResearch.minWidth = 150f;

                    ResourcePack totalOutput = faction.ResourceIncome.GetTotalOutput();
                    totalResearch = totalOutput.ByResourceType(ResourceType.Research).Value * 24f;
                    totalProduction = totalOutput.ByResourceType(ResourceType.Production).Value * 24f;

                    //Logger.Info($"[UIModuleInfoBar_UpdateResourceInfo_POSTFIX] totalResearch: {totalResearch}");
                    //Logger.Info($"[UIModuleInfoBar_UpdateResourceInfo_POSTFIX] totalProduction: {totalProduction}");

                    string orgResearchLabel = __instance.ResearchLabel.text;
                    string addResearchLabel = $"[{totalResearch}]";
                    __instance.ResearchLabel.text = $"{orgResearchLabel} {addResearchLabel}";

                    string orgProductionLabel = __instance.ProductionLabel.text;
                    string addProductionLabel = $"[{totalProduction}]";
                    __instance.ProductionLabel.text = $"{orgProductionLabel} {addProductionLabel}";
                }
                catch (Exception e)
                {
                    Logger.Error(e);
                }
            }
        }



        [HarmonyPatch(typeof(UITooltipText), "OnMouseEnter")]
        public static class UITooltipText_OnMouseEnter_Patch
        {

            public static void Postfix(UITooltipText __instance, GameObject ____widget)
            {
                try
                {
                    if (!__instance.Enabled || __instance.TipKey == null || string.IsNullOrEmpty(__instance.TipKey.LocalizationKey))
                    {
                        return;
                    }

                    // Override some keys
                    if (__instance.TipKey.LocalizationKey == "KEY_RESEARCH_TOTAL_TT")
                    {
                        Logger.Debug($"[UITooltipText_OnMouseEnter_POSTFIX] TipKey: {__instance.TipKey.LocalizationKey}");
                        Logger.Debug($"[UITooltipText_OnMouseEnter_POSTFIX] TipText: {__instance.TipText}");

                        //string org = __instance.TipText;
                        //string add = $"Current output is {totalResearch} RESEARCH.)";
                        //__instance.UpdateText($"{org}\n{add}");

                        string replace = $"RESEARCH LABS - Accelerate research projects";
                        string add = "";
                        if (AssortedAdjustments.Settings.EnableFacilityAdjustments && AssortedAdjustments.Settings.ResearchLabGenerateTechAmount > 0f)
                        {
                            add = $" and TECH generation";
                        }
                        __instance.UpdateText($"{replace}{add}");
                    }
                    else if (__instance.TipKey.LocalizationKey == "KEY_PRODUCTION_TOTAL_TT")
                    {
                        Logger.Debug($"[UITooltipText_OnMouseEnter_POSTFIX] TipKey: {__instance.TipKey.LocalizationKey}");
                        Logger.Debug($"[UITooltipText_OnMouseEnter_POSTFIX] TipText: {__instance.TipText}");

                        //string org = __instance.TipText;
                        //string add = $"Current output is {totalProduction} PRODUCTION.)";
                        //__instance.UpdateText($"{org}\n{add}");

                        string replace = $"FABRICATION PLANTS - Accelerate manufacturing projects";
                        string add = "";
                        if (!(!AssortedAdjustments.Settings.EnableFacilityAdjustments || AssortedAdjustments.Settings.FabricationPlantGenerateMaterialsAmount <= 0f))
                        {
                            add = $" and MATERIALS generation";
                        }
                        __instance.UpdateText($"{replace}{add}");
                    }
                }
                catch (Exception e)
                {
                    Logger.Error(e);
                }
            }
        }
    }
}
