$Horse::CriticalAngleHarnessed = 25.0;

datablock HorseData(HarnessedStallion : HorseRiding)
{
   id = 695;
   objectTypeId = 1438;
   shapeFile = "art/models/3d/mobiles/domesticanimals/horses/harnessedhorse/harnessed_horse_skinny_horse.dts";

   walk2trot   = 6;
   trot2walk   = 5;
   trot2gallop = 20; // Out of reach by design
   gallop2trot = 20;

   minSpeed = 1;     // Minimal start speed, when start moving from rest, immediate speed is given
   maxSpeed = 7;     // Max speed this horse type can achieve
   maxAcceleration = 2;
   runBackForce = 3;

   speedLevels[0]  = -2; // Backward speed
   speedLevels[1]  =  0; // Standing speed, should always be zero!
   speedLevels[2]  =  1; // This and followed are forward speeds per level
   speedLevels[3]  =  1;
   speedLevels[4]  =  1;
   speedLevels[5]  =  2;
   speedLevels[6]  =  2;
   speedLevels[7]  =  3;
   speedLevels[8]  =  4;
   speedLevels[9]  =  5;
   speedLevels[10] =  6;
};

datablock HorseData(HarnessedHorse : HorseRiding)
{
   id = 696;
   objectTypeId = 1439;
   shapeFile = "art/models/3d/mobiles/domesticanimals/horses/harnessedhorse/harnessed_horse_skinny_horse.dts";

   walk2trot   = 6;
   trot2walk   = 5;
   trot2gallop = 20;
   gallop2trot = 20;

   minSpeed = 1;
   maxSpeed = 7;
   maxAcceleration = 2;
   runBackForce = 3;

   speedLevels[0]  = -2;
   speedLevels[1]  =  0;
   speedLevels[2]  =  1;
   speedLevels[3]  =  1;
   speedLevels[4]  =  1;
   speedLevels[5]  =  2;
   speedLevels[6]  =  2;
   speedLevels[7]  =  3;
   speedLevels[8]  =  4;
   speedLevels[9]  =  5;
   speedLevels[10] =  6;
};

datablock HorseData(HarnessedWarhorse : HorseSimpleWarhorse)
{
   id = 697;
   objectTypeId = 1472;
   shapeFile = "art/models/3d/mobiles/domesticanimals/horses/harnessedhorse/harnessed_horse_skinny_horse.dts";

   walk2trot   = 7;
   trot2walk   = 6;
   trot2gallop = 20;
   gallop2trot = 20;

   minSpeed = 2;
   maxSpeed = 7;
   maxAcceleration = 2;
   runBackForce = 3;

   speedLevels[0]  = -2;
   speedLevels[1]  =  0;
   speedLevels[2]  =  2;
   speedLevels[3]  =  2;
   speedLevels[4]  =  2;
   speedLevels[5]  =  3;
   speedLevels[6]  =  3;
   speedLevels[7]  =  4;
   speedLevels[8]  =  5;
   speedLevels[9]  =  6;
   speedLevels[10] =  7;
};

datablock HorseData(HarnessedSpiritedWarhorse : HorseSpiritedWarhorse)
{
   id = 698;
   objectTypeId = 1473;
   shapeFile = "art/models/3d/mobiles/domesticanimals/horses/harnessedhorse/harnessed_horse_skinny_horse.dts";

   walk2trot   = 7;
   trot2walk   = 6;
   trot2gallop = 20;
   gallop2trot = 20;

   minSpeed = 1;
   maxSpeed = 7;
   maxAcceleration = 2;
   runBackForce = 3;

   speedLevels[0]  = -2;
   speedLevels[1]  =  0;
   speedLevels[2]  =  1;
   speedLevels[3]  =  1;
   speedLevels[4]  =  1;
   speedLevels[5]  =  2;
   speedLevels[6]  =  2;
   speedLevels[7]  =  3;
   speedLevels[8]  =  4;
   speedLevels[9]  =  5;
   speedLevels[10] =  6;
};

datablock HorseData(HarnessedHardyWarhorse : HorseHardyWarhorse)
{
   id = 699;
   objectTypeId = 1474;
   shapeFile = "art/models/3d/mobiles/domesticanimals/horses/harnessedhorse/harnessed_horse_skinny_horse.dts";

   walk2trot   = 7;
   trot2walk   = 6;
   trot2gallop = 20;
   gallop2trot = 20;

   minSpeed = 2;
   maxSpeed = 7;
   maxAcceleration = 2;
   runBackForce = 3;

   speedLevels[0]  = -2;
   speedLevels[1]  =  0;
   speedLevels[2]  =  2;
   speedLevels[3]  =  2;
   speedLevels[4]  =  2;
   speedLevels[5]  =  3;
   speedLevels[6]  =  3;
   speedLevels[7]  =  4;
   speedLevels[8]  =  5;
   speedLevels[9]  =  6;
   speedLevels[10] =  7;
};

datablock HorseData(HarnessedRidingMoose : RidingMoose)
{
   id = 621;
   objectTypeId = 1664;
   shapeFile = "art/models/3d/mobiles/domesticanimals/horsemoose.dts";

   walk2trot   = 7;
   trot2walk   = 6;
   trot2gallop = 20;
   gallop2trot = 20;

   minSpeed = 2;
   maxSpeed = 7;
   maxAcceleration = 2;
   runBackForce = 3;

   speedLevels[0]  = -2;
   speedLevels[1]  =  0;
   speedLevels[2]  =  2;
   speedLevels[3]  =  2;
   speedLevels[4]  =  2;
   speedLevels[5]  =  3;
   speedLevels[6]  =  3;
   speedLevels[7]  =  4;
   speedLevels[8]  =  5;
   speedLevels[9]  =  6;
   speedLevels[10] =  7;
};

datablock HorseData(HarnessedCourierHorse : HorseRiding)
{
   id = 365;
   objectTypeId = 1686;
   shapeFile = "art/models/3d/mobiles/domesticanimals/horses/harnessedhorse/harnessed_horse_skinny_horse.dts";

   walk2trot   = 6;
   trot2walk   = 5;
   trot2gallop = 20;
   gallop2trot = 20;

   minSpeed = 1;
   maxSpeed = 8;
   maxAcceleration = 2;
   runBackForce = 3;

   speedLevels[0]  = -2;
   speedLevels[1]  =  0;
   speedLevels[2]  =  1;
   speedLevels[3]  =  1;
   speedLevels[4]  =  1;
   speedLevels[5]  =  2;
   speedLevels[6]  =  2;
   speedLevels[7]  =  3;
   speedLevels[8]  =  4;
   speedLevels[9]  =  5;
   speedLevels[10] =  6;
};