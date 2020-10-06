//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

// ----------------------------------------------------------------------------
// Weapon Item. This is the item that exists in the world,
// i.e. when it's been dropped, thrown or is acting as re-spawnable item.
// When the weapon is mounted onto a shape, the Image is used.
// ----------------------------------------------------------------------------

datablock ShapeBaseImageData(SwordImage)
{
id = 605; //CM_REV
   // Basic Item properties
   
//dronimal
//   //shapefile = "art/shapes/weapons/1handed/fa_swd.dts";
   shapefile = "art/shapes/weapons/grossmesser/messer.dts";
//   shapefile = "art/shapes/weapons/grossmesser/pike.dts";
//   shapefile = "art/shapes/weapons/1-2hswords/estoc/estoc_export_01.dts";
//////////
   
   emap = true;

   // Specify mount point & offset for 3rd person, and eye offset
   // for first person rendering.
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0"; // 0.25=right/left 0.5=forward/backward, -0.5=up/down
   //eyeRotation = ???

   //attacksTypes:
   // 0 : one hand sword
   // 1 : two hand sword
   attacksType = 0;
   
   hitGroupType[0] = Slashing; //SlashingHitNodeType;
//   hitGroupDmgLevel[0] = 1.5;
   
   hitGroupType[1] = Piercing; //PiercingHitNodeType;
//   hitGroupDmgLevel[1] = 2.2;
   
   hitDirection[0] = "1"; // ForwardHit
   hitDirection[1] = "0"; // UpToDownHit
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   
   //autoChangeFireTimeout = true;
   
   // When firing from a point offset from the eye, muzzle correction
   // will adjust the muzzle vector to point to the eye LOS point.
   // Since this weapon doesn't actually fire from the muzzle point,
   // we need to turn this off.
   correctMuzzleVector = false;

   // Add the WeaponImage namespace as a parent, WeaponImage namespace
   // provides some hooks into the inventory system.
   className = "WeaponImage";

   // Projectile && Ammo.
   item = SwordWeapon;

   // Images have a state system which controls how the animations
   // are run, which sounds are played, script callbacks, etc. This
   // state system is downloaded to the client so that clients can
   // predict state changes and animate accordingly. The following
   // system supports basic ready->fire->reload transitions as
   // well as a no-ammo->dryfire idle state.

   // Ready to hit, just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";

   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";

   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;

   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
	 
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";

   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
	 
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";

   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;

   // After hit, wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 1.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
	 
   // After hit, wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
	 
	 // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   
   class = "WeaponImage";
};
