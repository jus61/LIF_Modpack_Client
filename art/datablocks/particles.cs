//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------



datablock FireEmitterData(TestFireEmitter)
{
	id = 593;
	
	textureName = "core/art/torch.dds";
	chainsize = 12;
	minChainLength = 0.1;
	maxChainLength = 0.2;
	msPerFrame = 40;
	width = 0.6;
	constantAngleDiviation = 0.2;
	animationRows = 8;
	animationCols = 8;
	distortionMinForce = 1;
	distortionMaxForce = 16;
	distortionMultiplier = 5;
	distortionRotSpeed = 3.1415;
};

datablock AnimatedBillboardData(TestAnimatedBillboard)
{
	id = 594;
	
	textureName = "core/art/torchTop.dds";
	msPerFrame = 40;
	width = 0.6;
	animationRows = 8;
	animationCols = 8;
	
	minFadeAngle = 0.2;
	fadeAngle = 0.5;
	keepOrientation = true;
	orientVector = "0 0 1";
	
	offset = 0.1;
};






datablock ParticleEmitterNodeData(LiFEmitterNodeData)
{
id = 69; //CM_REV
   timeMultiple = 1;
};


datablock ParticleData(SmokeParticleLiF2Z)
{
   id = 85; //CM_REV
   dragCoefficient = 0;
   windCoefficient = 0.2;
   gravityCoefficient = "-0.0512821";
   inheritedVelFactor = "0.199609";
   constantAcceleration = "0";
   lifetimeMS = "3000";
   lifetimeVarianceMS = "1500";
   spinSpeed = "0";
   spinRandomMin = "-100";
   spinRandomMax = "100";
   useInvAlpha = "1";
   textureName = "art/shapes/particles/smoke_01.png";
   colors[0] = "0.0944882 0.0944882 0.0944882 0.795276";
   colors[1] = "0.692913 0.692913 0.692913 0.598425";
   colors[2] = "0.897638 0.897638 0.897638 0.0944882";
   colors[3] = "1 1 1 1";
   sizes[0] = "0.5";
   sizes[1] = "1";
   sizes[2] = "2";
   sizes[3] = "1";
   times[0] = "0";
   times[1] = "0.6";
   times[2] = "1";
   times[3] = "2";
   animTexName = "art/shapes/particles/smoke_01.png";
   originalName = "SmokeParticleLiF2Z";
};

//-------------------------------------

datablock ParticleData(FireParticleLiF1Z)
{
   id = 63; //CM_REV
   textureName          = "art/shapes/particles/flame_6.png";
   dragCoefficient      = "0";
   gravityCoefficient   = "-0.18";   // rises slowly
   inheritedVelFactor   = "0";
   lifetimeMS           = "3000";
   lifetimeVarianceMS   = "1000";
   useInvAlpha          = false;
   spinRandomMin        = "-200";
   spinRandomMax        = "200";
   spinSpeed            = "0.1";

   colors[0]     = "1 0 0.160784 0.461";
   colors[1]     = "1 0.787402 0 0.241";
   colors[2]     = "0 0 0 0.0944882";

   sizes[0]      = "0.5";
   sizes[1]      = "3";
   sizes[2]      = "0.4";

   times[0]      = "0.08";
   times[1]      = "0.4";
   times[2]      = "0.8";
   animTexName = "art/shapes/particles/flame_6.png";
   constantAcceleration = "-3";
   sizes[3] = "0";
   times[3] = "1";
};

datablock ParticleData(FireParticleLiF2Z)
{
   id = 77; //CM_REV
   textureName          = "art/shapes/particles/flame_6.png";
   dragCoefficient      = 0.0;
   gravityCoefficient   = "-0.1";   // rises slowly
   inheritedVelFactor   = "0";
   lifetimeMS           = "3000";
   lifetimeVarianceMS   = "500";
   useInvAlpha          = false;
   spinRandomMin        = "-100";
   spinRandomMax        = "100";
   spinSpeed            = "0.05";

   colors[0]     = "0.466667 0.0431373 0.0509804 0.793";
   colors[1]     = "1 0.882353 0 0.365";
   colors[2]     = "0.858268 0.661417 0.440945 0.19685";

   sizes[0]      = "0.05";
   sizes[1]      = "0.4";
   sizes[2]      = "0.1";

   times[0]      = "0";
   times[1]      = "0.166667";
   times[2]      = "0.291667";
   animTexName = "art/shapes/particles/flame_6.png";
   constantAcceleration = "-3";
   sizes[3] = "0";
   times[3] = "0.458333";
   colors[3] = "1 1 1 0";
};

// Blood Particles

datablock ParticleData(BloodParticleLiF1Z)
{
   id = 91; //CM_REV
   textureName          = "art/shapes/particles/blood_1z.dds";
   dragCoefficient      = "0";
   gravityCoefficient   = "0";   // rises slowly
   inheritedVelFactor   = "0";
   lifetimeMS           = "1000";
   lifetimeVarianceMS   = "0";
   useInvAlpha          = false;
   spinRandomMin        = "0";
   spinRandomMax        = "1";
   spinSpeed            = "0";

   colors[0]     = "0.992126 0.992126 0.992126 1";
   colors[1]     = "0.992126 0.992126 0.992126 1";
   colors[2]     = "0.992126 0.992126 0.992126 1";

   sizes[0]      = "1.99902";
   sizes[1]      = "1.99902";
   sizes[2]      = "1.99902";

   times[0]      = "0";
   times[1]      = "0.294118";
   times[2]      = "0.494118";
   animTexName = "art/shapes/particles/blood_1z.dds";
   constantAcceleration = "0";
   sizes[3] = "1.99902";
   times[3] = "0.894118";
   colors[3] = "1 1 1 1";
   animTexTiling = "8 2";
   animTexFrames = "0-15";
   animateTexture = "1";
   framesPerSec = "16";
};

datablock ParticleData(BloodParticleLiF2Z)
{
   id = 92; //CM_REV
   textureName          = "art/shapes/particles/blood_2z.dds";
   dragCoefficient      = "0";
   gravityCoefficient   = "0";   // rises slowly
   inheritedVelFactor   = "0";
   lifetimeMS           = "1000";
   lifetimeVarianceMS   = "0";
   useInvAlpha          = false;
   spinRandomMin        = "0";
   spinRandomMax        = "1";
   spinSpeed            = "0";

   colors[0]     = "0.992126 0.992126 0.992126 1";
   colors[1]     = "0.992126 0.992126 0.992126 1";
   colors[2]     = "0.992126 0.992126 0.992126 1";

   sizes[0]      = "1.99902";
   sizes[1]      = "1.99902";
   sizes[2]      = "1.99902";

   times[0]      = "0";
   times[1]      = "0.294118";
   times[2]      = "0.494118";
   animTexName = "art/shapes/particles/blood_2z.dds";
   constantAcceleration = "0";
   sizes[3] = "1.99902";
   times[3] = "0.894118";
   colors[3] = "1 1 1 1";
   animTexTiling = "8 2";
   animTexFrames = "0-15";
   animateTexture = "1";
   framesPerSec = "16";
};


datablock ParticleData(BloodParticleLiF3Z)
{
   id = 93; //CM_REV
   textureName          = "art/shapes/particles/blood_3z.dds";
   dragCoefficient      = "0";
   gravityCoefficient   = "0";   // rises slowly
   inheritedVelFactor   = "0";
   lifetimeMS           = "1000";
   lifetimeVarianceMS   = "0";
   useInvAlpha          = false;
   spinRandomMin        = "-1";
   spinRandomMax        = "0";
   spinSpeed            = "0";

   colors[0]     = "0.992126 0.992126 0.992126 1";
   colors[1]     = "0.992126 0.992126 0.992126 1";
   colors[2]     = "0.992126 0.992126 0.992126 1";

   sizes[0]      = "1.98682";
   sizes[1]      = "1.98987";
   sizes[2]      = "1.99292";

   times[0]      = "0";
   times[1]      = "0.294118";
   times[2]      = "0.6";
   animTexName = "art/shapes/particles/blood_3z.dds";
   constantAcceleration = "0";
   sizes[3] = "1.99597";
   times[3] = "0.894118";
   colors[3] = "0.992126 0.992126 0.992126 1";
   framesPerSec = "16";
   animTexTiling = "8 2";
   animTexFrames = "0-15";
   animateTexture = "1";
};

