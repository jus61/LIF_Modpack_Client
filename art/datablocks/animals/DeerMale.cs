//-----------------------------------------------------------------------------
// Torque Game Engine Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

datablock AnimalData(DeerMaleData : DefaultPlayerData)   // datablock PlayerData AI_AnimalData
{
   id = 61; //CM_REV
 
   animalTypeId = 754;
   footprintTexture = "art/Textures/AnimalFootprints/Deer_fs.png";
   footprintTextureLinearSize = 0.4;
   footprintGap = 0.7;
   footprintTrackWidth = 0.4;
   shapeFile = "art/models/3d/mobiles/wildanimals/deer.dts";
   soundFilesPrefix = "deer";

   behavior = "data/ai/cmAiDeerMale.xml";

   boundingBox = "1.5 4 3.5"; 

   // should be identical to navmesh walkable slope
   runSurfaceAngle = 50;

   // parameters from BASE:
   maxHP = 200.0;
   bodyRadius = 3.3;
   
   rawCorpseObjectTypeID = 913;
   skinnedCorpseObjectTypeID = 926;
   
   weaponData = "Deer_Hoof";
   weaponWeight = 10.0;
   
   powerHitStartingDistance = 3.0;
   powerHitDamagingDistance = 3.2;
   powerHitDamagingSector = 90;
   powerHitMinSpeed = 3;
   powerHitMaxSpeed = 6;
   
   fastHitStartingDistance = 3.0;
   fastHitDamagingDistance = 3.1;
   fastHitDamagingSector = 90;
   fastHitMinSpeed = 2;
   fastHitMaxSpeed = 4;
   
   walkAnimationSpeed = 0.95;
   runAnimationSpeed = 0.52;
   walkSpeed = 3;
   runSpeed = 8;
   
   animalType = "Peaceful";
};


