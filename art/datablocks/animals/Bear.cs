//-----------------------------------------------------------------------------
// Torque Game Engine Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

datablock AnimalData(BearData : DefaultPlayerData)   // datablock PlayerData
{
   id = 116; //CM_REV

   animalTypeId = 752;
   footprintTexture = "art/Textures/AnimalFootprints/Bear_fs.png";
   footprintTextureLinearSize = 0.7;
   footprintGap = 0.8;
   footprintTrackWidth = 0.5;
   shapeFile = "art/models/3d/mobiles/wildanimals/bear.dts";
   soundFilesPrefix = "bear";

   behavior = "data/ai/cmAiBear.xml";

   boundingBox = "2.5 6.2 3.7"; //"1.2 6.2 3.5";    7
   
   // should be identical to navmesh walkable slope
   runSurfaceAngle = 50;

   // parameters from BASE:
   maxHP = 450.0;
   bodyRadius = 4.0;
   
   rawCorpseObjectTypeID = 911;
   skinnedCorpseObjectTypeID = 924;
   
   weaponData = "Bear_Paw";
   weaponWeight = 10.0;
   
   powerHitStartingDistance = 1.2;
   powerHitDamagingDistance = 1.3;
   powerHitDamagingSector = 90;
   powerHitMinSpeed = 25;
   powerHitMaxSpeed = 40;
   
   fastHitStartingDistance = 0.7;
   fastHitDamagingDistance = 1.0;
   fastHitDamagingSector = 90;
   fastHitMinSpeed = 10;
   fastHitMaxSpeed = 15;
   
   walkAnimationSpeed = 0.87;
   runAnimationSpeed = 0.75;
   walkSpeed = 2;
   runSpeed = 8;
   
   animalType = "Predator";
};