datablock ParticleData(BloodParticleLiF4Z)
{
   id = 94; //CM_REV
   textureName          = "art/shapes/particles/blood_bones_4z.dds";
   dragCoefficient      = "0";
   gravityCoefficient   = "0";   // rises slowly
   inheritedVelFactor   = "0";
   lifetimeMS           = "1000";
   lifetimeVarianceMS   = "0";
   useInvAlpha          = false;
   spinRandomMin        = "0";
   spinRandomMax        = "0";
   spinSpeed            = "0";

   colors[0]     = "0.992157 0.992157 0.992157 1";
   colors[1]     = "0.996078 0.992157 0.992157 1";
   colors[2]     = "0.996078 0.996078 0.996078 1";

   sizes[0]      = "1.94409";
   sizes[1]      = "1.94714";
   sizes[2]      = "1.95019";

   times[0]      = 0.0;
   times[1]      = "0.298039";
   times[2]      = "0.6";
   animTexName = "art/shapes/particles/blood_bones_4z.dds";
   constantAcceleration = "0";
   sizes[3] = "1.95324";
   times[3] = "0.898039";
   colors[3] = "0.996078 0.996078 0.996078 1";
   animTexTiling = "8 2";
   animTexFrames = "0-15";
   animateTexture = "1";
   framesPerSec = "16";
};

datablock ParticleData(BloodParticleLiF5Z)
{
   id = 95; //CM_REV
   textureName          = "art/shapes/particles/flame_01.png";
   dragCoefficient      = 0.0;
   gravityCoefficient   = "-1";   // rises slowly
   inheritedVelFactor   = "1.458";
   lifetimeMS           = "1689";
   lifetimeVarianceMS   = "187";
   useInvAlpha          = false;
   spinRandomMin        = "0";
   spinRandomMax        = "1";
   spinSpeed            = "0.583";

   colors[0]     = "0.466667 0 1 0.1";
   colors[1]     = "1 0.792157 0 0.627";
   colors[2]     = "0.0 0.0 0.0 0.1";

   sizes[0]      = "3.5";
   sizes[1]      = "2";
   sizes[2]      = "0.1";

   times[0]      = 0.0;
   times[1]      = "0.375";
   times[2]      = "0.416667";
   animTexName = "art/shapes/particles/flame_01.png";
   constantAcceleration = "-5.42";
   sizes[3] = "0.05";
   times[3] = "0.791667";
};

datablock ParticleData(BloodParticleLiF6Z)
{
   id = 96; //CM_REV
   textureName          = "art/shapes/particles/flame_01.png";
   dragCoefficient      = 0.0;
   gravityCoefficient   = "-1";   // rises slowly
   inheritedVelFactor   = "1.458";
   lifetimeMS           = "1689";
   lifetimeVarianceMS   = "187";
   useInvAlpha          = false;
   spinRandomMin        = "0";
   spinRandomMax        = "1";
   spinSpeed            = "0.583";

   colors[0]     = "0.466667 0 1 0.1";
   colors[1]     = "1 0.792157 0 0.627";
   colors[2]     = "0.0 0.0 0.0 0.1";

   sizes[0]      = "3.5";
   sizes[1]      = "2";
   sizes[2]      = "0.1";

   times[0]      = 0.0;
   times[1]      = "0.375";
   times[2]      = "0.416667";
   animTexName = "art/shapes/particles/flame_01.png";
   constantAcceleration = "-5.42";
   sizes[3] = "0.05";
   times[3] = "0.791667";
};

datablock ParticleData(BloodParticleLiF7Z)
{
   id = 97; //CM_REV
   textureName          = "art/shapes/particles/flame_01.png";
   dragCoefficient      = 0.0;
   gravityCoefficient   = "-1";   // rises slowly
   inheritedVelFactor   = "1.458";
   lifetimeMS           = "1689";
   lifetimeVarianceMS   = "187";
   useInvAlpha          = false;
   spinRandomMin        = "0";
   spinRandomMax        = "1";
   spinSpeed            = "0.583";

   colors[0]     = "0.466667 0 1 0.1";
   colors[1]     = "1 0.792157 0 0.627";
   colors[2]     = "0.0 0.0 0.0 0.1";

   sizes[0]      = "3.5";
   sizes[1]      = "2";
   sizes[2]      = "0.1";

   times[0]      = 0.0;
   times[1]      = "0.375";
   times[2]      = "0.416667";
   animTexName = "art/shapes/particles/flame_01.png";
   constantAcceleration = "-5.42";
   sizes[3] = "0.05";
   times[3] = "0.791667";
};

datablock ParticleData(BloodParticleLiF8Z)
{
   id = 98; //CM_REV
   textureName          = "art/shapes/particles/flame_01.png";
   dragCoefficient      = 0.0;
   gravityCoefficient   = "-1";   // rises slowly
   inheritedVelFactor   = "1.458";
   lifetimeMS           = "1689";
   lifetimeVarianceMS   = "187";
   useInvAlpha          = false;
   spinRandomMin        = "0";
   spinRandomMax        = "1";
   spinSpeed            = "0.583";

   colors[0]     = "0.466667 0 1 0.1";
   colors[1]     = "1 0.792157 0 0.627";
   colors[2]     = "0.0 0.0 0.0 0.1";

   sizes[0]      = "3.5";
   sizes[1]      = "2";
   sizes[2]      = "0.1";

   times[0]      = 0.0;
   times[1]      = "0.375";
   times[2]      = "0.416667";
   animTexName = "art/shapes/particles/flame_01.png";
   constantAcceleration = "-5.42";
   sizes[3] = "0.05";
   times[3] = "0.791667";
};

datablock ParticleData(BloodParticleLiF9Z)
{
   id = 99; //CM_REV
   textureName          = "art/shapes/particles/flame_01.png";
   dragCoefficient      = 0.0;
   gravityCoefficient   = "-1";   // rises slowly
   inheritedVelFactor   = "1.458";
   lifetimeMS           = "1689";
   lifetimeVarianceMS   = "187";
   useInvAlpha          = false;
   spinRandomMin        = "0";
   spinRandomMax        = "1";
   spinSpeed            = "0.583";

   colors[0]     = "0.466667 0 1 0.1";
   colors[1]     = "1 0.792157 0 0.627";
   colors[2]     = "0.0 0.0 0.0 0.1";

   sizes[0]      = "3.5";
   sizes[1]      = "2";
   sizes[2]      = "0.1";

   times[0]      = 0.0;
   times[1]      = "0.375";
   times[2]      = "0.416667";
   animTexName = "art/shapes/particles/flame_01.png";
   constantAcceleration = "-5.42";
   sizes[3] = "0.05";
   times[3] = "0.791667";
};

datablock ParticleData(BloodParticleLiF10Z)
{
   id = 100; //CM_REV
   textureName          = "art/shapes/particles/flame_01.png";
   dragCoefficient      = 0.0;
   gravityCoefficient   = "-1";   // rises slowly
   inheritedVelFactor   = "1.458";
   lifetimeMS           = "1689";
   lifetimeVarianceMS   = "187";
   useInvAlpha          = false;
   spinRandomMin        = "0";
   spinRandomMax        = "1";
   spinSpeed            = "0.583";

   colors[0]     = "0.466667 0 1 0.1";
   colors[1]     = "1 0.792157 0 0.627";
   colors[2]     = "0.0 0.0 0.0 0.1";

   sizes[0]      = "3.5";
   sizes[1]      = "2";
   sizes[2]      = "0.1";

   times[0]      = 0.0;
   times[1]      = "0.375";
   times[2]      = "0.416667";
   animTexName = "art/shapes/particles/flame_01.png";
   constantAcceleration = "-5.42";
   sizes[3] = "0.05";
   times[3] = "0.791667";
};

