//-----------------------------------------------------------------------------
// Torque Game Engine Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

datablock AnimalData(HareData : DefaultPlayerData)   // datablock PlayerData
{
   id = 141; //CM_REV

   animalTypeId = 763;
   footprintTexture = "art/Textures/AnimalFootprints/Hare_fs.png";
   footprintTextureLinearSize = 0.4;
   footprintGap = 0.4;
   footprintTrackWidth = 0.2;
   shapeFile = "art/models/3d/mobiles/wildanimals/hare.dts";
   soundFilesPrefix = "hare";

   behavior = "data/ai/cmAiHare.xml";
 
   boundingBox = "0.4 1 0.9";

   // should be identical to navmesh walkable slope
   runSurfaceAngle = 50;

   // parameters from BASE:

   maxHP = 15.0;
   bodyRadius = 2.5;
   
   rawCorpseObjectTypeID = 923;
   skinnedCorpseObjectTypeID = 936;
   
   weaponWeight = 10.0;
   
   walkAnimationSpeed = 1.05;
   runAnimationSpeed = 0.98;
   walkSpeed = 3;
   runSpeed = 9;
   
   animalType = "Passive";
};
