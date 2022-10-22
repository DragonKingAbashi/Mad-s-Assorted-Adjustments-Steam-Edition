using System;
using System.Reflection;
using PhoenixPoint.Modding;

namespace MadsAssortedAdjustment
{
    /// <summary>
    /// ModConfig is mod settings that players can change from within the game.
    /// Config is only editable from players in main menu.
    /// Only one config can exist per mod assembly.
    /// Config is serialized on disk as json.
    /// </summary>
    public class MadsAssortedAdjustmentConfig
    {
        internal static object Settings;

        public static bool AgendaTrackerAddMissionObjective { get; internal set; }

        public static explicit operator MadsAssortedAdjustmentConfig(ModConfig v)
        {
            throw new NotImplementedException();
        }
    }

    internal class Settings
    {

        [ConfigField("Disables the rock tiles in phoenix bases completely.")]
        public bool DisableRocksAtBases = true;
        [ConfigField("Will only show the confirmation popup when moving a unit to the evacuation zone if the whole squad is ready to evacuate. You can still evacuate single units by using the ability bar.", "True")]
        public bool EnableSmartEvacuation = true;
        [ConfigField("Will preselect the closest phoenix base to the screen's center when entering the bases menu at the bottom.", "True")]
        public bool EnableSmartBaseSelection = true;
        [ConfigField("If an aircraft is completely empty you can scrap it from the roster list.")]
        public bool EnableScrapAircraft;

        [ConfigField("Adds various items to the agenda tracker above the time controller.", "True")]
        public bool EnableExtendedAgendaTracker = true;
        [ConfigField("Adds vehicle-related entries (travel and exploration times) to the agenda tracker")]
        public bool AgendaTrackerShowVehicles = true;
        [ConfigField("Adds excavation-related entries (excavation times) to the agenda tracker")]
        public bool AgendaTrackerShowExcavations = true;
        [ConfigField("Adds incoming base defense missions to the agenda tracker")]
        public bool AgendaTrackerShowBaseDefenses = true;
        [ConfigField("Hides status bar. This shows 'timed events' (excavation and base defense countdowns) in vanilla and is not needed when the items are displayed in the tracker")]
        public bool AgendaTrackerHideStatusBar = false;
        [ConfigField("Adds a secondary objective to take control of a recently excavated site")]
        public bool AgendaTrackerAddMissionObjective = true;

        [ConfigField("General switch to enable the related subfeatures.", "True")]
        public bool EnableUIEnhancements = true;
        [ConfigField("Shows current production and research points behind the facility count and adds some related information to the manufacturing and research screens.")]
        public bool ShowDetailedResearchAndProduction = true;
        [ConfigField("Shows personal abilities and augmentations (if any) of recruits in havens.")]
        public bool ShowRecruitInfoInsideZoneTooltip = true;
        [ConfigField("Adds current healing rates to the bases tooltip in geoscape. Adds tooltips to the left-hand side menu in the bases screen and the bases info in recruitment screen.")]
        public bool ShowExtendedBaseInfo = true;
        [ConfigField("Adds trade information and recruit class/level to the haven popups.")]
        public bool ShowExtendedHavenInfo = true;

        [ConfigField("General switch to enable the related subfeatures.", "True")]
        public bool UnlockItemsByResearch = true;
        [ConfigField("Unlocks phoenix elite gear.")]
        public bool UnlockPhoenixEliteGear = true;
        [ConfigField("Unlocks living weapons for manufacturing.")]
        public bool UnlockLivingWeapons = true;
        [ConfigField("Unlocks living armor for manufacturing.")]
        public bool UnlockLivingArmor = true;
        [ConfigField("Unlocks independent ammunition items after basic research is completed.")]
        public bool UnlockIndependentAmmunition = true;
        [ConfigField("Unlocks independent weapons items after basic research is completed.")]
        public bool UnlockIndependentWeapons = true;
        [ConfigField("Unlocks independent armor items after basic research is completed.")]
        public bool UnlockIndependentArmor = true;
        [ConfigField("Unlocks hidden items after basic research is completed. ")]
        public bool UnlockHiddenItems = true;