datablock ParticleData(BloodParticleLiF11Z)
{
   id = 101; //CM_REV
   textureName          = "art/shapes/particles/flame_01.png";
   dragCoefficient      = 0.0;
   gravityCoefficient   = "-1";   // rises slowly
   inheritedVelFactor   = "1.458";
   lifetimeMS           = "1689";
   lifetimeVarianceMS   = "187";
   useInvAlpha          = false;
   spinRandomMin        = "0";
   spinRandomMax        = "1";
   spinSpeed            = "0.583";

   colors[0]     = "0.466667 0 1 0.1";
   colors[1]     = "1 0.792157 0 0.627";
   colors[2]     = "0.0 0.0 0.0 0.1";

   sizes[0]      = "3.5";
   sizes[1]      = "2";
   sizes[2]      = "0.1";

   times[0]      = 0.0;
   times[1]      = "0.375";
   times[2]      = "0.416667";
   animTexName = "art/shapes/particles/flame_01.png";
   constantAcceleration = "-5.42";
   sizes[3] = "0.05";
   times[3] = "0.791667";
};

datablock ParticleData(BloodParticleLiF12Z)
{
   id = 102; //CM_REV
   textureName          = "art/shapes/particles/flame_01.png";
   dragCoefficient      = 0.0;
   gravityCoefficient   = "-1";   // rises slowly
   inheritedVelFactor   = "1.458";
   lifetimeMS           = "1689";
   lifetimeVarianceMS   = "187";
   useInvAlpha          = false;
   spinRandomMin        = "0";
   spinRandomMax        = "1";
   spinSpeed            = "0.583";

   colors[0]     = "0.466667 0 1 0.1";
   colors[1]     = "1 0.792157 0 0.627";
   colors[2]     = "0.0 0.0 0.0 0.1";

   sizes[0]      = "3.5";
   sizes[1]      = "2";
   sizes[2]      = "0.1";

   times[0]      = 0.0;
   times[1]      = "0.375";
   times[2]      = "0.416667";
   animTexName = "art/shapes/particles/flame_01.png";
   constantAcceleration = "-5.42";
   sizes[3] = "0.05";
   times[3] = "0.791667";
};

datablock ParticleData(BloodParticleLiF13Z)
{
   id = 103; //CM_REV
   textureName          = "art/shapes/particles/flame_01.png";
   dragCoefficient      = 0.0;
   gravityCoefficient   = "-1";   // rises slowly
   inheritedVelFactor   = "1.458";
   lifetimeMS           = "1689";
   lifetimeVarianceMS   = "187";
   useInvAlpha          = false;
   spinRandomMin        = "0";
   spinRandomMax        = "1";
   spinSpeed            = "0.583";

   colors[0]     = "0.466667 0 1 0.1";
   colors[1]     = "1 0.792157 0 0.627";
   colors[2]     = "0.0 0.0 0.0 0.1";

   sizes[0]      = "3.5";
   sizes[1]      = "2";
   sizes[2]      = "0.1";

   times[0]      = 0.0;
   times[1]      = "0.375";
   times[2]      = "0.416667";
   animTexName = "art/shapes/particles/flame_01.png";
   constantAcceleration = "-5.42";
   sizes[3] = "0.05";
   times[3] = "0.791667";
};

datablock ParticleData(BloodParticleLiF14Z)
{
   id = 104; //CM_REV
   textureName          = "art/shapes/particles/flame_01.png";
   dragCoefficient      = 0.0;
   gravityCoefficient   = "-1";   // rises slowly
   inheritedVelFactor   = "1.458";
   lifetimeMS           = "1689";
   lifetimeVarianceMS   = "187";
   useInvAlpha          = false;
   spinRandomMin        = "0";
   spinRandomMax        = "1";
   spinSpeed            = "0.583";

   colors[0]     = "0.466667 0 1 0.1";
   colors[1]     = "1 0.792157 0 0.627";
   colors[2]     = "0.0 0.0 0.0 0.1";

   sizes[0]      = "3.5";
   sizes[1]      = "2";
   sizes[2]      = "0.1";

   times[0]      = 0.0;
   times[1]      = "0.375";
   times[2]      = "0.416667";
   animTexName = "art/shapes/particles/flame_01.png";
   constantAcceleration = "-5.42";
   sizes[3] = "0.05";
   times[3] = "0.791667";
};

datablock ParticleData(BloodParticleLiF15Z)
{
   id = 105; //CM_REV
   textureName          = "art/shapes/particles/flame_01.png";
   dragCoefficient      = 0.0;
   gravityCoefficient   = "-1";   // rises slowly
   inheritedVelFactor   = "1.458";
   lifetimeMS           = "1689";
   lifetimeVarianceMS   = "187";
   useInvAlpha          = false;
   spinRandomMin        = "0";
   spinRandomMax        = "1";
   spinSpeed            = "0.583";

   colors[0]     = "0.466667 0 1 0.1";
   colors[1]     = "1 0.792157 0 0.627";
   colors[2]     = "0.0 0.0 0.0 0.1";

   sizes[0]      = "3.5";
   sizes[1]      = "2";
   sizes[2]      = "0.1";

   times[0]      = 0.0;
   times[1]      = "0.375";
   times[2]      = "0.416667";
   animTexName = "art/shapes/particles/flame_01.png";
   constantAcceleration = "-5.42";
   sizes[3] = "0.05";
   times[3] = "0.791667";
};

datablock ParticleEmitterData(FireEmitterLiF1Z)
{
   id = 112; //CM_REV
   ejectionPeriodMS = "50";
   periodVarianceMS = "1";
   ejectionVelocity = "0.1";
   velocityVariance = "0.1";
   ejectionOffset = "0.15";
   thetaMin = "15";
   thetaMax = "15";
   softnessDistance = "30";
   particles = "FireParticleLiF1Z";
   blendStyle = "ADDITIVE";
   ambientFactor = "0";
};

datablock ParticleEmitterData(FireEmitterLiF2Z)
{
   id = 113; //CM_REV
   ejectionPeriodMS = "50";
   periodVarianceMS = "1";
   ejectionVelocity = "0.1";
   velocityVariance = "0.1";
   thetaMin         = "0";
   thetaMax         = "50";
   particles        = "FireParticleLiF2Z";
   blendStyle = "ADDITIVE";
   ejectionOffset = "0.05";
   softnessDistance = "10";
   ambientFactor = "0";
};

datablock ParticleEmitterData(SmokeEmitterLiF2Z)
{
   id = 115; //CM_REV
   ejectionPeriodMS = "30";
   periodVarianceMS = "25";
   ejectionVelocity = "0.4";
   velocityVariance = "0.4";
   thetaMin         = 0.0;
   thetaMax         = "75";
   particles        = "SmokeParticleLiF2Z";
   blendStyle = "ADDITIVE";
   phiVariance = "150";
   softnessDistance = "1";
   softParticles = "0";
   ambientFactor = "0.95";
};

// Blood Emitters

datablock ParticleEmitterData(BloodEmitterLiF1Z)
{
   id = 86; //CM_REV
   ejectionPeriodMS = "1000";
   periodVarianceMS = "0";
   ejectionVelocity = "0";
   velocityVariance = "0";
   thetaMin         = 0.0;
   thetaMax         = "0";
   particles        = "BloodParticleLiF1Z";
   blendStyle = "NORMAL";
   softnessDistance = "1";
   phiVariance = "360";
   lifetimeMS = "100";
   lifetimeVarianceMS = "0";
   softParticles = "0";
   alignDirection = "0 0.707107 0.707107";
   alignParticles = "0";
   ambientFactor = "0.85";
};

datablock ParticleEmitterData(BloodEmitterLiF2Z)
{
   id = 87; //CM_REV
   ejectionPeriodMS = "1000";
   periodVarianceMS = "0";
   ejectionVelocity = "0";
   velocityVariance = "0";
   thetaMin         = 0.0;
   thetaMax         = "0";
   particles        = "BloodParticleLiF2Z";
   blendStyle = "NORMAL";
   softnessDistance = "1";
   phiVariance = "360";
   lifetimeMS = "100";
   lifetimeVarianceMS = "0";
   softParticles = "0";
   alignDirection = "0 0.707107 0.707107";
   alignParticles = "0";
   ambientFactor = "0.85";
};


datablock ParticleEmitterData(BloodEmitterLiF3Z)
{
   id = 88; //CM_REV
   ejectionPeriodMS = "1000";
   periodVarianceMS = "0";
   ejectionVelocity = "0";
   velocityVariance = "0";
   thetaMin         = 0.0;
   thetaMax         = "0";
   particles        = "BloodParticleLiF3Z";
   blendStyle = "NORMAL";
   lifetimeMS = "100";
   lifetimeVarianceMS = "0";
   softnessDistance = "1";
   softParticles = "0";
   ambientFactor = "0.85";
};

