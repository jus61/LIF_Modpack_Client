//-----------------------------------------------------------------------------
// Torque Game Engine Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

datablock AnimalData(MuttonData : DefaultPlayerData)   // datablock PlayerData
{
   id = 145; //CM_REV
  
   animalTypeId = 759;
   footprintTexture = "art/Textures/AnimalFootprints/Boar_fs.png";
   footprintTextureLinearSize = 0.4;
   footprintGap = 0.7;
   footprintTrackWidth = 0.3;
   shapeFile = "art/models/3d/mobiles/wildanimals/mutton.dts";
   soundFilesPrefix = "mutton";

   behavior = "data/ai/cmAiMutton.xml";

   boundingBox = "1.2 2.4 2";

   // should be identical to navmesh walkable slope
   runSurfaceAngle = 50;

   // parameters from BASE:
   maxHP = 100.0;
   bodyRadius = 2.2;
   
   rawCorpseObjectTypeID = 919;
   skinnedCorpseObjectTypeID = 932;
   
   weaponData = "Mutton_Horns";
   weaponWeight = 10.0;
   
   powerHitStartingDistance = 1.5;
   powerHitDamagingDistance = 1.7;
   powerHitDamagingSector = 90;
   powerHitMinSpeed = 3;
   powerHitMaxSpeed = 8;
   
   fastHitStartingDistance = 1.4;
   fastHitDamagingDistance = 1.5;
   fastHitDamagingSector = 90;
   fastHitMinSpeed = 1;
   fastHitMaxSpeed = 3;
   
   walkAnimationSpeed = 2.17;
   runAnimationSpeed = 1.04;
   walkSpeed = 2;
   runSpeed = 7.5;
   
   animalType = "Peaceful";
};