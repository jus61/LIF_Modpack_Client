//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

datablock WeaponData(BaseThrowing)
{
   local = true;

   hitDirection[0] = ""; // Thrust
   hitDirection[1] = ""; // Overhead
   hitDirection[2] = ""; // RightToLeftHit
   hitDirection[3] = ""; // LeftToRightHit
   correctMuzzleVector = false;

   // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   stateScript[0] = "onRangedImageReady";

   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   // stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnTriggerUp[1] = "Fire";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateSequence[1] = "Throw_prefire"; // анимация в луке
   stateDirection[1] =true;      // с начала
   stateFreezeAnimation[1] =false;  // играть
   //stateScript[1] = "onRangedImagePrefire";                  --- make a script

   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   stateSequence[2] = "Throw_prefire"; // анимация в луке
   //stateDirection[2] =false;      // с конца
   //stateFreezeAnimation[2] =true; // стоять

   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;

   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "FireCancelRecoil"; // go imediately
   stateAllowImageChange[4] = false;

   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;       // будет просчитываться анимация персонажа
   stateTransitionOnTimeout[5] = "PostFireWait";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onThrowingWeaponFire";

   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFireWaitForTriggerUp"; // go imediately
   stateAllowImageChange[6] = false;

   // After hit. Wait for time
   stateName[7] = "PostFireWait";
   stateFireSubState[7] = PostFire;
   stateTimeoutValue[7] = 0.5; //wait a second
   stateTransitionOnTimeout[7] = "PostFireDrawWeapon";
   stateAllowImageChange[7] = false;

   stateName[8] = "PostFireDrawWeapon";
   stateTransitionOnTimeout[8] = "Draw";
   stateAllowImageChange[8] = false;
   stateScript[8] = "onThrowingWeaponPostfire";

   stateName[9] = "PostFireWaitForTriggerUp";
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;

   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;

   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;

   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
};

datablock ArrowData(ThrowingKnifeProjectile)
{
	id = 577;
	// ArrowData:
	sound = "ThrowingFlySound";
	stuckArrowLifeTime = 1000;
	projectileShape = "art/models/3d-2d/weapons/ammunition/throwingknife_export_01.dts";
	upForce = 0;
	Friction = 0.15;
	// ShapeBaseImageData:
	shapeFile = "art/models/3d-2d/weapons/ammunition/throwingknife_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
};

datablock ThrowingWeaponData(ThrowingKnife : BaseThrowing)
{
	id = 578;
	Object_typeID = 608;
	shapeFile = "art/models/3d-2d/weapons/ammunition/throwingknife_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	hitGroupType[0] = Slashing;
	hitGroupDmgLevel[0] = 3.2;
	WoundMultiplier = "0.1";
	FractureMultiplier = "0";
	StunMultiplier = "0";

	AgilityNeed = 20.0;
	StrengthNeed = 10.0;
	MaxAccuracy = 1.3;
	Emax = 12.0;
	BasePrefireAnimTime = 0.5;
	BaseRecoilAnimTime = 0.2;
	StaminaRate = 30.0;

	attackType = AttackThrowing;
	WeaponType = WeaponThrowing;

	// ArrowData datablock connected to throwing weapon
	projectileData = "ThrowingKnifeProjectile";
};

datablock ArrowData(ThrowingJavelinProjectile)
{
   id = 579;
   // ArrowData:
   sound = "ThrowingFlySound";
   stuckArrowLifeTime = 1000;
   projectileShape = "art/models/3d-2d/weapons/ammunition/throwingspear_export_01.dts";
   upForce = 0.0;
   Friction = 0.08;
   // ShapeBaseImageData:
   shapeFile = "art/models/3d-2d/weapons/ammunition/throwingspear_export_01.dts";
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";
   correctMuzzleVector = false;
   WeaponType = WeaponAmmo;
};