datablock ParticleEmitterData(BloodEmitterLiF4Z)
{
   id = 89; //CM_REV
   ejectionPeriodMS = "1000";
   periodVarianceMS = "0";
   ejectionVelocity = "0";
   velocityVariance = "0";
   thetaMin         = 0.0;
   thetaMax         = "35";
   particles        = "BloodParticleLiF4Z";
   blendStyle = "NORMAL";
   softnessDistance = "1";
   lifetimeMS = "100";
   lifetimeVarianceMS = "0";
   phiVariance = "150";
   ambientFactor = "0.85";
};

datablock ParticleData(FireOfTorchParticle)
{
   id = 450; //CM_REV
   dragCoefficient = "1";
   inheritedVelFactor = "0.02";
   lifetimeMS = "2000";
   lifetimeVarianceMS = "0";
   spinRandomMin = "-80";
   spinRandomMax = "80";
   useInvAlpha = "1";
   textureName = "art/shapes/particles/flame1.dds";
   animTexName = "art/shapes/particles/flame1.dds";
   colors[0] = "0.996078 0.996078 0.996078 1";
   colors[1] = "0.996078 0.996078 0.996078 0.85";
   colors[2] = "0.996078 0.996078 0.996078 0.9";
   colors[3] = "0.996078 0.996078 0.996078 0.95";
   colors[4] = "0.732283 1 0 0";
   colors[5] = "0.732283 1 0 0";
   colors[6] = "0.732283 1 0 0";
   colors[7] = "0.732283 1 0 0";
   sizes[0] = "0.35";
   sizes[1] = "0.35";
   sizes[2] = "0.35";
   sizes[3] = "0.35";
   sizes[4] = "0.997986";
   sizes[5] = "0.997986";
   sizes[6] = "0.997986";
   sizes[7] = "0.997986";
   times[1] = "0.3";
   times[2] = "0.8";
   times[3] = "1";
   times[4] = "1";
   times[5] = "1";
   times[6] = "1";
   times[7] = "1";
   animTexTiling = "8 8";
   animTexFrames = "0-63";
   animateTexture = "1";
   spinSpeed = "0.8";
   framesPerSec = "32";
   gravityCoefficient = "-0.02";
   constantAcceleration = "2";
   windCoefficient = "0";
   constrainPos = true;
};

datablock ParticleData(SparksOfTorchParticle)
{
   id = 452; //CM_REV
   dragCoefficient = "0.987292";
   gravityCoefficient = "0.15873";
   inheritedVelFactor = "0.497065";
   constantAcceleration = "3";
   lifetimeMS = "2400";
   lifetimeVarianceMS = "1800";
   spinRandomMin = "-10";
   spinRandomMax = "40";
   textureName = "art/shapes/particles/spark_torch.dds";
   animTexName = "art/shapes/particles/spark_torch.dds";
   sizes[0] = "0.015";
   sizes[3] = "0.02";
   sizes[1] = "0.03";
   sizes[2] = "0.015";
   times[1] = "0.3";
   times[2] = "0.6";
   times[3] = "1";
   colors[1] = "1 1 1 0.8";
   colors[2] = "1 1 1 0.3";
   colors[3] = "1 1 1 0.1";
   colors[4] = "1 1 1 0.1";
   colors[5] = "1 1 1 0.1";
   colors[6] = "1 1 1 0.1";
   colors[7] = "1 1 1 0.1";
   sizes[4] = "0.02";
   sizes[5] = "0.02";
   sizes[6] = "0.02";
   sizes[7] = "0.02";
   times[4] = "1";
   times[5] = "1";
   times[6] = "1";
   times[7] = "1";
};


datablock ParticleEmitterData(FireOfTorchEmitter)
{
   id = 453; //CM_REV
   particles = "FireOfTorchParticle";
   ejectionPeriodMS = "300";
   ejectionVelocity = "0.1";
   velocityVariance = "0.04";
   ejectionOffset = "0.1";
   thetaMax = "20";
   softnessDistance = "1000";
   blendStyle = "NORMAL";
   softParticles = "0";
   noiseStrength = "1";
   ejectionOffsetVariance = "0.03";
   periodVarianceMS = "100";
   ambientFactor = "0";
};

datablock ParticleEmitterData(SparksOfTorchEmitter)
{
   id = 455; //CM_REV
   particles = "SparksOfTorchParticle";
   ejectionPeriodMS = "40";
   periodVarianceMS = "19";
   ejectionVelocity = "0.5";
   velocityVariance = "0.1";
   ejectionOffset = "0.07";
   thetaMin = "15";
   thetaMax = "90";
   phiVariance = "180";
   softnessDistance = "8";
   alignDirection = "0 1 0";
   overrideAdvance = "0";
   orientParticles = "1";
   softParticles = "0";
   lifetimeMS = "0";
   orientOnVelocity = "0";
   sortParticles = "1";
   dynamicField = "defaultValue";
   blendStyle = "ADDITIVE";
   originalName = "SparksOfTorchEmitter";
   noiseStrength = "500";
   ambientFactor = "0";
};


// Обломки для взрыва (4 метра)
datablock ParticleData(Explosion_elements_of_dirt_particle)
{
   id = 456; //CM_REV
   dragCoefficient = "0";
   inheritedVelFactor = "5";
   lifetimeMS = "1000";
   lifetimeVarianceMS = "0";
   spinRandomMin = "-90";
   spinRandomMax = "90";
   useInvAlpha = "1";
   textureName = "art/shapes/particles/explosion_elements_of_dirt.dds";
   animTexName = "art/shapes/particles/explosion_elements_of_dirt.dds";
   colors[0] = "0.996078 0.992157 0.992157 1";
   colors[1] = "0.996078 0.996078 0.992157 1";
   colors[2] = "0.996078 0.992157 0.992157 0.7";
   colors[3] = "0.996078 0.996078 0.992157 0.4";
   sizes[0] = "0.05";
   sizes[1] = "0.4";
   sizes[2] = "0.7";
   sizes[3] = "0.1";
   times[0] = "0";
   times[1] = "0.3";
   times[2] = "0.8";
   times[3] = "1";
   animTexTiling = "8 4";
   animTexFrames = "0-31";
   animateTexture = "1";
   gravityCoefficient = "7";
   spinSpeed = "1";
   framesPerSec = "32";
   constantAcceleration = "7";
   windCoefficient = "1";
   colors[4] = "0.996078 0.996078 0.992157 0.4";
   colors[5] = "0.996078 0.996078 0.992157 0.4";
   colors[6] = "0.996078 0.996078 0.992157 0.4";
   colors[7] = "0.996078 0.996078 0.992157 0.4";
   sizes[4] = "0.1";
   sizes[5] = "0.1";
   sizes[6] = "0.1";
   sizes[7] = "0.1";
   times[4] = "1";
   times[5] = "1";
   times[6] = "1";
   times[7] = "1";
};

// Дым для взрыва (4 метра)
datablock ParticleData(Explosion_smoke_particle)
{
   id = 457; //CM_REV
   dragCoefficient = "1";
   inheritedVelFactor = "2";
   lifetimeMS = "4000";
   lifetimeVarianceMS = "0";
   spinRandomMin = "-90";
   spinRandomMax = "90";
   useInvAlpha = "1";
   textureName = "art/shapes/particles/explosion_smoke.dds";
   animTexName = "art/shapes/particles/explosion_smoke.dds";
   colors[0] = "0.776471 0.709804 0.580392 0.2";
   colors[1] = "0.72549 0.658824 0.494118 0.15";
   colors[2] = "0.737255 0.67451 0.545098 0.05";
   colors[3] = "0.956863 0.913726 0.729412 0.01";
   sizes[0] = "10";
   sizes[1] = "20";
   sizes[2] = "30";
   sizes[3] = "40";
   times[0] = "0";
   times[1] = "0.3";
   times[2] = "0.8";
   times[3] = "1";
   animateTexture = "1";
   framesPerSec = "8";
   animTexTiling = "8 4";
   animTexFrames = "0-31";
   gravityCoefficient = "1.5";
   constantAcceleration = "5";
   spinSpeed = "0.5";
   windCoefficient = "1";
   colors[4] = "0.956863 0.913726 0.729412 0.05";
   colors[5] = "0.956863 0.913726 0.729412 0.05";
   colors[6] = "0.956863 0.913726 0.729412 0.05";
   colors[7] = "0.956863 0.913726 0.729412 0.05";
   sizes[4] = "25";
   sizes[5] = "25";
   sizes[6] = "25";
   sizes[7] = "25";
   times[4] = "1";
   times[5] = "1";
   times[6] = "1";
   times[7] = "1";
};

