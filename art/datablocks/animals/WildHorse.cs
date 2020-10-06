//-----------------------------------------------------------------------------
// Torque Game Engine Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

datablock AnimalData(WildHorseData : DefaultPlayerData)   // datablock PlayerData
{
   id = 119; //CM_REV

   animalTypeId = 753;
   footprintTexture = "art/Textures/AnimalFootprints/Wildhorse_fs.png";
   footprintTextureLinearSize = 0.6;
   footprintGap = 0.9;
   footprintTrackWidth = 0.5;
   shapeFile = "art/models/3d/mobiles/wildanimals/wildhorse.dts";
   soundFilesPrefix = "wildhorse";

   behavior = "data/ai/cmAiWildHorse.xml";
   
   boundingBox = "1.2 5 3.8"; //"1.2 6.2 3.5";

   // should be identical to navmesh walkable slope
   runSurfaceAngle = 50;

   // parameters from BASE:
   maxHP = 180.0;
   bodyRadius = 4.3;
   
   rawCorpseObjectTypeID = 912;
   skinnedCorpseObjectTypeID = 925;
   
   weaponData = "Wild_Horse_Hoof";
   weaponWeight = 10.0;
   
   powerHitStartingDistance = 4.0;
   powerHitDamagingDistance = 4.2;
   powerHitDamagingSector = 90;
   powerHitMinSpeed = 20;
   powerHitMaxSpeed = 30;
   
   fastHitStartingDistance = 4.0;
   fastHitDamagingDistance = 4.2;
   fastHitDamagingSector = 90;
   fastHitMinSpeed = 10;
   fastHitMaxSpeed = 15;
   
   walkAnimationSpeed = 1.09;
   runAnimationSpeed = 0.59;
   walkSpeed = 3;
   runSpeed = 9;
   
   animalType = "Peaceful";
};
