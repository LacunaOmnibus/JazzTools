﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzToolUtilities
{
    //utilies for use with Jazz Tools
     public static class JazzToolUtilities
    {
         static Dictionary<string, string> buildingTypes = new Dictionary<string, string>()
             {
                 {"Algae", "Resource"},
                 {"AlgaePond", "Glyph"},
                 {"AmalgusMeadow", "Glyph"},
                 {"Apple", "Resource"},
                {"Archaeology", "Secondary"},
                {"AtmosphericEvaporator", "Resource"},
                {"Beach", "Glyph"},
                {"Bean", "Resource"},
                {"Beeldeban", "Resource"},
                {"BeeldebanNest", "Glyph"},
                {"BlackHoleGenerator", "Glyph"},
                {"Bread", "Resource"},
                {"Burger", "Resource"},
                {"Capitol", "Secondary"},
                {"Cheese", "Resource"},
                {"Chip", "Resource"},
                {"Cider", "Resource"},
                {"CitadelOfKnope", "Glyph"},
                {"CloakingLab", "Combat"},
                {"Corn", "Resource"},
                {"CornMeal", "Resource"},
                {"CrashedShipSite", "Glyph"},
                {"Crater", "Glyph"},
                {"Dairy", "Resource"},
                {"Denton", "Resource"},
                {"DentonBrambles", "Glyph"},
                {"DeployedBleeder", "Critical"},
                {"Development", "Secondary"},
                {"DistributionCenter", "Resource"},
                {"Embassy", "Secondary"},
                {"EnergyReserve", "Resource"},
                {"Entertainment", "Resource"},
                {"Espionage", "Combat"},
                {"EssentiaVein", "Glyph"},
                {"Fission", "Resource"},
                {"Fissure", "Critical"},
                {"FoodReserve", "Resource"},
                {"Fusion", "Resource"},
                {"GasGiantLab", "Secondary"},
                {"GasGiantPlatform", "Resource"},
                {"GeneticsLab", "Secondary"},
                {"Geo", "Resource"},
                {"GeoThermalVent", "Glyph"},
                {"GratchsGauntlet", "Glyph"},
                {"GreatBallOfJunk", "Glyph"},
                {"Grove", "Glyph"},
                {"HallsOfVrbansk", "Glyph"},
                {"Hydrocarbon", "Resource"},
                {"Intelligence", "Combat"},
                {"IntelTraining", "Secondary"},
                {"InterDimensionalRift", "Glyph"},
                {"JunkHengeSculpture", "Glyph"},
                {"KalavianRuins", "Glyph"},
                {"KasternsKeep", "Glyph"},
                {"Lake", "Glyph"},
                {"Lagoon", "Glyph"},
                {"Lapis", "Resource"},
                {"LapisForest", "Glyph"},
                {"LibraryOfJith", "Glyph"},
                {"LostCityOfTyleon", "Resource"},
                {"LuxuryHousing", "Resource"},
                {"Malcud", "Resource"},
                {"MalcudField", "Glyph"},
                {"MassadsHenge", "Glyph"},
                {"MayhemTraining", "Secondary"},
                {"MercenariesGuild", "Secondary"},
                {"MetalJunkArches", "Glyph"},
                {"Mine", "Resource"},
                {"MiningMinistry", "Resource"},
                {"MissionCommand", "Secondary"},
                {"MunitionsLab", "Combat"},
                {"NaturalSpring", "Glyph"},
                {"Network19", "Resource"},
                {"Observatory", "Secondary"},
                {"OracleOfAnid", "Glyph"},
                {"OreRefinery", "Resource"},
                {"OreStorage", "Resource"},
                {"Oversight", "Secondary"},
                {"Pancake", "Resource"},
                {"PantheonOfHagness", "Glyph"},
                {"Park", "Resource"},
                {"Pie", "Resource"},
                {"PilotTraining", "Combat"},
                {"PlanetaryCommand", "Secondary"},
                {"PoliticsTraining", "Secondary"},
                {"Potato", "Resource"},
                {"Propulsion", "Combat"},
                {"PyramidJunkSculpture", "Glyph"},
                {"Ravine", "Glyph"},
                {"RockyOutcrop", "Glyph"},
                {"Sand", "Glyph"},
                {"SAW", "Combat"},
                {"Security", "Combat"},
                {"Shake", "Resource"},
                {"Shipyard", "Combat"},
                {"Singularity", "Resource"},
                {"Soup", "Resource"},
                {"SpaceJunkPark", "Glyph"},
                {"SpacePort", "Combat"},
                {"SpaceStationLab", "Secondary"},
                {"Stockpile", "Secondary"},
                {"SubspaceSupplyDepot", "Secondary"},
                {"SupplyPod", "Secondary"},
                {"Syrup", "Resource"},
                {"TempleOfTheDrajilites", "Glyph"},
                {"TerraformingLab", "Secondary"},
                {"TerraformingPlatform", "Resource"},
                {"TheDillonForge", "Glyph"},
                {"TheftTraining", "Secondary"},
                {"ThemePark", "Resource"},
                {"Trade", "Combat"},
                {"Transporter", "Secondary"},
                {"University", "Secondary"},
                {"Volcano", "Glyph"},
                {"WasteDigester", "Resource"},
                {"WasteEnergy", "Resource"},
                {"WasteExchanger", "Resource"},
                {"WasteRecycling", "Resource"},
                {"WasteSequestration", "Resource"},
                {"WasteTreatment", "Resource"},
                {"WaterProduction", "Resource"},
                {"WaterPurification", "Resource"},
                {"WaterReclamation", "Resource"},
                {"WaterStorage", "Resource"},
                {"Wheat", "Resource"},
             };
         
         

    }
}