// Огонь для взрыва (4 метра)
datablock ParticleData(Explosion_fire_particle)
{
   id = 458; //CM_REV
   dragCoefficient = "8";
   inheritedVelFactor = "0.5";
   lifetimeMS = "2000";
   lifetimeVarianceMS = "0";
   spinRandomMin = "-90";
   spinRandomMax = "90";
   useInvAlpha = "1";
   textureName = "art/shapes/particles/explosion_fire.dds";
   animTexName = "art/shapes/particles/explosion_fire.dds";
   colors[0] = "0.996078 0.996078 0.996078 1";
   colors[1] = "0.996078 0.996078 0.996078 0.5";
   colors[2] = "0.996078 0.996078 0.996078 0.3";
   colors[3] = "0.996078 0.996078 0.996078 0.1";
   sizes[0] = "2";
   sizes[1] = "6";
   sizes[2] = "8";
   sizes[3] = "14";
   times[0] = "0";
   times[1] = "0.3";
   times[2] = "0.8";
   times[3] = "1";
   animateTexture = "1";
   framesPerSec = "32";
   animTexTiling = "8 8";
   animTexFrames = "0-63";
   gravityCoefficient = "0.25";
   constantAcceleration = "4";
   spinSpeed = "0.5";
   windCoefficient = "1";
   colors[4] = "0.996078 0.996078 0.996078 0.1";
   colors[5] = "0.996078 0.996078 0.996078 0.1";
   colors[6] = "0.996078 0.996078 0.996078 0.1";
   colors[7] = "0.996078 0.996078 0.996078 0.1";
   sizes[4] = "18";
   sizes[5] = "18";
   sizes[6] = "18";
   sizes[7] = "18";
   times[4] = "1";
   times[5] = "1";
   times[6] = "1";
   times[7] = "1";
};


// Обломки для взрыва (2 метра)
datablock ParticleData(Explosion_elements_of_dirt_small_particle)
{
   id = 459; //CM_REV
   dragCoefficient = "0";
   inheritedVelFactor = "4";
   lifetimeMS = "1000";
   lifetimeVarianceMS = "0";
   spinRandomMin = "-90";
   spinRandomMax = "90";
   useInvAlpha = "1";
   textureName = "art/shapes/particles/explosion_elements_of_dirt.dds";
   animTexName = "art/shapes/particles/explosion_elements_of_dirt.dds";
   colors[0] = "0.996078 0.992157 0.992157 1";
   colors[1] = "0.996078 0.996078 0.992157 1";
   colors[2] = "0.996078 0.992157 0.992157 0.7";
   colors[3] = "0.996078 0.996078 0.992157 0.4";
   sizes[0] = "0.02";
   sizes[1] = "0.2";
   sizes[2] = "0.3";
   sizes[3] = "0.05";
   times[0] = "0";
   times[1] = "0.3";
   times[2] = "0.8";
   times[3] = "1";
   animTexTiling = "8 4";
   animTexFrames = "0-31";
   animateTexture = "1";
   gravityCoefficient = "5";
   spinSpeed = "1";
   framesPerSec = "32";
   constantAcceleration = "7";
   windCoefficient = "1";
   colors[4] = "0.996078 0.996078 0.992157 0.4";
   colors[5] = "0.996078 0.996078 0.992157 0.4";
   colors[6] = "0.996078 0.996078 0.992157 0.4";
   colors[7] = "0.996078 0.996078 0.992157 0.4";
   sizes[4] = "0.05";
   sizes[5] = "0.05";
   sizes[6] = "0.05";
   sizes[7] = "0.05";
   times[4] = "1";
   times[5] = "1";
   times[6] = "1";
   times[7] = "1";
};

// Огонь для взрыва (2 метра)
datablock ParticleData(Explosion_fire_small_particle)
{
   id = 460; //CM_REV
   dragCoefficient = "1";
   inheritedVelFactor = "0.5";
   lifetimeMS = "2000";
   lifetimeVarianceMS = "0";
   spinRandomMin = "-90";
   spinRandomMax = "90";
   useInvAlpha = "1";
   textureName = "art/shapes/particles/explosion_fire.dds";
   animTexName = "art/shapes/particles/explosion_fire.dds";
   colors[0] = "0.996078 0.996078 0.996078 1";
   colors[1] = "0.996078 0.996078 0.996078 0.5";
   colors[2] = "0.996078 0.996078 0.996078 0.3";
   colors[3] = "0.996078 0.996078 0.996078 0.1";
   sizes[0] = "1";
   sizes[1] = "4";
   sizes[2] = "8";
   sizes[3] = "12";
   times[0] = "0";
   times[1] = "0.3";
   times[2] = "0.8";
   times[3] = "1";
   animateTexture = "1";
   framesPerSec = "32";
   animTexTiling = "8 8";
   animTexFrames = "0-63";
   gravityCoefficient = "0.15";
   constantAcceleration = "1";
   spinSpeed = "0.5";
   windCoefficient = "1";
   colors[4] = "0.996078 0.996078 0.996078 0.1";
   colors[5] = "0.996078 0.996078 0.996078 0.1";
   colors[6] = "0.996078 0.996078 0.996078 0.1";
   colors[7] = "0.996078 0.996078 0.996078 0.1";
   sizes[4] = "9";
   sizes[5] = "9";
   sizes[6] = "9";
   sizes[7] = "9";
   times[4] = "1";
   times[5] = "1";
   times[6] = "1";
   times[7] = "1";
};

// Дым для взрыва (2 метра)
datablock ParticleData(Explosion_smoke_small_particle)
{
   id = 461; //CM_REV
   dragCoefficient = "1";
   inheritedVelFactor = "1";
   lifetimeMS = "4000";
   lifetimeVarianceMS = "0";
   spinRandomMin = "-90";
   spinRandomMax = "90";
   useInvAlpha = "1";
   textureName = "art/shapes/particles/explosion_smoke.dds";
   animTexName = "art/shapes/particles/explosion_smoke.dds";
   colors[0] = "0.776471 0.709804 0.580392 0.3";
   colors[1] = "0.72549 0.658824 0.494118 0.2";
   colors[2] = "0.737255 0.67451 0.545098 0.05";
   colors[3] = "0.956863 0.913726 0.729412 0.02";
   sizes[0] = "3";
   sizes[1] = "6";
   sizes[2] = "10";
   sizes[3] = "15";
   times[0] = "0";
   times[1] = "0.3";
   times[2] = "0.8";
   times[3] = "1";
   animateTexture = "1";
   framesPerSec = "16";
   animTexTiling = "8 4";
   animTexFrames = "0-31";
   gravityCoefficient = "0.5";
   constantAcceleration = "5";
   spinSpeed = "0.5";
   windCoefficient = "1";
   colors[4] = "0.956863 0.913726 0.729412 0.05";
   colors[5] = "0.956863 0.913726 0.729412 0.05";
   colors[6] = "0.956863 0.913726 0.729412 0.05";
   colors[7] = "0.956863 0.913726 0.729412 0.05";
   sizes[4] = "10";
   sizes[5] = "10";
   sizes[6] = "10";
   sizes[7] = "10";
   times[4] = "1";
   times[5] = "1";
   times[6] = "1";
   times[7] = "1";
};


// Обломки для взрыва (4 метра)
datablock ParticleEmitterData(Explosion_elements_of_dirt)
{
   id = 462; //CM_REV
   ejectionPeriodMS = "20";
   ejectionVelocity = "8";
   velocityVariance = "2";
   ejectionOffset = "1";
   thetaMax = "120";
   softnessDistance = "1";
   particles = "Explosion_elements_of_dirt_particle";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   thetaMin = "50";
   ejectionOffsetVariance = "0.7";
   noiseStrength = "40";
   lifetimeMS = "400";
   periodVarianceMS = "19";
   ambientFactor = "0.8";
};

