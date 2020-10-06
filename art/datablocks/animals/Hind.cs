//-----------------------------------------------------------------------------
// Torque Game Engine Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

datablock AnimalData(HindData : DefaultPlayerData)   // datablock PlayerData AI_AnimalData
{
   id = 142; //CM_REV
 
   animalTypeId = 778;
   footprintTexture = "art/Textures/AnimalFootprints/Deer_fs.png";
   footprintTextureLinearSize = 0.4;
   footprintGap = 0.9;
   footprintTrackWidth = 0.3;
   shapeFile = "art/models/3d/mobiles/wildanimals/hind.dts";
   soundFilesPrefix = "deer";

   behavior = "data/ai/cmAiHind.xml";
   
   boundingBox = "1.5 4 3.5";

   // should be identical to navmesh walkable slope
   runSurfaceAngle = 50;

   // parameters from BASE:
   maxHP = 120.0;
   bodyRadius = 3.3;
   
   rawCorpseObjectTypeID = 914;
   skinnedCorpseObjectTypeID = 927;
   
   weaponData = "Hind_Hoof";
   weaponWeight = 10.0;
   
   powerHitStartingDistance = 3.0;
   powerHitDamagingDistance = 3.2;
   powerHitDamagingSector = 90;
   powerHitMinSpeed = 2;
   powerHitMaxSpeed = 4;
   
   fastHitStartingDistance = 3.0;
   fastHitDamagingDistance = 3.1;
   fastHitDamagingSector = 90;
   fastHitMinSpeed = 1;
   fastHitMaxSpeed = 3;
   
   walkAnimationSpeed = 0.95;
   runAnimationSpeed = 0.52;
   walkSpeed = 2;
   runSpeed = 8;
   
   animalType = "Peaceful";
};