

//----------------------------------------------------------------
// horse speed when animation time-scale is 1
$horseWalkSpeed = 3.8;
$horseTrotSpeed = 10;
$horseGallopSpeed = 16;
//----------------------------------------------------------------

//----------------------------------------------------------------
new DecalData(HorseFootprint)
{
   size = 0.4;
   material = CommonHorseFootprint;
   lifespan = 20000;
};
//----------------------------------------------------------------
datablock HorseData(HorseRiding)
{
   id = 350;
   objectTypeId = 773;

   category = "Vehicles";
   shapeFile = "art/models/3d/mobiles/domesticanimals/horses/horse/horse.dts";

   behavior = "data/ai/cmAiDomesticHorse.xml";

   emap = true;
   className = Steed;

   mountPose[0] = Riding_Stand;
   numMountPoints = 1;

   tireEmitter = TireEmitter; // All the tires use the same dust emitter

   runSurfaceAngle  = 45;
   maxStepHeight = 1.5;         // Maximim step height.

   // 3rd person camera settings
   cameraRoll = true;         // Roll the camera with the vehicle
   cameraMaxDist = 4.0;         // Far distance from vehicle
   cameraOffset = 0.5;        // Vertical offset from camera mount point
   cameraLag = 0.26;           // Velocity lag of camera
   cameraDecay = 1.25;        // Decay per sec. rate of velocity lag

   // Rigid Body
   mass = 700;
   massCenter = "0 -0.2 0";    // Center of mass for rigid body
   massBox = "0 0 0";         // Size of box used for moment of inertia,
                              // if zero it defaults to object bounding box
   drag = 0.6;                // Drag coefficient
   bodyFriction = 0.6;
   bodyRestitution = 0.4;
   minImpactSpeed = 5;        // Impacts over this invoke the script callback
   minFallImpactSpeed = 25.0; // Minimal impact speed for dealing damage to horse from falling
   softImpactSpeed = 5;       // Play SoftImpact Sound
   hardImpactSpeed = 15;      // Play HardImpact Sound
   integration = 8;           // Physics integration: TickSec/Rate
   collisionTol = 0.1;        // Collision distance tolerance
   contactTol = 0.1;          // Contact velocity tolerance

   // Energy
   maxEnergy = 100;
   jetForce = 3000;
   minJetEnergy = 30;
   jetEnergyDrain = 2;

   toPlayerKickUp = 4.0;
   toPlayerKickCoef = 2.0;

   // steps & sounds
   stepSoundsDir             = "art/sound/horse/";
   stepSoundsGeneralName     = "footstep_horse";
   stepSoundsStartingId      = "181";
   stepSoundsDescription     = "HorseAudio";

   decalData                 = HorseFootprint;
   footNodeName[0]           = "HorseLLegDigit11_bone";
   footNodeName[1]           = "HorseRLegDigit11_bone";
   footNodeName[2]           = "HorseLLegRearHoof_bone";
   footNodeName[3]           = "HorseRRearHoof_bone";

   // more sounds
   sounds[0]                 = "horse_move_walk_naked";
   sounds[1]                 = "horse_move_trot_naked";
   sounds[2]                 = "horse_move_gallop_naked";
   sounds[3]                 = "horse_idle";
   sounds[4]                 = "horse_move_gallop_naked";

   //explosion = VehicleExplosion;

   // LiF additions

   // Speeds given in TE/sec
   walk2trot   = 7;
   trot2walk   = 6;
   trot2gallop = 14;
   gallop2trot = 13;
   minSpeed = 4; // Minimal start speed, when start moving from rest, immediate speed is given
   maxSpeed = 20; // Max speed this horse type can achieve
   maxAcceleration = 8;
   runBackForce = 8;
   angleSpeed = 70; // Turning speed
   carryWeight = 30; // in kg
   HP = 150; // max hp
   HPRegen = 0.004; // HP regen speed, means HPRegen*32 HP/sec
   stamina = 100; // Max stamina points
   staminaRegen = 1.0; // points per second
   collisionStopSpeed = 5; // if moving with less than this, we are constantly stopping (on collision)
   collisionHindLegsSpeed = 7; // if moving with less than this (and greater than mStopSpeed) we do hindLegs on horse (on collision)
   DamageMltp = 1.0;

   skillTravelDistance = 200.0; // After how many travelled T.E. we should add skills to the player
   skillIdTraveller = 63; // Skill ID (def War Horse Handling)
   minimalLevel = 0;

   speedLevelCount = 11; // All levels
   speedLevels[0] = -3.3; // Backward speed / reverse gear
   speedLevels[1] = 0; // Standing speed, should always be zero! / neutral gear
   speedLevels[2] = 4.0; // This and followed are forward speeds per level / first gear
   speedLevels[3] = 6.0;
   speedLevels[4] = 7;
   speedLevels[5] = 10;
   speedLevels[6] = 13;
   speedLevels[7] = 14;
   speedLevels[8] = 16;
   speedLevels[9] = 18;
   speedLevels[10] = 20; // Top gear!

   visibleMeshes = "SkinnyHorse";
   allowedSkins = "base bw";
   corpseIDs = "1150 1149";

};
//----------------------------------------------------------------
datablock HorseData(HorseRidingFemale : HorseRiding)
{
   id = 351;
   objectTypeId = 1108;
   visibleMeshes = "SkinnyHorse";
   allowedSkins = "base bw";
   corpseIDs = "1150 1149";

   skillTravelDistance = 200.0; // After how many travelled T.E. we should add skills to the player
   skillIdTraveller = 63; // Skill ID (def War Horse Handling)
   minimalLevel = 0;

   walk2trot   = 7;
   trot2walk   = 6;
   trot2gallop = 14;
   gallop2trot = 13;
   minSpeed = 3; // Minimal start speed, when start moving from rest, immediate speed is given
   maxSpeed = 20; // Max speed this horse type can achieve
   maxAcceleration = 8;
   runBackForce = 8;
   angleSpeed = 70; // Turning speed
   carryWeight = 30; // in kg
   HP = 150; // max hp
   HPRegen = 0.004; // HP regen speed, means HPRegen*32 HP/sec
   stamina = 100; // Max stamina points
   staminaRegen = 1.0; // points per second
   collisionStopSpeed = 5; // if moving with less than this, we are constantly stopping (on collision)
   collisionHindLegsSpeed = 7;
   DamageMltp = 1.0;


};
//----------------------------------------------------------------
datablock HorseData(HorseSimpleWarhorse : HorseRiding)
{
   id = 352;
   objectTypeId = 774;
   visibleMeshes = "Horse";
   allowedSkins = "black brown";
   corpseIDs = "1145 1146";

   walk2trot   = 7;
   trot2walk   = 6;
   trot2gallop = 14;
   gallop2trot = 13;
   minSpeed = 2; // Minimal start speed, when start moving from rest, immediate speed is given
   maxSpeed = 20; // Max speed this horse type can achieve
   maxAcceleration = 10;
   runBackForce = 10;
   angleSpeed = 80; // Turning speed
   carryWeight = 40; // in kg
   HP = 220; // max hp
   HPRegen = 0.008; // HP regen speed, means HPRegen*32 HP/sec
   stamina = 150; // Max stamina points
   staminaRegen = 1.0; // points per second
   collisionStopSpeed = 5; // if moving with less than this, we are constantly stopping (on collision)
   collisionHindLegsSpeed = 7;
   DamageMltp = 1;

   mass = 700;

   skillTravelDistance = 200.0; // After how many travelled T.E. we should add skills to the player
   skillIdTraveller = 28; // Skill ID (def War Horse Handling)
   minimalLevel = 60;

   speedLevels[0] = -4.0; // Backward speed / reverse gear
   speedLevels[1] = 0; // Standing speed, should always be zero! / neutral gear
   speedLevels[2] = 2.0; // This and followed are forward speeds per level / first gear
   speedLevels[3] = 4.0;
   speedLevels[4] = 6;
   speedLevels[5] = 7;
   speedLevels[6] = 9;
   speedLevels[7] = 13;
   speedLevels[8] = 14;
   speedLevels[9] = 17;
   speedLevels[10] = 20;

};
//----------------------------------------------------------------
datablock HorseData(HorseHardyWarhorse : HorseRiding)
{
   id = 353;
   objectTypeId = 776;
   visibleMeshes = "Horse";
   allowedSkins = "base";
   corpseIDs = "1147";

   walk2trot   = 7;
   trot2walk   = 6;
   trot2gallop = 13;
   gallop2trot = 12;
   minSpeed = 2; // Minimal start speed, when start moving from rest, immediate speed is given
   maxSpeed = 19; // Max speed this horse type can achieve
   maxAcceleration = 9;
   runBackForce = 8;

   skillTravelDistance = 200.0; // After how many travelled T.E. we should add skills to the player
   skillIdTraveller = 29; // Skill ID (def War Horse Handling)
   minimalLevel = 60;

   speedLevels[0] = -5.0; // Backward speed / reverse gear
   speedLevels[1] = 0; // Standing speed, should always be zero! / neutral gear
   speedLevels[2] = 2.0; // This and followed are forward speeds per level / first gear
   speedLevels[3] = 4.0;
   speedLevels[4] = 6;
   speedLevels[5] = 9;
   speedLevels[6] = 11;
   speedLevels[7] = 13;
   speedLevels[8] = 15;
   speedLevels[9] = 17;
   speedLevels[10] = 19;

   angleSpeed = 80; // Turning speed
   carryWeight = 50; // in kg
   HP = 290; // max hp
   HPRegen = 0.01; // HP regen speed, means HPRegen*32 HP/sec
   stamina = 200; // Max stamina points
   staminaRegen = 1.0; // points per second
   collisionStopSpeed = 5; // if moving with less than this, we are constantly stopping (on collision)
   collisionHindLegsSpeed = 7;
   DamageMltp = 1.5;

   mass = 800;
};
//----------------------------------------------------------------
datablock HorseData(HorseSpiritedWarhorse : HorseRiding)
{
   id = 354;
   objectTypeId = 775;
   visibleMeshes = "SkinnyHorse";
   allowedSkins = "brown";
   corpseIDs = "1148";

   walk2trot   = 8;
   trot2walk   = 7;
   trot2gallop = 16;
   gallop2trot = 14;
   minSpeed = 4; // Minimal start speed, when start moving from rest, immediate speed is given
   maxSpeed = 25; // Max speed this horse type can achieve
   maxAcceleration = 12;
   runBackForce = 12;

   skillTravelDistance = 200.0; // After how many travelled T.E. we should add skills to the player
   skillIdTraveller = 29; // Skill ID (def War Horse Handling)
   minimalLevel = 60;

   speedLevels[0] = -5.5; // Backward speed / reverse gear
   speedLevels[1] = 0; // Standing speed, should always be zero! / neutral gear
   speedLevels[2] = 2.0; // This and followed are forward speeds per level / first gear
   speedLevels[3] = 4.5;
   speedLevels[4] = 7;
   speedLevels[5] = 10;
   speedLevels[6] = 12;
   speedLevels[7] = 15;
   speedLevels[8] = 18;
   speedLevels[9] = 20;
   speedLevels[10] = 25; // Top gear!

   angleSpeed = 90; // Turning speed
   carryWeight = 20; // in kg
   HP = 180; // max hp
   HPRegen = 0.005; // HP regen speed, means HPRegen*32 HP/sec
   stamina = 160; // Max stamina points
   staminaRegen = 1.0; // points per second
   collisionStopSpeed = 5; // if moving with less than this, we are constantly stopping (on collision)
   collisionHindLegsSpeed = 7;
   DamageMltp = 1.0;

    mass = 600;
};
datablock HorseData(HorseHeavyWarhorse : HorseRiding)
{
   id = 355;
   objectTypeId = 777;
   visibleMeshes = "HeavyHorse";
   allowedSkins = "base clr2";
   corpseIDs = "1141 1142";

   walk2trot   = 7;
   trot2walk   = 6;
   trot2gallop = 13;
   gallop2trot = 12;
   minSpeed = 2; // Minimal start speed, when start moving from rest, immediate speed is given
   maxSpeed = 16; // Max speed this horse type can achieve
   maxAcceleration = 12;
   runBackForce = 7;

   skillTravelDistance = 200.0; // After how many travelled T.E. we should add skills to the player
   skillIdTraveller = 30; // Skill ID (def War Horse Handling)
   minimalLevel = 60;
   
   speedLevels[0] = -4.5; // Backward speed / reverse gear
   speedLevels[1] = 0; // Standing speed, should always be zero! / neutral gear
   speedLevels[2] = 2.0; // This and followed are forward speeds per level / first gear
   speedLevels[3] = 4;
   speedLevels[4] = 6;
   speedLevels[5] = 8;
   speedLevels[6] = 10;
   speedLevels[7] = 12;
   speedLevels[8] = 14;
   speedLevels[9] = 15;
   speedLevels[10] = 16; // Top gear!
   angleSpeed = 55; // Turning speed
   carryWeight = 80; // in kg
   HP = 420; // max hp
   HPRegen = 0.012; // HP regen speed, means HPRegen*32 HP/sec
   stamina = 200; // Max stamina points
   staminaRegen = 1.0; // points per second
   collisionStopSpeed = 5; // if moving with less than this, we are constantly stopping (on collision)
   collisionHindLegsSpeed = 7;
   DamageMltp = 2;

   mass = 1000;

   sounds[0]                 = "horse_move_walk_armoured";
   sounds[1]                 = "horse_move_trot_armoured";
   sounds[2]                 = "horse_move_gallop_armoured";
   sounds[3]                 = "horse_idle";
   sounds[4]                 = "horse_move_gallop_armoured_tremble";
};
datablock HorseData(HorseRoyalWarhorse : HorseRiding)
{
   id = 361;
   objectTypeId = 1139;
   visibleMeshes = "HeavyHorse";
   allowedSkins = "clr3";
   corpseIDs = "1143";
   
   walk2trot   = 7;
   trot2walk   = 6;
   trot2gallop = 13;
   gallop2trot = 12;
   minSpeed = 2; // Minimal start speed, when start moving from rest, immediate speed is given
   maxSpeed = 16; // Max speed this horse type can achieve
   maxAcceleration = 12;
   runBackForce = 7;

   skillTravelDistance = 200.0; // After how many travelled T.E. we should add skills to the player
   skillIdTraveller = 30; // Skill ID (def War Horse Handling)
   minimalLevel = 100;
   
   speedLevels[0] = -4.5; // Backward speed / reverse gear
   speedLevels[1] = 0; // Standing speed, should always be zero! / neutral gear
   speedLevels[2] = 2.0; // This and followed are forward speeds per level / first gear
   speedLevels[3] = 4;
   speedLevels[4] = 6;
   speedLevels[5] = 8;
   speedLevels[6] = 10;
   speedLevels[7] = 12;
   speedLevels[8] = 14;
   speedLevels[9] = 15;
   speedLevels[10] = 16; // Top gear!
   angleSpeed = 60; // Turning speed
   carryWeight = 80; // in kg
   HP = 450; // max hp
   HPRegen = 0.012; // HP regen speed, means HPRegen*32 HP/sec
   stamina = 200; // Max stamina points
   staminaRegen = 1.0; // points per second
   collisionStopSpeed = 5; // if moving with less than this, we are constantly stopping (on collision)
   collisionHindLegsSpeed = 8;
   DamageMltp = 2;

   mass = 1000;

   sounds[0]                 = "horse_move_walk_armoured";
   sounds[1]                 = "horse_move_trot_armoured";
   sounds[2]                 = "horse_move_gallop_armoured";
   sounds[3]                 = "horse_idle";
   sounds[4]                 = "horse_move_gallop_armoured_tremble";
};

