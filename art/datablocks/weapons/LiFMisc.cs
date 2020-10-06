//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

// т.к. бомбы у нас - Movable_Object, а дата-блоки для них генерируются автоматом,
// то мы не можем в дата-блоке указать напрямую Object_typeID
// поэтому для разных бомб дата-блоки будут указываться по след. образцу - ExplosionBomb_ид_типа_бомбы
// в коде поиск датаблока будет осуществляться по этому шаблону

datablock ExplosiveData(ExplosionBomb_1151)
{
	id = 347;
	rayNum = 4;
	radius = 20;
	explosionMultiplier = 320;
	hitGroupType[0] = Siege;
	hitGroupDmgLevel[0] = 20;
	emitters[0] = Explosion_fire;
	emitters[1] = Explosion_smoke;
	emitters[2] = Explosion_elements_of_dirt;
	emittersDuration[0] = 4.0;
	emittersDuration[1] = 4.0;
	emittersDuration[2] = 4.0;
	SoundID = 102;
};

datablock WeaponData(DefaultWeaponData)
{
	id = 642;
};

datablock WeaponData(AnimalTrapData)
{
	id = 637;
	Object_typeID = 1080;

	hitGroupType[0] = Slashing;
	hitGroupDmgLevel[0] = 30;
};
