//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

datablock SiegeWeaponStaticShapeData(TrebuchetData)
{
   id = 340;
   Object_typeID = 163;

   shapefile = "art/models/3d/construction/combatrelated/smalltrebuchet/smalltrebuchet.dts";

   MaxAccuracy = 2.5;
   Emax = 2200.0;
   BasePrefireAnimTime = 1.0;
   BaseRecoilAnimTime = 2.0;
   IntNeed = 50.0;
   DurabilityPerShot = 100.0;
};

datablock WeaponData(SiegeStoneAmmoLoaded)
{
	id = 342;
	shapeFile = "art/models/3d-2d/weapons/ammunition/whizbang_stone.dts";// стрела одиночная
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	hitGroupType[0] = Siege;
	hitGroupDmgLevel[0] = 1.2;
	hitDirection[0] = ""; // Thrust
	hitDirection[1] = ""; // Overhead
	hitDirection[2] = ""; // RightToLeftHit
	hitDirection[3] = ""; // LeftToRightHit
	WoundMultiplier = "0";
	FractureMultiplier = "1";
	StunMultiplier = "1";
};

datablock ExplosiveData(SiegeStoneExplosion)
{
	id = 660;
	emitters[0] = Explosion_elements_of_dirt;
	emittersDuration[0] = 3.0;
};

datablock ArrowData(SiegeStoneAmmo) 
{
	// BaseData:
	id = 341;
	// ArrowData:
	sound = "SiegeFlySound";
	stuckArrowLifeTime = 5;
	projectileShape = "art/models/3d-2d/weapons/ammunition/whizbang_stone.dts";
	upForce = 0.0;
	Friction = 0.01;
	// ShapeBaseImageData:
	Object_typeID = 1107;
	shapeFile = "art/models/3d-2d/weapons/ammunition/whizbang_stone.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	loadedAmmo = "SiegeStoneAmmoLoaded";
	explosionData = "SiegeStoneExplosion";
};

// бочка метательная осадная
datablock WeaponData(BarrelAmmoLoaded)
{
	id = 344;
	shapeFile = "art/models/3d-2d/weapons/ammunition/whizbang_barrel.dts";// стрела одиночная
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	hitGroupType[0] = Siege;
	hitGroupDmgLevel[0] = 0.6;
	hitDirection[0] = ""; // Thrust
	hitDirection[1] = ""; // Overhead
	hitDirection[2] = ""; // RightToLeftHit
	hitDirection[3] = ""; // LeftToRightHit
	WoundMultiplier = "0";
	FractureMultiplier = "1";
	StunMultiplier = "1";
	permanentEmitterNode[0] = "hitpoint0n0";
	permanentEmitter[0] = big_weapon_smoke;
};

datablock ExplosiveData(BarrelExplosion)
{
	id = 661;
	rayNum = 4;
	radius = 5;
	hitGroupType[0] = Siege;
	hitGroupDmgLevel[0] = 10;
	emitters[0] = Explosion_fire;
	emitters[1] = Explosion_smoke;
	emitters[2] = Explosion_elements_of_dirt;
	emittersDuration[0] = 4.0;
	emittersDuration[1] = 4.0;
	emittersDuration[2] = 4.0;
	SoundID = 102;
};

datablock ArrowData(BarrelAmmo) 
{
	// BaseData:
	id = 343;
	// ArrowData:
	sound = "SiegeFlySound";
	stuckArrowLifeTime = 10;
	projectileShape = "art/models/3d-2d/weapons/ammunition/whizbang_barrel.dts";
	upForce = 0.0;
	Friction = 0.01;
	// ShapeBaseImageData:
	Object_typeID = 1106;
	shapeFile = "art/models/3d-2d/weapons/ammunition/whizbang_barrel.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	loadedAmmo = "BarrelAmmoLoaded";
	explosionData = "BarrelExplosion";
};

//бочка метательная противопехотная
datablock WeaponData(NapthaBarrelAmmoLoaded)
{
	id = 364;
	shapeFile = "art/models/3d-2d/weapons/ammunition/whizbang_barrel.dts";// стрела одиночная
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	hitGroupType[0] = Siege;
	hitGroupDmgLevel[0] = 0.3;
	hitDirection[0] = ""; // Thrust
	hitDirection[1] = ""; // Overhead
	hitDirection[2] = ""; // RightToLeftHit
	hitDirection[3] = ""; // LeftToRightHit
	WoundMultiplier = "0";
	FractureMultiplier = "1";
	StunMultiplier = "1";
	permanentEmitterNode[0] = "hitpoint0n0";
	permanentEmitter[0] = big_weapon_smoke;
};

datablock ExplosiveData(NapthaBarrelExplosion)
{
	id = 662;
	rayNum = 8;
	radius = 12;
	hitGroupType[0] = Siege;
	hitGroupDmgLevel[0] = 8;
	emitters[0] = Explosion_fire;
	emitters[1] = Explosion_smoke;
	emitters[2] = Explosion_elements_of_dirt;
	emittersDuration[0] = 4.0;
	emittersDuration[1] = 4.0;
	emittersDuration[2] = 4.0;
	SoundID = 102;
};

datablock ArrowData(NapthaBarrelAmmo) 
{
	// BaseData:
	id = 363;
	// ArrowData:
	sound = "SiegeFlySound";
	stuckArrowLifeTime = 10;
	projectileShape = "art/models/3d-2d/weapons/ammunition/whizbang_barrel.dts";
	upForce = 0.0;
	Friction = 0.01;
	// ShapeBaseImageData:
	Object_typeID = 1123;
	shapeFile = "art/models/3d-2d/weapons/ammunition/whizbang_barrel.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	loadedAmmo = "NapthaBarrelAmmoLoaded";
	explosionData = "NapthaBarrelExplosion";
};

datablock WeaponData(CowAmmoLoaded)
{
	id = 367;
	shapeFile = "art/models/3d-2d/weapons/ammunition/whizbangcow.dts";// стрела одиночная
	mountPoint = 2;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	hitGroupType[0] = Siege;
	hitGroupDmgLevel[0] = 0.01;
	hitDirection[0] = ""; // Thrust
	hitDirection[1] = ""; // Overhead
	hitDirection[2] = ""; // RightToLeftHit
	hitDirection[3] = ""; // LeftToRightHit
	WoundMultiplier = "0";
	FractureMultiplier = "1";
	StunMultiplier = "1";
};

datablock ExplosiveData(CowExplosion)
{
	id = 663;
	rayNum = 2;
	radius = 10;
	hitGroupType[0] = Blunt;
	hitGroupDmgLevel[0] = 0.01;
	emitters[0] = cow_blood;
	emitters[1] = cow_dust;
	emitters[2] = cow_meat_element;
	emittersDuration[0] = 4.0;
	emittersDuration[1] = 4.0;
	emittersDuration[2] = 4.0;
	SoundID = 102;
};

datablock ArrowData(CowAmmo) 
{
	// BaseData:
	id = 366;
	// ArrowData:
	sound = "AurochsDeathSound";
	stuckArrowLifeTime = 10;
	projectileShape = "art/models/3d-2d/weapons/ammunition/whizbangcow.dts";
	upForce = 0.0;
	Friction = 0.01;
	// ShapeBaseImageData:
	Object_typeID = 1046;
	shapeFile = "art/models/3d-2d/weapons/ammunition/whizbangcow.dts";
	mountPoint = 2;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	loadedAmmo = "CowAmmoLoaded";
	explosionData = "CowExplosion";
};