datablock ThrowingWeaponData(ThrowingJavelin : BaseThrowing)
{
   id = 580;
   Object_typeID = 609;
   shapeFile = "art/models/3d-2d/weapons/ammunition/throwingspear_export_01.dts";
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 2.15;
   WoundMultiplier = "0.09";
   FractureMultiplier = "0";
   StunMultiplier = "0";

   AgilityNeed = 20.0;
   StrengthNeed = 30.0;
   MaxAccuracy = 1.2;
   Emax = 28.0;
   BasePrefireAnimTime = 0.5;
   BaseRecoilAnimTime = 0.2;
   StaminaRate = 50.0;

   attackType = AttackThrowing;
   WeaponType = WeaponThrowing;

   // ArrowData datablock connected to throwing weapon
   projectileData = "ThrowingJavelinProjectile";
};

datablock ArrowData(ThrowingAxeProjectile)
{
   id = 573;
   // ArrowData:
   sound = "ThrowingFlySound";
   stuckArrowLifeTime = 1000;
   projectileShape = "art/models/3d-2d/weapons/ammunition/francisca_export_01.dts";
   upForce = 0.0;
   Friction = 0.25;
   // ShapeBaseImageData:
   shapeFile = "art/models/3d-2d/weapons/ammunition/francisca_export_01.dts";
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";
   correctMuzzleVector = false;
   WeaponType = WeaponAmmo;
};

datablock ThrowingWeaponData(ThrowingAxe : BaseThrowing)
{
   id = 574;
   Object_typeID = 610;
   shapeFile = "art/models/3d-2d/weapons/ammunition/francisca_export_01.dts";
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";
   hitGroupType[0] = Chopping;
   hitGroupDmgLevel[0] = 2.75;
   WoundMultiplier = "0.06";
   FractureMultiplier = "0.095";
   StunMultiplier = "0";

   AgilityNeed = 30.0;
   StrengthNeed = 30.0;
   MaxAccuracy = 1.2;
   Emax = 28.0;
   BasePrefireAnimTime = 0.5;
   BaseRecoilAnimTime = 0.2;
   StaminaRate = 50.0;

   attackType = AttackThrowing;
   WeaponType = WeaponThrowing;

   // ArrowData datablock connected to throwing weapon
   projectileData = "ThrowingAxeProjectile";
};

datablock ExplosiveData(PotExplosion)
{
   id = 664;
   rayNum = 3; // number of vectors per dimension. total number is rayNum^3
   radius = 3;
   hitGroupType[0] = Siege;
   hitGroupDmgLevel[0] = 3.35;
   emitters[0] = Explosion_fire_small;
   emitters[1] = Explosion_smoke_small;
   emitters[2] = Explosion_elements_of_dirt_small;
   emittersDuration[0] = 4.0;
   emittersDuration[1] = 4.0;
   emittersDuration[2] = 4.0;
   SoundID = 101;
};

datablock ArrowData(ThrowingPotProjectile)
{
   id = 346;
   // ArrowData:
   sound = "ThrowingFlySound";
   stuckArrowLifeTime = 10;
   projectileShape = "art/models/3d-2d/weapons/ammunition/grenade.dts";
   upForce = 0.0;
   Friction = 0.25;
   // ShapeBaseImageData:
   shapeFile = "art/models/3d-2d/weapons/ammunition/sling_ammo_pouch.dts";
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";
   correctMuzzleVector = false;
   WeaponType = WeaponAmmo;
   explosionData = "PotExplosion";
};

datablock ThrowingWeaponData(ThrowingPot : BaseThrowing)
{
   id = 345;
   Object_typeID = 1104;
   shapeFile = "art/models/3d-2d/weapons/ammunition/grenade.dts";
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";
   hitGroupType[0] = Siege;
   hitGroupDmgLevel[0] = 0.1;
   WoundMultiplier = "0.06";
   FractureMultiplier = "0.095";
   StunMultiplier = "0";

   AgilityNeed = 30.0;
   StrengthNeed = 40.0;
   MaxAccuracy = 1.5;
   Emax = 25.0;
   BasePrefireAnimTime = 0.5;
   BaseRecoilAnimTime = 0.2;
   StaminaRate = 40.0;

   attackType = AttackThrowing;
   WeaponType = WeaponThrowing;

   // ArrowData datablock connected to throwing weapon
   projectileData = "ThrowingPotProjectile";
};