// Дым для взрыва (4 метра)
datablock ParticleEmitterData(Explosion_smoke)
{
   id = 463; //CM_REV
   ejectionPeriodMS = "10";
   ejectionVelocity = "1.5";
   velocityVariance = "1.3";
   ejectionOffset = "0.1";
   thetaMax = "120";
   softnessDistance = "1000";
   particles = "Explosion_smoke_particle";
   blendStyle = "NORMAL";
   softParticles = "0";
   thetaMin = "0";
   ejectionOffsetVariance = "0.1";
   lifetimeMS = "800";
   periodVarianceMS = "8";
   noiseStrength = "50";
   ambientFactor = "0.9";
};

// Огонь для взрыва (4 метра)
datablock ParticleEmitterData(Explosion_fire)
{
   id = 464; //CM_REV
   ejectionPeriodMS = "40";
   ejectionVelocity = "4";
   velocityVariance = "0.3";
   ejectionOffset = "0.1";
   thetaMax = "100";
   softnessDistance = "1";
   particles = "Explosion_fire_particle";
   blendStyle = "NORMAL";
   softParticles = "0";
   lifetimeMS = "400";
   noiseStrength = "10";
   periodVarianceMS = "10";
   ambientFactor = "0";
};

// Обломки для взрыва (2 метра)
datablock ParticleEmitterData(Explosion_elements_of_dirt_small)
{
   id = 465; //CM_REV
   ejectionPeriodMS = "20";
   ejectionVelocity = "8";
   velocityVariance = "2";
   ejectionOffset = "0.5";
   thetaMax = "120";
   softnessDistance = "1";
   particles = "Explosion_elements_of_dirt_small_particle";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   thetaMin = "50";
   ejectionOffsetVariance = ".2";
   noiseStrength = "40";
   lifetimeMS = "400";
   periodVarianceMS = "19";
   ambientFactor = "0.75";
};

// Огонь для взрыва (2 метра)
datablock ParticleEmitterData(Explosion_fire_small)
{
   id = 466; //CM_REV
   ejectionPeriodMS = "50";
   ejectionVelocity = "0.7";
   velocityVariance = "0.2";
   ejectionOffset = "0.1";
   thetaMax = "100";
   softnessDistance = "1";
   particles = "Explosion_fire_small_particle";
   blendStyle = "NORMAL";
   softParticles = "0";
   lifetimeMS = "400";
   noiseStrength = "10";
   ambientFactor = "0";
};

// Дым для взрыва (2 метра)
datablock ParticleEmitterData(Explosion_smoke_small)
{
   id = 467; //CM_REV
   ejectionPeriodMS = "10";
   ejectionVelocity = "0.3";
   velocityVariance = "0.3";
   ejectionOffset = "0.1";
   thetaMax = "120";
   softnessDistance = "1";
   particles = "Explosion_smoke_small_particle";
   blendStyle = "NORMAL";
   softParticles = "0";
   thetaMin = "0";
   ejectionOffsetVariance = "0.1";
   lifetimeMS = "800";
   periodVarianceMS = "8";
   noiseStrength = "10";
   ambientFactor = "0.88";
};

// Разрушения здания. Состовной эффект.
   //Пыль при разрушении 1
datablock ParticleData(Building_destruction_dust1_particle)
{
   id=468;
   dragCoefficient = "0.583";
   inheritedVelFactor = "1.2";
   lifetimeMS = "2000";
   lifetimeVarianceMS = "0";
   spinRandomMin = "-120";
   spinRandomMax = "180";
   useInvAlpha = "1";
   textureName = "art/shapes/particles/dust_from_bd_1.dds";
   animTexName = "art/shapes/particles/dust_from_bd_1.dds";
   colors[0] = "0.996078 0.992157 0.992157 0.15";
   colors[1] = "0.996078 0.996078 0.992157 0.3";
   colors[2] = "0.996078 0.992157 0.992157 0.1";
   colors[3] = "0.996078 0.996078 0.992157 0.05";
   colors[4] = "0.732283 1 0 0";
   colors[5] = "0.732283 1 0 0";
   colors[6] = "0.732283 1 0 0";
   colors[7] = "0.732283 1 0 0";
   sizes[0] = "5";
   sizes[1] = "6";
   sizes[2] = "8";
   sizes[3] = "12";
   sizes[4] = "0.997986";
   sizes[5] = "0.997986";
   sizes[6] = "0.997986";
   sizes[7] = "0.997986";
   times[1] = "0.3";
   times[2] = "0.8";
   times[3] = "1";
   times[4] = "1";
   times[5] = "1";
   times[6] = "1";
   times[7] = "1";
   animateTexture = "1";
   framesPerSec = "32";
   animTexTiling = "8 8";
   animTexFrames = "0-63";
   spinSpeed = "0.4";
   constantAcceleration = "8";
   gravityCoefficient = "0.375";
};

datablock ParticleEmitterData(Building_destruction_dust1)
{
   id=469;
   ejectionPeriodMS = "10";
   periodVarianceMS = "9";
   ejectionVelocity = "0.2";
   velocityVariance = "0.2";
   ejectionOffset = "0.8";
   thetaMax = "70";
   particles = "Building_destruction_dust1_particle";
   lifetimeMS = "2000";
   lifetimeVarianceMS = "500";
   blendStyle = "NORMAL";
   randomArea = "0 0 1";
   noiseStrength = "8";
   softParticles = "0";
   ejectionOffsetVariance = "1";
   ambientFactor = "0.9";
};
   //Пыль при разрушении 2.
datablock ParticleData(Building_destruction_dust2_particle)
{
  id=470;
   dragCoefficient = "1";
   inheritedVelFactor = "0.3";
   lifetimeMS = "2000";
   lifetimeVarianceMS = "800";
   spinRandomMin = "-120";
   spinRandomMax = "120";
   useInvAlpha = "1";
   textureName = "art/shapes/particles/dust_from_bd_2.dds";
   animTexName = "art/shapes/particles/dust_from_bd_2.dds";
   colors[0] = "0.996078 0.992157 0.992157 0.05";
   colors[1] = "0.996078 0.996078 0.992157 0.2";
   colors[2] = "0.996078 0.992157 0.992157 0.1";
   colors[3] = "0.996078 0.996078 0.992157 0.05";
   colors[4] = "0.732283 1 0 0";
   colors[5] = "0.732283 1 0 0";
   colors[6] = "0.732283 1 0 0";
   colors[7] = "0.732283 1 0 0";
   sizes[0] = "2";
   sizes[1] = "5";
   sizes[2] = "8";
   sizes[3] = "10";
   sizes[4] = "0.997986";
   sizes[5] = "0.997986";
   sizes[6] = "0.997986";
   sizes[7] = "0.997986";
   times[1] = "0.3";
   times[2] = "0.8";
   times[3] = "1";
   times[4] = "1";
   times[5] = "1";
   times[6] = "1";
   times[7] = "1";
   animateTexture = "1";
   framesPerSec = "32";
   animTexTiling = "8 8";
   animTexFrames = "0-63";
   spinSpeed = "0.4";
   constantAcceleration = "4";
   windCoefficient = "1";
   gravityCoefficient = "0.125";
   ejectionPeriodMS = "51";
   periodVarianceMS = "50";
   ejectionVelocity = "0.7";
   velocityVariance = "0.5";
   ejectionOffset = "0.3";
   thetaMin = "56.25";
   thetaMax = "120";
   softParticles = "0";
   particles = "Building_destruction_dust2_particle";
   blendStyle = "NORMAL";
   randomArea = "0 0 1";
   noiseStrength = "3";
   ejectionOffsetVariance = "1";
};
datablock ParticleEmitterData(Building_destruction_dust2)
{
  id=471;
   ejectionPeriodMS = "51";
   ejectionVelocity = "0.7";
   velocityVariance = "0.5";
   ejectionOffset = "0.3";
   thetaMax = "120";
   softnessDistance = "1";
   particles = "Building_destruction_dust2_particle";
   blendStyle = "NORMAL";
   softParticles = "0";
   randomArea = "0 0 1";
   periodVarianceMS = "50";
   ejectionOffsetVariance = "1";
   lifetimeMS = "2000";
   lifetimeVarianceMS = "800";
   thetaMin = "56.25";
   phiVariance = "360";
   phiVariance = "180";
   noiseStrength = "3";
   ambientFactor = "0.9";
};
   //Осколки породы (фрагменты камней)
