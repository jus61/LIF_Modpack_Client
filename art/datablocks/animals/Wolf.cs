//-----------------------------------------------------------------------------
// Torque Game Engine Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

datablock AnimalData(WolfData : DefaultPlayerData)   // datablock PlayerData
{
   id = 143; //CM_REV
  
   animalTypeId = 755;
   footprintTexture = "art/Textures/AnimalFootprints/Wolf_fs.png";
   footprintTextureLinearSize = 0.4;
   footprintGap = 0.6;
   footprintTrackWidth = 0.4;
   shapeFile = "art/models/3d/mobiles/wildanimals/wolf.dts";
   soundFilesPrefix = "wolf";
   
   behavior = "data/ai/cmAiWolf.xml";

   boundingBox = "1 2.4 1.8"; //"1.2 6.2 3.5"; 

   // should be identical to navmesh walkable slope
   runSurfaceAngle = 50;

   // parameters from BASE:
   maxHP = 150.0;
   bodyRadius = 2.5;
   
   rawCorpseObjectTypeID = 915;
   skinnedCorpseObjectTypeID = 928;
   
   weaponData = "Wolf_Fang"; 
   weaponWeight = 10.0;
   
   powerHitStartingDistance = 1.2;
   powerHitDamagingDistance = 1.4;
   powerHitDamagingSector = 90;
   powerHitMinSpeed = 15;      //power_hit_base_damage_min
   powerHitMaxSpeed = 25;      //power_hit_base_damage_max
   
   fastHitStartingDistance = 1.2;
   fastHitDamagingDistance = 1.4;
   fastHitDamagingSector = 90;
   fastHitMinSpeed = 5;       //fast_hit_base_damage_min
   fastHitMaxSpeed = 10;      //fast_hit_base_damage_max
   
   walkAnimationSpeed = 1.72;
   runAnimationSpeed = 1.21;
   walkSpeed = 2;
   runSpeed = 8;
   
   animalType = "Predator";
};