datablock ExplosiveData(FireworkPotExplosion)
{
   id = 665;
   rayNum = 4;
   radius = 3;
   hitGroupType[0] = Siege;
   hitGroupDmgLevel[0] = 0.1;
   emitters[0] = spark_star;
   emitters[1] = Explosion_elements_of_dirt_small;
   emittersDuration[0] = 4.0;
   emittersDuration[1] = 4.0;
   SoundID = 101;
};

datablock ArrowData(FireworkPotProjectile)
{
   id = 592;
   // ArrowData:
   sound = "ThrowingFlySound";
   stuckArrowLifeTime = 10;
   projectileShape = "art/models/3d-2d/weapons/ammunition/grenade.dts";
   upForce = 0.0;
   Friction = 0.25;
   // ShapeBaseImageData:
   shapeFile = "art/models/3d-2d/weapons/ammunition/sling_ammo_pouch.dts";
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";
   correctMuzzleVector = false;
   WeaponType = WeaponAmmo;
   explosionData = "FireworkPotExplosion";
};

datablock ThrowingWeaponData(FireworkPot : BaseThrowing)
{
   id = 591;
   Object_typeID = 1341;
   shapeFile = "art/models/3d-2d/weapons/ammunition/grenade.dts";
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";
   hitGroupType[0] = Siege;
   hitGroupDmgLevel[0] = 0.1;
   WoundMultiplier = "0.06";
   FractureMultiplier = "0.095";
   StunMultiplier = "0";

   AgilityNeed = 10.0;
   StrengthNeed = 10.0;
   MaxAccuracy = 1.0;
   Emax = 25.0;
   BasePrefireAnimTime = 0.5;
   BaseRecoilAnimTime = 0.2;
   StaminaRate = 40.0;

   attackType = AttackThrowing;
   WeaponType = WeaponThrowing;

   // ArrowData datablock connected to throwing weapon
   projectileData = "FireworkPotProjectile";
};

datablock ExplosiveData(SnowballExplosion)
{
   id = 666;
   rayNum = 2;
   radius = 1;
   hitGroupType[0] = blunt;
   hitGroupDmgLevel[0] = 0.01;
   emitters[0] = snowball_dust;
   emitters[1] = snowball_element;
   emittersDuration[0] = 4.0;
   emittersDuration[1] = 4.0;
};

datablock ArrowData(SnowballProjectile)
{
   id = 369;
   // ArrowData:
   sound = "ThrowingFlySound";
   stuckArrowLifeTime = 10;
   projectileShape = "art/models/3d-2d/weapons/ammunition/snowball.dts";
   upForce = 0.0;
   Friction = 0.25;
   // ShapeBaseImageData:
   shapeFile = "art/models/3d-2d/weapons/ammunition/sling_ammo_pouch.dts";
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";
   correctMuzzleVector = false;
   WeaponType = WeaponAmmo;
   explosionData = "SnowballExplosion";
};

datablock ThrowingWeaponData(Snowball : BaseThrowing)
{
   id = 368;
   Object_typeID = 1344;
   shapeFile = "art/models/3d-2d/weapons/ammunition/snowball.dts";
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";
   hitGroupType[0] = blunt;
   hitGroupDmgLevel[0] = 0.1;
   WoundMultiplier = "0.06";
   FractureMultiplier = "0.095";
   StunMultiplier = "0";

   AgilityNeed = 10.0;
   StrengthNeed = 10.0;
   MaxAccuracy = 1.2;
   Emax = 25.0;
   BasePrefireAnimTime = 0.5;
   BaseRecoilAnimTime = 0.2;
   StaminaRate = 40.0;

   attackType = AttackThrowing;
   WeaponType = WeaponThrowing;

   // ArrowData datablock connected to throwing weapon
   projectileData = "SnowballProjectile";
};