datablock ParticleData(Building_destruction_element_particle)
{
  id=472;
   dragCoefficient = "1";
   inheritedVelFactor = "2";
   lifetimeMS = "2000";
   lifetimeVarianceMS = "800";
   spinRandomMin = "-180";
   spinRandomMax = "180";
   useInvAlpha = "1";
   textureName = "art/shapes/particles/bd_element.dds";
   animTexName = "art/shapes/particles/bd_element.dds";
   colors[0] = "0.996078 0.992157 0.992157 1";
   colors[1] = "0.996078 0.996078 0.992157 1";
   colors[2] = "0.996078 0.992157 0.992157 1";
   colors[3] = "0.996078 0.996078 0.992157 1";
   colors[4] = "0.732283 1 0 0";
   colors[5] = "0.732283 1 0 0";
   colors[6] = "0.732283 1 0 0";
   colors[7] = "0.732283 1 0 0";
   sizes[0] = "0.3";
   sizes[1] = "0.6";
   sizes[2] = "0.8";
   sizes[3] = "1";
   sizes[4] = "0.997986";
   sizes[5] = "0.997986";
   sizes[6] = "0.997986";
   sizes[7] = "0.997986";
   times[1] = "0.3";
   times[2] = "0.8";
   times[3] = "1";
   times[4] = "1";
   times[5] = "1";
   times[6] = "1";
   times[7] = "1";
   animateTexture = "1";
   framesPerSec = "32";
   animTexTiling = "8 8";
   animTexFrames = "0-63";
   spinSpeed = "0.7";
   constantAcceleration = "6";
   gravityCoefficient = "5";
   ejectionPeriodMS = "50";
   periodVarianceMS = "49";
   ejectionVelocity = "5";
   velocityVariance = "2";
   ejectionOffset = "0.2";
   thetaMin = "40";
   thetaMax = "50";
   softnessDistance = "1000";
   particles = "Building_destruction_element_particle";
   blendStyle = "PREMULTALPHA";
   randomArea = "0 0 1";
   noiseStrength = "5";
   ejectionOffsetVariance = "1";
};
datablock ParticleEmitterData(Building_destruction_element)
{
  id=473;
   ejectionPeriodMS = "50";
   ejectionVelocity = "1";
   velocityVariance = "0";
   ejectionOffset = "0.2";
   thetaMax = "40";
   softnessDistance = "1000";
   particles = "Building_destruction_element_particle";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   thetaMin = "40";
   noiseStrength = "8";
   phiVariance = "180";
   lifetimeMS = "2000";
   randomArea = "0 0 1";
   phiVariance = "180";
   ejectionOffsetVariance = "1";
   periodVarianceMS = "49";
   lifetimeVarianceMS = "800";
   ambientFactor = "0.9";
};
//Пыль при установке здания
datablock ParticleData(Dust_from_building_construction_particle)
{
  id=474;
   dragCoefficient = "0.498534";
   inheritedVelFactor = "0.9";
   lifetimeMS = "2000";
   lifetimeVarianceMS = "0";
   spinRandomMin = "-120";
   spinRandomMax = "120";
   useInvAlpha = "1";
   textureName = "art/shapes/particles/dust_from_destruction_and_construction.dds";
   animTexName = "art/shapes/particles/dust_from_destruction_and_construction.dds";
   colors[0] = "0.996078 0.992157 0.992157 0.03";
   colors[1] = "0.996078 0.996078 0.992157 0.2";
   colors[2] = "0.996078 0.992157 0.992157 0.2";
   colors[3] = "0.996078 0.996078 0.992157 0.1";
   colors[4] = "0.732283 1 0 0";
   colors[5] = "0.732283 1 0 0";
   colors[6] = "0.732283 1 0 0";
   colors[7] = "0.732283 1 0 0";
   sizes[0] = "8";
   sizes[1] = "10";
   sizes[2] = "13";
   sizes[3] = "16";
   sizes[4] = "0.997986";
   sizes[5] = "0.997986";
   sizes[6] = "0.997986";
   sizes[7] = "0.997986";
   times[1] = "0.3";
   times[2] = "0.8";
   times[3] = "1";
   times[4] = "1";
   times[5] = "1";
   times[6] = "1";
   times[7] = "1";
   animateTexture = "1";
   framesPerSec = "32";
   animTexTiling = "8 8";
   animTexFrames = "0-63";
   gravityCoefficient = "0.3";
   constantAcceleration = "10";
   spinSpeed = "0.3";
   windCoefficient = "1";
};
datablock ParticleEmitterData(Dust_from_building_construction)
{
  id=475;
   particles = "Dust_from_building_construction_particle";
   ejectionPeriodMS = "20";
   ejectionVelocity = "0.1";
   velocityVariance = "0.1";
   ejectionOffset = "2";
   thetaMax = "130";
   softnessDistance = "0";
   blendStyle = "NORMAL";
   softParticles = "0";
   randomArea = "1 0 0";
   ejectionOffsetVariance = ".6";
   periodVarianceMS = "14";
   noiseStrength = "25";
   lifetimeMS = "1600";
   lifetimeVarianceMS = "800";
   ambientFactor = "0.9";
};

//Дым для оружия (новый дым для факела)
datablock ParticleData(weapon_smoke_particle)
{
   id = 503;
   dragCoefficient = "1";
   inheritedVelFactor = "-0.005";
   lifetimeMS = "1500";
   lifetimeVarianceMS = "0";
   spinRandomMin = "-180";
   spinRandomMax = "180";
   useInvAlpha = "1";
   textureName = "art/shapes/particles/weapon_smoke.dds";
   animTexName = "art/shapes/particles/weapon_smoke.dds";
   colors[0] = "0.564706 0.372549 0.215686 0.15";
   colors[1] = "0.862745 0.741176 0.67451 0.07";
   colors[2] = "0.92549 0.866667 0.752941 0.07";
   colors[3] = "0.992157 0.996078 0.988235 0.07";
   colors[4] = "0.732283 1 0 0";
   colors[5] = "0.732283 1 0 0";
   colors[6] = "0.732283 1 0 0";
   colors[7] = "0.732283 1 0 0";
   sizes[0] = "10";
   sizes[1] = "8";
   sizes[2] = "8";
   sizes[3] = "10";
   sizes[4] = "0.997986";
   sizes[5] = "0.997986";
   sizes[6] = "0.997986";
   sizes[7] = "0.997986";
   times[1] = "0.247059";
   times[2] = "0.8";
   times[3] = "1";
   times[4] = "1";
   times[5] = "1";
   times[6] = "1";
   times[7] = "1";
   animateTexture = "1";
   framesPerSec = "16";
   animTexTiling = "8 4";
   animTexFrames = "8-31";
   spinSpeed = "0.5";
   constantAcceleration = "20";
   gravityCoefficient = "-0.05";
   windCoefficient = "1";
};

//Дым для оружия (новый дым для факела)
datablock ParticleEmitterData(weapon_smoke)
{
   id = 502;
   ejectionPeriodMS = "60";
   ejectionVelocity = "0.6";
   velocityVariance = "0.2";
   ejectionOffset = "0.05";
   thetaMax = "40";
   softnessDistance = "0.15";
   particles = "weapon_smoke_particle";
   blendStyle = "NORMAL";
   softParticles = "1";
   ejectionOffsetVariance = "0.1";
   randomArea = "0 0 0.2";
   periodVarianceMS = "5";
   phiVariance = "180";
   phiVariance = "180";
   noiseStrength = "5";
   ambientFactor = "0.75";
};

