//-----------------------------------------------------------------------------
// Torque Game Engine Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

datablock AnimalData(BoarData : DefaultPlayerData)   // datablock PlayerData
{
   id = 117; //CM_REV
  
   animalTypeId = 757;
   footprintTexture = "art/Textures/AnimalFootprints/Boar_fs.png";
   footprintTextureLinearSize = 0.5;
   footprintGap = 0.7;
   footprintTrackWidth = 0.35;
   shapeFile = "art/models/3d/mobiles/wildanimals/boar.dts";
   soundFilesPrefix = "boar";

   behavior = "data/ai/cmAiBoar.xml";

   boundingBox = "1.2 3 1.7"; //"1.2 6.2 3.5";    

   // should be identical to navmesh walkable slope
   runSurfaceAngle = 50;

   // parameters from BASE:
   maxHP = 200.0;
   bodyRadius = 2.7;
   
   rawCorpseObjectTypeID = 917;
   skinnedCorpseObjectTypeID = 930;
   
   weaponData = "Boar_Tusk";
   weaponWeight = 10.0;
   
   powerHitStartingDistance = 1.7;
   powerHitDamagingDistance = 1.9;
   powerHitDamagingSector = 90;
   powerHitMinSpeed = 15;      //power_hit_base_damage_min
   powerHitMaxSpeed = 25;      //power_hit_base_damage_max
   
   fastHitStartingDistance = 1.6;
   fastHitDamagingDistance = 1.7;
   fastHitDamagingSector = 90;
   fastHitMinSpeed = 5;       //fast_hit_base_damage_min
   fastHitMaxSpeed = 10;      //fast_hit_base_damage_max
   
   walkAnimationSpeed = 1.76;
   runAnimationSpeed = 1.06;
   walkSpeed = 2;
   runSpeed = 7;
   
   animalType = "Predator";
};