//-----------------------------------------------------------------------------
// Torque Game Engine Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

datablock AnimalData(MooseData : DefaultPlayerData)   // datablock PlayerData
{
   id = 144; //CM_REV

   animalTypeId = 756;
   footprintTexture = "art/Textures/AnimalFootprints/Moose_fs.png";
   footprintTextureLinearSize = 0.5;
   footprintGap = 1;
   footprintTrackWidth = 0.5;
   shapeFile = "art/models/3d/mobiles/wildanimals/moose.dts";
   soundFilesPrefix = "moose";

   behavior = "data/ai/cmAiMoose.xml";

   boundingBox = "2.5 5 3.5"; //"1.2 6.2 3.5";

   // should be identical to navmesh walkable slope
   runSurfaceAngle = 50;

   // parameters from BASE:
   maxHP = 300.0;
   bodyRadius = 4.2;
   
   rawCorpseObjectTypeID = 916;
   skinnedCorpseObjectTypeID = 929;
   
   weaponData = "Moose_Hoof";
   weaponWeight = 10.0;
   
   powerHitStartingDistance = 1.7;
   powerHitDamagingDistance = 1.8;
   powerHitDamagingSector = 90;
   powerHitMinSpeed = 20;
   powerHitMaxSpeed = 30;
   
   fastHitStartingDistance = 1.7;
   fastHitDamagingDistance = 1.8;
   fastHitDamagingSector = 90;
   fastHitMinSpeed = 10;
   fastHitMaxSpeed = 15;
   
   walkAnimationSpeed = 0.95;
   runAnimationSpeed = 0.52;
   walkSpeed = 2;
   runSpeed = 7.5;
   
   animalType = "Peaceful";
};