datablock HorseData(RidingMoose)
{
   id = 620;
   objectTypeId = 1662;

   category = "Vehicles";
   shapeFile = "art/models/3d/mobiles/domesticanimals/horsemoose.dts";

   behavior = "data/ai/cmAiDomesticHorse.xml";

   emap = true;
   className = Steed;

   mountPose[0] = Riding_Stand;
   numMountPoints = 1;

   tireEmitter = TireEmitter; // All the tires use the same dust emitter

   runSurfaceAngle  = 45;
   maxStepHeight = 1.5;         // Maximim step height.

   // 3rd person camera settings
   cameraRoll = true;         // Roll the camera with the vehicle
   cameraMaxDist = 4.0;         // Far distance from vehicle
   cameraOffset = 0.5;        // Vertical offset from camera mount point
   cameraLag = 0.26;           // Velocity lag of camera
   cameraDecay = 1.25;        // Decay per sec. rate of velocity lag

   // Rigid Body
   mass = 700;
   massCenter = "0 -0.2 0";    // Center of mass for rigid body
   massBox = "0 0 0";         // Size of box used for moment of inertia,
                              // if zero it defaults to object bounding box
   drag = 0.6;                // Drag coefficient
   bodyFriction = 0.6;
   bodyRestitution = 0.4;
   minImpactSpeed = 5;        // Impacts over this invoke the script callback
   minFallImpactSpeed = 25.0; // Minimal impact speed for dealing damage to horse from falling
   softImpactSpeed = 5;       // Play SoftImpact Sound
   hardImpactSpeed = 15;      // Play HardImpact Sound
   integration = 8;           // Physics integration: TickSec/Rate
   collisionTol = 0.1;        // Collision distance tolerance
   contactTol = 0.1;          // Contact velocity tolerance

   // Energy
   maxEnergy = 100;
   jetForce = 3000;
   minJetEnergy = 30;
   jetEnergyDrain = 2;

   toPlayerKickUp = 5.0;
   toPlayerKickCoef = 3.0;

   // steps & sounds
   stepSoundsDir             = "art/sound/horse/";
   stepSoundsGeneralName     = "footstep_horse";
   stepSoundsStartingId      = "181";
   stepSoundsDescription     = "HorseAudio";

   decalData                 = HorseFootprint;
   footNodeName[0]           = "Moose_L_LegDigit11";
   footNodeName[1]           = "Moose_R_LegDigit11";
   footNodeName[2]           = "Moose_L_RearHoof";
   footNodeName[3]           = "Moose_R_RearHoof";

   // more sounds
   sounds[0]                 = "moose_walk";
   sounds[1]                 = "horse_move_trot_naked";
   sounds[2]                 = "horse_move_gallop_naked";
   sounds[3]                 = "moose_idle";
   sounds[4]                 = "horse_move_gallop_naked";

   //explosion = VehicleExplosion;

   // LiF additions

   // Speeds given in TE/sec
   walk2trot   = 7;
   trot2walk   = 6;
   trot2gallop = 14;
   gallop2trot = 13;
   minSpeed = 4; // Minimal start speed, when start moving from rest, immediate speed is given
   maxSpeed = 20; // Max speed this horse type can achieve
   maxAcceleration = 8;
   runBackForce = 8;
   angleSpeed = 70; // Turning speed
   carryWeight = 30; // in kg
   HP = 150; // max hp
   HPRegen = 0.004; // HP regen speed, means HPRegen*32 HP/sec
   stamina = 100; // Max stamina points
   staminaRegen = 1.0; // points per second
   collisionStopSpeed = 5; // if moving with less than this, we are constantly stopping (on collision)
   collisionHindLegsSpeed = 7; // if moving with less than this (and greater than mStopSpeed) we do hindLegs on horse (on collision)
   DamageMltp = 1.0;

   skillTravelDistance = 200.0; // After how many travelled T.E. we should add skills to the player
   skillIdTraveller = 63; // Skill ID (def War Horse Handling)
   minimalLevel = 0;

   speedLevelCount = 11; // All levels
   speedLevels[0] = -3.3; // Backward speed / reverse gear
   speedLevels[1] = 0; // Standing speed, should always be zero! / neutral gear
   speedLevels[2] = 4.0; // This and followed are forward speeds per level / first gear
   speedLevels[3] = 6.0;
   speedLevels[4] = 7;
   speedLevels[5] = 10;
   speedLevels[6] = 13;
   speedLevels[7] = 14;
   speedLevels[8] = 16;
   speedLevels[9] = 18;
   speedLevels[10] = 20; // Top gear!

   visibleMeshes = "moose";
   allowedSkins = "base";
   corpseIDs = "916";

};

