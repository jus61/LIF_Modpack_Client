//-----------------------------------------------------------------------------
// Torque Game Engine Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

datablock AnimalData(SowData : DefaultPlayerData)   // datablock PlayerData
{
   id = 118; //CM_REV
  
   animalTypeId = 758;
   footprintTexture = "art/Textures/AnimalFootprints/Boar_fs.png";
   footprintTextureLinearSize = 0.45;
   footprintGap = 0.7;
   footprintTrackWidth = 0.35;
   shapeFile = "art/models/3d/mobiles/wildanimals/sow.dts";
   soundFilesPrefix = "sow";

   behavior = "data/ai/cmAiSow.xml";

   boundingBox = "1.2 3 1.7"; //"1.2 6.2 3.5";

   // should be identical to navmesh walkable slope
   runSurfaceAngle = 50;

   // parameters from BASE:
   maxHP = 80.0;
   bodyRadius = 2.5;
   
   rawCorpseObjectTypeID = 918;
   skinnedCorpseObjectTypeID = 931;
   
   weaponData = "Sow_Tusk";
   weaponWeight = 10.0;
   
   powerHitStartingDistance = 2.2;
   powerHitDamagingDistance = 2.3;
   powerHitDamagingSector = 90;
   powerHitMinSpeed = 10;
   powerHitMaxSpeed = 15;
   
   fastHitStartingDistance = 2.1;
   fastHitDamagingDistance = 2.3;
   fastHitDamagingSector = 90;
   fastHitMinSpeed = 3;
   fastHitMaxSpeed = 5;
   
   walkAnimationSpeed = 1.76;
   runAnimationSpeed = 1.06;
   walkSpeed = 2;
   runSpeed = 7;
   
   animalType = "Peaceful";
};