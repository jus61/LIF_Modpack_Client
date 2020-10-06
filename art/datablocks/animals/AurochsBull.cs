//-----------------------------------------------------------------------------
// Torque Game Engine Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

datablock AnimalData(AurochsBullData : DefaultPlayerData)   // datablock PlayerData
{
   id = 67; //CM_REV

   animalTypeId = 760;
   footprintTexture = "art/Textures/AnimalFootprints/Bull_fs.png";
   footprintTextureLinearSize = 0.4;
   footprintGap = 0.7;
   footprintTrackWidth = 0.4;
   shapeFile = "art/models/3d/mobiles/wildanimals/aurochsbull.dts";
   soundFilesPrefix = "aurochsbull";

   behavior = "data/ai/cmAiAurochsBull.xml";

   boundingBox = "2.5 6 3.5"; //"1.2 6.2 3.5";

   // should be identical to navmesh walkable slope
   runSurfaceAngle = 50;

   // parameters from BASE:
   maxHP = 250.0;
   bodyRadius = 4;
   
   rawCorpseObjectTypeID = 920;
   skinnedCorpseObjectTypeID = 933;
   
   weaponData = "Bull_Horns";
   weaponWeight = 10.0;
   
   powerHitStartingDistance = 1.7;
   powerHitDamagingDistance = 1.9;
   powerHitDamagingSector = 90;
   powerHitMinSpeed = 2;
   powerHitMaxSpeed = 8;
   
   fastHitStartingDistance = 1.7;
   fastHitDamagingDistance = 1.8;
   fastHitDamagingSector = 90;
   fastHitMinSpeed = 1;
   fastHitMaxSpeed = 3;
   
   walkAnimationSpeed = 1.08;
   runAnimationSpeed = 0.55;
   walkSpeed = 3;
   runSpeed = 7;
   
   animalType = "Peaceful";
};