datablock HorseData(HorseCourierHorse : HorseRiding)
{
   id = 362;
   objectTypeId = 1684;
   visibleMeshes = "SkinnyHorse";
   allowedSkins = "base bw";
   corpseIDs = "1150 1149";

   walk2trot   = 7;
   trot2walk   = 6;
   trot2gallop = 13;
   gallop2trot = 12;
   minSpeed = 2; // Minimal start speed, when start moving from rest, immediate speed is given
   maxSpeed = 19; // Max speed this horse type can achieve
   maxAcceleration = 9;
   runBackForce = 8;

   skillTravelDistance = 200.0; // After how many travelled T.E. we should add skills to the player
   skillIdTraveller = 63; // Skill ID (def War Horse Handling)
   minimalLevel = 0;

   speedLevels[0] = -5.0; // Backward speed / reverse gear
   speedLevels[1] = 0; // Standing speed, should always be zero! / neutral gear
   speedLevels[2] = 2.0; // This and followed are forward speeds per level / first gear
   speedLevels[3] = 4.0;
   speedLevels[4] = 6;
   speedLevels[5] = 9;
   speedLevels[6] = 11;
   speedLevels[7] = 13;
   speedLevels[8] = 15;
   speedLevels[9] = 17;
   speedLevels[10] = 19;

   angleSpeed = 80; // Turning speed
   carryWeight = 50; // in kg
   HP = 150; // max hp
   HPRegen = 0.01; // HP regen speed, means HPRegen*32 HP/sec
   stamina = 100; // Max stamina points
   staminaRegen = 1.15; // points per second
   collisionStopSpeed = 5; // if moving with less than this, we are constantly stopping (on collision)
   collisionHindLegsSpeed = 7;
   DamageMltp = 0.5;

   mass = 800;
};