        [ConfigField("Override some difficulty settings", "True")]
        public bool EnableDifficultyOverrides = true;
        [ConfigField("Amount of supplies you'll start the game with, vanilla defaults: { Easy: 800, Standard: 500, Hard: 300, VeryHard: 200 }")]
        public float DifficultyOverrideStartingSupplies = 800f;
        [ConfigField("Amount of materials you'll start the game with, vanilla defaults: { Easy: 1000, Standard: 700, Hard: 500, VeryHard: 400 }")]
        public float DifficultyOverrideStartingMaterials = 1000f;
        [ConfigField("Amount of tech you'll start the game with, vanilla defaults: { Easy: 200, Standard: 150, Hard: 100, VeryHard: 80 }")]
        public float DifficultyOverrideStartingTech = 200f;
        [ConfigField("How much flat skill points each alive soldier will get, vanilla defaults: { Easy: 12, Standard: 10, Hard: 8, VeryHard: 5 }")]
        public int DifficultyOverrideSoldierSkillPointsPerMission = 12;
        [ConfigField("How much of total experience will be converted to PX skill points, vanilla defaults: { Easy: 0.02, Standard: 0.015, Hard: 0.01, VeryHard: 0.01 }")]
        public float DifficultyOverrideExpConvertedToSkillpoints = 0.02f;
        [ConfigField("How much geoscape population (% of starting) must drop to reach game over, vanilla defaults: {Easy: 5, Standard: 10, Hard: 15, VeryHard: 20}")]
        public int DifficultyOverrideMinPopulationThreshold = 5;
        [ConfigField("How much % of starving population at a haven will die each day, vanilla default is 0.01 (1%)")]
        public float DifficultyOverrideStarvationDeathsPart = 0.01f;
        [ConfigField("How much % of starving population at a haven will die each day if in mist, vanilla default is 0.03 (3%)")]
        public float DifficultyOverrideStarvationMistDeathsPart = 0.03f;
        [ConfigField("Additional deaths of starving population at a haven each day, vanilla default is 5")]
        public int DifficultyOverrideStarvationDeathsFlat = 5;
        [ConfigField("Additional deaths of starving population at a haven each day if in mist, vanilla default is 15")]
        public int DifficultyOverrideStarvationMistDeathsFlat = 15;
        [ConfigField("Completely disable population reduction by starvation. Only haven destructions will drop the bar.")]
        public bool DifficultyOverrideDisableDeathByStarvation = false;
        [ConfigField("Mist expansion rate in kilometres per hour, vanilla default is 30")]
        public int DifficultyOverrideMistExpansionRate = 30;

        [ConfigField("Fully leveled soldiers will convert some experience to skill points.")]
        public bool EnableExperienceToSkillpointConversion = true;
        [ConfigField("Will add the converted skill points to the soldier's pool.")]
        public bool XPtoSPAddToPersonalPool = false;
        [ConfigField("Will add the converted skill points to the faction's pool.")]
        public bool XPtoSPAddToFactionPool = true;
        [ConfigField("Will multiply the converted skill points by its value.")]
        public float XPtoSPConversionMultiplier = 2f;
        internal float XPtoSPConversionRate = 0.01f; // Default is dependent on difficulty setting, this is just a fallback if the setting is unretrievable.