//Шлейф для снаряда требушета
datablock ParticleData(big_weapon_smoke_particle)
{
   id = 448;
   dragCoefficient = "1";
   inheritedVelFactor = "0.35";
   lifetimeMS = "8000";
   lifetimeVarianceMS = "0";
   spinRandomMin = "-180";
   spinRandomMax = "180";
   useInvAlpha = "1";
   textureName = "art/shapes/particles/big_smoke_looped.dds";
   animTexName = "art/shapes/particles/big_smoke_looped.dds";
   colors[0] = "0.564706 0.372549 0.215686 0.05";
   colors[1] = "0.862745 0.741176 0.67451 0.03";
   colors[2] = "0.92549 0.866667 0.752941 0.02";
   colors[3] = "0.992157 0.996078 0.988235 0.01";
   colors[4] = "0.732283 1 0 0";
   colors[5] = "0.732283 1 0 0";
   colors[6] = "0.732283 1 0 0";
   colors[7] = "0.732283 1 0 0";
   sizes[0] = "5";
   sizes[1] = "15";
   sizes[2] = "25";
   sizes[3] = "35";
   sizes[4] = "0.997986";
   sizes[5] = "0.997986";
   sizes[6] = "0.997986";
   sizes[7] = "0.997986";
   times[1] = "0.247059";
   times[2] = "0.8";
   times[3] = "1";
   times[4] = "1";
   times[5] = "1";
   times[6] = "1";
   times[7] = "1";
   animateTexture = "1";
   framesPerSec = "32";
   animTexTiling = "8 8";
   animTexFrames = "0-63";
   spinSpeed = "0.3";
   constantAcceleration = "8";
   gravityCoefficient = "-0.05";
   windCoefficient = "1";
};

//Шлейф для снаряда требушета
datablock ParticleEmitterData(big_weapon_smoke)
{
   id = 449;
   ejectionPeriodMS = "60";
   ejectionVelocity = "0.6";
   velocityVariance = "0.15";
   ejectionOffset = "0.05";
   thetaMax = "40";
   softnessDistance = "1000";
   particles = "big_weapon_smoke_particle";
   blendStyle = "NORMAL";
   softParticles = "0";
   ejectionOffsetVariance = "0.1";
   randomArea = "0 0 0.2";
   periodVarianceMS = "10";
   phiVariance = "180";
   phiVariance = "180";
   noiseStrength = "2";
   ambientFactor = "0.4";
};

//Искры, имитирующие фейерверк
datablock ParticleData(spark_star_particle)
{
   id = 387;
   dragCoefficient = "1";
   inheritedVelFactor = "0.8";
   lifetimeMS = "1500";
   lifetimeVarianceMS = "0";
   spinRandomMin = "-360";
   spinRandomMax = "360";
   useInvAlpha = "1";
   textureName = "art/shapes/particles/spark_star.dds";
   animTexName = "art/shapes/particles/spark_star.dds";
   colors[0] = "0.996078 0.988235 0.988235 1";
   colors[1] = "0.996078 0.996078 0.988235 1";
   colors[2] = "0.996078 0.992157 0.988235 1";
   colors[3] = "0.992157 0.996078 0.988235 1";
   colors[4] = "0.732283 1 0 0";
   colors[5] = "0.732283 1 0 0";
   colors[6] = "0.732283 1 0 0";
   colors[7] = "0.732283 1 0 0";
   sizes[0] = "0.05";
   sizes[1] = "0.1";
   sizes[2] = "0.03";
   sizes[3] = "0.12";
   sizes[4] = "0.997986";
   sizes[5] = "0.997986";
   sizes[6] = "0.997986";
   sizes[7] = "0.997986";
   times[1] = "0.247059";
   times[2] = "0.8";
   times[3] = "1";
   times[4] = "1";
   times[5] = "1";
   times[6] = "1";
   times[7] = "1";
   animateTexture = "0";
   framesPerSec = "32";
   animTexTiling = "1 1";
   animTexFrames = "0-0";
   gravityCoefficient = "0.8";
   constantAcceleration = "0";
   windCoefficient = "1";
   spinSpeed = "0.7";
};

//Искры, имитирующие фейерверк
datablock ParticleEmitterData(spark_star)
{
   id = 386;
   ejectionPeriodMS = "10";
   ejectionVelocity = "1.5";
   velocityVariance = "0.2";
   ejectionOffset = "0.05";
   thetaMax = "180";
   softnessDistance = "5";
   particles = "spark_star_particle";
   blendStyle = "ADDITIVE";
   softParticles = "1";
   noiseStrength = "300";
   periodVarianceMS = "5";
   randomArea = "0.2 0.2 0.2";
   ejectionOffsetVariance = "0.15";
   ambientFactor = "0";
};

datablock FireEmitterData(TestFireEmitter)
{
   id = 593;
   
   textureName = "art/shapes/particles/torch.dds";
   chainsize = 6;
   minChainLength = 0.1;
   maxChainLength = 0.2;
   msPerFrame = 40;
   width = 0.4;
   constantAngleDiviation = 0.2;
   animationRows = 8;
   animationCols = 8;
   distortionMinForce = 1;
   distortionMaxForce = 16;
   distortionMultiplier = 5;
   distortionRotSpeed = 3.1415;
};

datablock AnimatedBillboardData(TestAnimatedBillboard)
{
   id = 594;
   
   textureName = "art/shapes/particles/torchtop.dds";
   msPerFrame = 40;
   width = 0.6;
   animationRows = 8;
   animationCols = 8;
   
   minFadeAngle = 0.2;
   fadeAngle = 0.5;
   keepOrientation = true;
   orientVector = "0 0 1";
   
   offset = 0.1;
};

datablock ParticleData(Building_destruction_element_particle)
{
   gravityCoefficient = "6";
   inheritedVelFactor = "2";
   constantAcceleration = "6";
   lifetimeMS = "2000";
   spinSpeed = "0.7";
   spinRandomMin = "-180";
   spinRandomMax = "180";
   useInvAlpha = "1";
   animateTexture = "1";
   framesPerSec = "32";
   animTexTiling = "8 8";
   animTexFrames = "0-63";
   textureName = "art/shapes/particles/bd_element.dds";
   animTexName = "art/shapes/particles/bd_element.dds";
   colors[0] = "0.996078 0.992157 0.992157 1";
   colors[1] = "0.996078 0.996078 0.992157 1";
   colors[2] = "0.996078 0.992157 0.992157 1";
   colors[3] = "0.996078 0.996078 0.992157 1";
   colors[4] = "0.732283 1 0 0";
   colors[5] = "0.732283 1 0 0";
   colors[6] = "0.732283 1 0 0";
   colors[7] = "0.732283 1 0 0";
   sizes[0] = "0.3";
   sizes[1] = "0.6";
   sizes[2] = "0.8";
   sizes[4] = "0.997986";
   sizes[5] = "0.997986";
   sizes[6] = "0.997986";
   sizes[7] = "0.997986";
   times[1] = "0.3";
   times[2] = "0.8";
   times[3] = "1";
   times[4] = "1";
   times[5] = "1";
   times[6] = "1";
   times[7] = "1";
};

datablock ParticleData(TerFallParticleLiF)
{
   id = 137; //CM_REV
   dragCoefficient = 0;
   windCoefficient = 0.2;
   gravityCoefficient = "-0.0512821";
   inheritedVelFactor = "0.199609";
   constantAcceleration = "0";
   lifetimeMS = "5000";
   lifetimeVarianceMS = "1500";
   spinSpeed = "0";
   spinRandomMin = "-100";
   spinRandomMax = "100";
   useInvAlpha = "1";
   textureName = "art/shapes/particles/dirt_1.png";
   colors[0] = "0.0944882 0.0944882 0.0944882 0.795276";
   colors[1] = "0.692913 0.692913 0.692913 0.598425";
   colors[2] = "0.897638 0.897638 0.897638 0.0944882";
   colors[3] = "1 1 1 1";
   sizes[0] = "5";
   sizes[1] = "5";
   sizes[2] = "10";
   sizes[3] = "20";
   times[0] = "0";
   times[1] = "0.6";
   times[2] = "1";
   times[3] = "2";
   animTexName = "art/shapes/particles/dirt_1.png";
   originalName = "TerFallParticleLiF";
};

datablock ParticleEmitterData(TerFallEmitterLiF)
{
   id = 138; //CM_REV
   ejectionPeriodMS = "100";
   periodVarianceMS = "0";
   ejectionVelocity = "0.4";
   velocityVariance = "0.4";
   thetaMin         = 0.0;
   thetaMax         = "75";
   particles        = "TerFallParticleLiF";
   blendStyle = "ADDITIVE";
   phiVariance = "150";
   softnessDistance = "1";
   ambientFactor = "10";
   softParticles = "0";
};