        [ConfigField("General switch to enable the related subfeatures")]
        public bool EnableFacilityAdjustments = true;
        // Healing
        [ConfigField("Healing rate for medical bays, vanilla default is 4")]
        public float MedicalBayBaseHeal = 8f;
        [ConfigField("Stamina regeneration rate for living quarters, vanilla default is 2")]
        public float LivingQuartersBaseStaminaHeal = 4f;
        [ConfigField("Healing rate for aircraft at vehicle bays, vanilla default is 48")]
        public int VehicleBayAircraftHealAmount = 60;
        [ConfigField("Healing rate for vehicles at vehicle bays, vanilla default is 20")]
        public int VehicleBayVehicleHealAmount = 40;
        [ConfigField("Healing rate for mutogs at mutation labs, vanilla default is 20")]
        public int MutationLabMutogHealAmount = 40;
        //Training
        [ConfigField("Experience gain rate per hour for soldiers at training facilities, vanilla default is 2")]
        public int TrainingFacilityBaseExperienceAmount = 2;
        [ConfigField("Enables training facilities to add skillpoints to the faction pool.")]
        public bool TrainingFacilitiesGenerateSkillpoints = true;
        [ConfigField("Global skillpoints gain rate per day per facility")]
        public int TrainingFacilityBaseSkillPointsAmount = 1;
        // Resource Generators
        [ConfigField("Production points generated at fabrication plants, vanilla default is 4")]
        public float FabricationPlantGenerateProductionAmount = 4f;
        [ConfigField("Research points generated at research labs, vanilla default is 4")]
        public float ResearchLabGenerateResearchAmount = 4f;
        [ConfigField("Supplies (Food) generated at food production facilities, vanilla default is 0.33 (translates to 8 food/day).", "0.5")]
        public float FoodProductionGenerateSuppliesAmount = 0.5f;
        [ConfigField("Research points generated at bionic labs, vanilla default is 4", "4")]
        public float BionicsLabGenerateResearchAmount = 4f;
        [ConfigField("Mutagen points generated at mutation labs, vanilla default is 0.25 (translates to 6 mutagen/day).", "0.25")]
        public float MutationLabGenerateMutagenAmount = 0.25f;
        // Add Tech & Materials to Facilities
        [ConfigField("Fabrication plant generate this amount of materials per day.", "1")]
        public float FabricationPlantGenerateMaterialsAmount = 1f;
        [ConfigField("Research labs generate this amount of tech per day.", "1")]
        public float ResearchLabGenerateTechAmount = 1f;
        internal float GenerateResourcesBaseDivisor = 24f;

        [ConfigField("General switch to enable the related subfeatures.")]
        public bool EnableEconomyAdjustments = true;
        [ConfigField("General multiplier for manufacturing costs.")]
        public float ResourceMultiplier = 0.75f;
        [ConfigField("General multiplier for scrapping costs, vanilla default is 0.5")]
        public float ScrapMultiplier = 0.5f;
        [ConfigField("General multiplier for manufacturing times.")]
        public float CostMultiplier = 0.5f;

        [ConfigField("Suppresses the 'Nothing found' event when exploring sites.")]
        public bool DisableNothingFound = true;

        [ConfigField("Keeps the game paused/pauses the game when setting a new target for an aircraft.")]
        public bool PauseOnDestinationSet = true;
        [ConfigField("Keeps the game paused/pauses the game when exploring a new site.")]
        public bool PauseOnExplorationSet = false;
        [ConfigField("Pauses the game when new recruits have arrived at phoenix bases.")]
        public bool PauseOnRecruitsGenerated = true;
        [ConfigField("Pauses the game when a squad is fully rested.")]
        public bool PauseOnHealed = true;
        internal bool CenterOnHealed = true;
        [ConfigField("Centers view on the haven that was just discovered.")]
        public bool CenterOnHavenRevealed = true;
        [ConfigField("Centers view on the ancient site that was just excavated.")]
        public bool CenterOnExcavationComplete = true;
        internal bool CenterOnVehicleArrived = true;

        [ConfigField("Enables some logging if errors occur")]
        public bool Debug = true;
        internal int DebugLevel = 1;
        [ConfigField("Magical setting that allows the developer to trigger code for personal use.")]
        public string DebugDevKey = "";
        public int PresetStateHash = -1;

        public string BalancePresetId { get; internal set; }
        public string BalancePresetState { get; internal set; }
        public bool UnlockHiddenItem { get; internal set; }

        public bool Equals(Settings obj)
        {
            Type t = this.GetType();
            Type o = obj.GetType();

            if (t != o)
            {
                return false;
            }

            FieldInfo[] tFields = t.GetFields(BindingFlags.Instance | BindingFlags.Public);
            //FieldInfo[] oFields = o.GetFields(BindingFlags.Instance | BindingFlags.Public);


            foreach (FieldInfo fi in tFields)
            {
                if (fi.Name == "BalancePresetId" || fi.Name == "BalancePresetState" || fi.Name == "DebugDevKey" || fi.Name == "PresetStateHash")
                {
                    continue;
                }

                object tValue = fi.GetValue(this);
                object oValue = fi.GetValue(obj);
                Logger.Info($"[Settings_Equals] {fi.Name}: {tValue} <-> {oValue}");

                if (!tValue.Equals(oValue))
                {
                    return false;
                }
            }

            return true;
        }



        public override string ToString()
        {
            string result = "";
            Type t = this.GetType();
            FieldInfo[] fields = t.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            foreach (FieldInfo fi in fields)
            {
                result += "\n";
                result += fi.Name;
                result += ": ";
                result += fi.GetValue(this).ToString();
            }
            return result;
        }



        public void ToHtmlFile(string destination)
        {
            string result = "<!doctype html><html lang=en><head><meta charset=utf-8><title>Assorted Adjustments: Settings</title><style>html {font-family: sans-serif;} body {padding:2em;} h1 {padding-left: 10px;} th {font-size:1.4em;}</style></head><body>\n";
            result += "<h1>SETTINGS</h1>\n";

            result += "<table cellpadding=0 cellspacing=10>\n";
            result += $"<tr><th align=left>Name</th><th align=left>Value</th><th align=left>Description</th><th align=right>Default</th></tr>\n";

            Type t = this.GetType();
            FieldInfo[] fields = t.GetFields(BindingFlags.Instance | BindingFlags.Public);

            foreach (FieldInfo fi in fields)
            {
                Annotation annotation = Attribute.IsDefined(fi, typeof(Annotation)) ? (Annotation)Attribute.GetCustomAttribute(fi, typeof(Annotation)) : null;

                string settingName = fi.Name;
                string setValue = fi.GetValue(this).ToString();
                string settingDesc = annotation?.Description;
                string defaultValue = annotation?.DefaultValue;

                if (annotation?.DefaultValue != null && setValue != defaultValue)
                {
                    setValue = $"<b>{setValue}</b>";
                }

                if (annotation != null && annotation.StartSection)
                {
                    result += $"<tr><td colspan=4><br><b>{annotation.SectionLabel}</b></td></tr>\n";
                }

                result += "<tr><td>";
                result += $" {settingName} ";
                result += "</td><td>";
                result += $" {setValue} ";
                result += "</td><td>";
                result += $" {settingDesc} ";
                result += "</td><td align=right>";
                result += $" <i>{defaultValue}</i> ";
                result += "</td></tr>\n";
            }
            result += "</table></body></html>";

            System.IO.File.WriteAllText(destination, result);
        }



        public void ToMarkdownFile(string destination)
        {
            string result = "";
            result += "# SETTINGS";
            result += "\n\n";

            result += $"|Name|Value|Description|Default|\n";
            result += $"|:---|:----|:----------|:-----:|\n";

            Type t = this.GetType();
            FieldInfo[] fields = t.GetFields(BindingFlags.Instance | BindingFlags.Public);

            foreach (FieldInfo fi in fields)
            {
                Annotation annotation = Attribute.IsDefined(fi, typeof(Annotation)) ? (Annotation)Attribute.GetCustomAttribute(fi, typeof(Annotation)) : null;

                string settingName = fi.Name;
                string setValue = fi.GetValue(this).ToString();
                string settingDesc = annotation?.Description;
                string defaultValue = annotation?.DefaultValue;

                if (annotation?.DefaultValue != null && setValue != defaultValue)
                {
                    setValue = $"<b>{setValue}</b>";
                }

                if (annotation != null && annotation.StartSection)
                {
                    result += $"| . | . | . | . |\n";
                    result += $"| . | . | . | . |\n";
                    result += $"| . | . | . | . |\n";
                    result += $"| <b>{annotation.SectionLabel}</b> | | | |\n";
                }

                result += "|";
                result += $" {settingName} ";
                result += "|";
                result += $" {setValue} ";
                result += "|";
                result += $" {settingDesc} ";
                result += "|";
                result += $" <i>{defaultValue}</i> ";
                result += "|\n";
            }

            System.IO.File.WriteAllText(destination, result);
        }
    }
}
