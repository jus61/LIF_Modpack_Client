//Furnace
   //Дым от furnace
datablock ParticleEmitterData(Furnace_smoke)
{
   id = 493;
   ejectionPeriodMS = "80";
   ejectionVelocity = "0.15";
   velocityVariance = "0.05";
   ejectionOffset = "0.2";
   thetaMax = "40";
   softnessDistance = "10";
   particles = "Furnace_smoke_particle";
   blendStyle = "NORMAL";
   softParticles = "1";
   noiseStrength = "35";
   periodVarianceMS = "20";
   ambientFactor = "0.9";
};

   //Искры от furnace
datablock ParticleEmitterData(Furnace_sparks)
{
   id = 494;
   ejectionPeriodMS = "50";
   ejectionVelocity = "1";
   velocityVariance = "0.2";
   ejectionOffset = "0.2";
   thetaMax = "40";
   softnessDistance = "1000";
   particles = "Furnace_sparks_particle";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   periodVarianceMS = "30";
   noiseStrength = "100";
   ambientFactor = "0";
};

//Костёр. Здесь содержится 2 костра — camprfire и для кухни. Различия только в выборе дыма
   //Огонь для костра
datablock ParticleEmitterData(Campfire)
{
   id = 496;
   ejectionPeriodMS = "60";
   periodVarianceMS = "40";
   ejectionVelocity = "0.1";
   velocityVariance = "0.05";
   thetaMax = "30";
   phiVariance = "90";
   particles = "Campfire_particle";
   blendStyle = "ADDITIVE";
   randomArea = "0 0 0";
   noiseStrength = "10";
   phiVariance = "90";
   softParticles = "0";
   ejectionOffsetVariance = "0.15";
   ejectionOffset = "0.5";
   originalName = "Campfire";
   ambientFactor = "0";
};

   //Дым для campfire
datablock ParticleEmitterData(Campfire_big_smoke)
{
   id = 495;
   ejectionPeriodMS = "18";
   ejectionVelocity = "0.6";
   velocityVariance = "0.1";
   ejectionOffset = "1.5";
   thetaMax = "28";
   softnessDistance = "1";
   particles = "Campfire_big_smoke_particle";
   blendStyle = "NORMAL";
   softParticles = "0";
   randomArea = "0 0 0";
   phiVariance = "90";
   noiseStrength = "0";
   ejectionOffsetVariance = "0.4";
   periodVarianceMS = "10";
   ambientFactor = "0.88";
};

   //Дым для кухни
datablock ParticleEmitterData(Campfire_smoke)
{
   id = 497;
   ejectionPeriodMS = "18";
   ejectionVelocity = "0.3";
   velocityVariance = "0.2";
   ejectionOffset = "0.5";
   thetaMax = "60";
   softnessDistance = "1";
   particles = "Campfire_smoke_particle";
   blendStyle = "NORMAL";
   softParticles = "0";
   randomArea = "0 0 0";
   phiVariance = "90";
   phiVariance = "90";
   noiseStrength = "100";
   ejectionOffsetVariance = "0.4";
   periodVarianceMS = "15";
   ambientFactor = "0.88";
   originalName = "Campfire_smoke";
};

   //Искры для костра
datablock ParticleEmitterData(Campfire_sparks)
{
   id = 498;
   ejectionPeriodMS = "50";
   ejectionVelocity = "1";
   velocityVariance = "0.7";
   ejectionOffset = "0.4";
   thetaMax = "30";
   softnessDistance = "1";
   particles = "Campfire_sparks_particle";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   scale = "1 1.7";
   noiseStrength = "1000";
   ejectionOffsetVariance = "0.2";
   periodVarianceMS = "30";
   ambientFactor = "0";
};

//Кузнечная печь
   //Огонь для кузнечной печи
datablock ParticleEmitterData(Stove_fire)
{
   id = 405;
   particles = "Stove_fire_particle";
   ejectionPeriodMS = "4000";
   ejectionVelocity = "0";
   velocityVariance = "0";
   ejectionOffset = "0";
   thetaMax = "180";
   softnessDistance = "0.2";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   randomArea = "0 0 0";
   ejectionOffsetVariance = "0";
   periodVarianceMS = "0";
   lifetimeMS = "0";
   lifetimeVarianceMS = "0";
   noiseStrength = "0";
   originalName = "Stove_fire";
   ambientFactor = "0";
};

datablock ParticleEmitterData(Halloween_Trophy_fire)
{
   id = 609;
   ejectionPeriodMS = "400";
   ejectionVelocity = "0.08";
   velocityVariance = "0.02";
   ejectionOffset = "0.05";
   thetaMax = "90";
   softnessDistance = "10";
   particles = "Halloween_Trophy_fire_particle";
   blendStyle = "NORMAL";
   phiVariance = "180";
   phiVariance = "0";
   softParticles = "1";
   ejectionOffsetVariance = ".2";
   ambientFactor = "0";
};

  //Дым для кузнечной печи (разместить желательно в отверстие трубы)
datablock ParticleEmitterData(Stove_smoke)
{
   id = 406;
   particles = "Stove_smoke_particle";
   ejectionPeriodMS = "20";
   ejectionVelocity = "0.7";
   velocityVariance = "0.3";
   ejectionOffset = "1";
   thetaMax = "50";
   softnessDistance = "1";
   blendStyle = "NORMAL";
   softParticles = "0";
   randomArea = "0.57735 0.57735 0.57735";
   ejectionOffsetVariance = ".6";
   periodVarianceMS = "10";
   lifetimeMS = "0";
   lifetimeVarianceMS = "0";
   noiseStrength = "1";
   phiVariance = "45";
   phiVariance = "45";
   ambientFactor = "0.88";
};

   //Искры для кузнечной печи
datablock ParticleEmitterData(Stove_sparks)
{
   id = 407;
   ejectionPeriodMS = "50";
   ejectionVelocity = "2";
   velocityVariance = "0";
   ejectionOffset = "0.1";
   thetaMax = "180";
   softnessDistance = "1";
   particles = "Stove_sparks_particle";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   lifetimeMS = "0";
   noiseStrength = "100";
   periodVarianceMS = "30";
   randomArea = "0.707107 0.707107 0";
   phiVariance = "360";
   phiVariance = "80";
   ejectionOffsetVariance = "0.05";
   thetaMin = "50";
   ambientFactor = "0";
};

//Падающее дерево (срубили и упало!)
   //Пыль при падении дерева
datablock ParticleEmitterData(Dust_by_falling_tree)
{
   id = 480;
   ejectionPeriodMS = "20";
   ejectionVelocity = "0.1";
   velocityVariance = "0.1";
   ejectionOffset = "2";
   thetaMax = "130";
   softnessDistance = "0";
   particles = "Dust_by_falling_tree_particle";
   blendStyle = "NORMAL";
   softParticles = "0";
   randomArea = "1 0 0";
   ejectionOffsetVariance = ".6";
   periodVarianceMS = "14";
   noiseStrength = "25";
   lifetimeMS = "1600";
   lifetimeVarianceMS = "800";
   ambientFactor = "0.88";
};
   //Листья при падении дерева
datablock ParticleEmitterData(Leaves_by_falling_tree)
{
   id = 479;
   ejectionPeriodMS = "20";
   ejectionVelocity = "0.9";
   velocityVariance = "0.45";
   ejectionOffset = "2";
   thetaMax = "40";
   softnessDistance = "1";
   particles = "Leaves_by_falling_tree_particle";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   scale = "1 0.5";
   ejectionOffsetVariance = "0.1";
   periodVarianceMS = "10";
   noiseStrength = "700";
   lifetimeMS = "1400";
   lifetimeVarianceMS = "850";
   thetaMin = "0";
   phiVariance = "180";
   randomArea = "0.57735 0.57735 0.57735";
   phiVariance = "180";
   ambientFactor = "0.85";
};

//Срезание растений
   //Травинки при срезании растений
datablock ParticleEmitterData(Grass_by_cut_plants)
{
   id = 499;
   ejectionPeriodMS = "40";
   ejectionVelocity = "0.1";
   velocityVariance = "0.05";
   ejectionOffset = "0.2";
   thetaMax = "80";
   softnessDistance = "1";
   particles = "Grass_by_cut_plants_particle";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   scale = "1 0.25";
   ejectionOffsetVariance = "0.2";
   lifetimeMS = "200";
   noiseStrength = "400";
   periodVarianceMS = "25";
   lifetimeVarianceMS = "0";
   thetaMin = "50";
   ambientFactor = "0.7";
};

   //Листья при срезании растений
datablock ParticleEmitterData(Leaves_by_cut_plants)
{
   id = 501;
   ejectionPeriodMS = "40";
   ejectionVelocity = "0.1";
   velocityVariance = "0.05";
   ejectionOffset = "0.2";
   thetaMax = "80";
   softnessDistance = "1";
   particles = "Leaves_by_cut_plants_particle";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   scale = "1 0.5";
   ejectionOffsetVariance = "0.2";
   lifetimeMS = "100";
   noiseStrength = "700";
   periodVarianceMS = "25";
   lifetimeVarianceMS = "70";
   thetaMin = "50";
   ambientFactor = "1";
};

//Туннельный эффект
   //Пыль, осыпающаяся с потолка туннеля
datablock ParticleEmitterData(Dust_for_tunnel)
{
   id = 410;
   ejectionPeriodMS = "10";
   ejectionVelocity = "2";
   velocityVariance = "0";
   ejectionOffset = "2";
   thetaMax = "180";
   softnessDistance = "1000";
   particles = "Dust_for_tunnel_particle";
   blendStyle = "NORMAL";
   softParticles = "0";
   randomArea = "0.707107 0.707107 0";
   lifetimeMS = "1500";
   lifetimeVarianceMS = "650";
   periodVarianceMS = "7";
   ejectionOffsetVariance = "1";
   noiseStrength = "100";
   ambientFactor = "0.8";
};

   //Куски земли, осыпающиеся с потолка туннеля
datablock ParticleEmitterData(Dust_for_tunnel_elements)
{
   id = 411;
   ejectionPeriodMS = "10";
   ejectionVelocity = "2";
   velocityVariance = "2";
   ejectionOffset = "3";
   thetaMax = "90";
   softnessDistance = "1";
   particles = "Dust_for_tunnel_elements_particle";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   thetaMin = "50";
   randomArea = "0.57735 0.57735 0.57735";
   noiseStrength = "100";
   ejectionOffsetVariance = "2";
   lifetimeMS = "1500";
   periodVarianceMS = "4";
   lifetimeVarianceMS = "600";
   ambientFactor = "0.6";
};

//Осыпание почвы (копание лопатой)
   //Пыль при осыпании почвы
datablock ParticleEmitterData(Dust_from_digging)
{
   id = 414;
   ejectionPeriodMS = "25";
   ejectionVelocity = "0.8";
   velocityVariance = "0.6";
   ejectionOffset = "2";
   thetaMax = "180";
   softnessDistance = "0.3";
   particles = "Dust_from_digging_particle";
   blendStyle = "NORMAL";
   softParticles = "1";
   ejectionOffsetVariance = "1.5";
   lifetimeMS = "2000";
   noiseStrength = "15";
   randomArea = "0.57735 0.57735 0.57735";
   periodVarianceMS = "15";
   lifetimeVarianceMS = "1000";
};
   //Куски земли, осыпающиеся при копании
datablock ParticleEmitterData(Dust_from_digging_elements)
{
   id = 415;
   ejectionPeriodMS = "50";
   ejectionVelocity = "2";
   velocityVariance = "0.7";
   ejectionOffset = "0.2";
   thetaMax = "180";
   softnessDistance = "1";
   particles = "Dust_from_digging_elements_particle";
   blendStyle = "PREMULTALPHA";
   softParticles = "1";
   randomArea = "2 2 0";
   noiseStrength = "150";
   ejectionOffsetVariance = "0.15";
   lifetimeMS = "0";
   lifetimeVarianceMS = "0";
   periodVarianceMS = "10";
};

//Пыль от копыт животного
datablock ParticleEmitterData(Dust_from_walk_horse)
{
   id = 417;
   ejectionPeriodMS = "250";
   ejectionVelocity = "0.8";
   velocityVariance = "0.15";
   ejectionOffset = "0.6";
   thetaMax = "80";
   softnessDistance = "1";
   particles = "Dust_from_walk_horse_particle";
   blendStyle = "NORMAL";
   softParticles = "0";
   randomArea = "0.57735 0.57735 0.57735";
   ejectionOffsetVariance = ".4";
   periodVarianceMS = "80";
   lifetimeMS = "3200";
   lifetimeVarianceMS = "800";
   noiseStrength = "100";
   ambientFactor = "0.85";
};

//Пыль от шагов человека
datablock ParticleEmitterData(Dust_from_walk_human)
{
   id = 419;
   ejectionPeriodMS = "110";
   ejectionVelocity = "0.12";
   velocityVariance = "0.04";
   ejectionOffset = "0.2";
   thetaMax = "80";
   softnessDistance = "1";
   particles = "Dust_from_walk_human_particle";
   blendStyle = "NORMAL";
   softParticles = "0";
   ejectionOffsetVariance = ".15";
   lifetimeMS = "3200";
   randomArea = "0.01 0.01 0";
   noiseStrength = "100";
   periodVarianceMS = "80";
   ambientFactor = "0.8";
};

//Летающие пылинки вокруг фонаря
datablock ParticleEmitterData(Motes)
{
   id = 421;
   ejectionPeriodMS = "15";
   ejectionVelocity = "2";
   velocityVariance = "0.9";
   ejectionOffset = "0.2";
   thetaMax = "120";
   softnessDistance = "1000";
   particles = "Motes_particle";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   noiseStrength = "1000";
   ejectionOffsetVariance = "0.15";
   thetaMin = "33.75";
   phiVariance = "360";
   phiVariance = "180";
   scale = "1 0.6";
   periodVarianceMS = "10";
   ambientFactor = "0";
};

//Пыль при ударе чем-нибудь по любой неметаллической поверхности
datablock ParticleEmitterData(Dust_from_blow)
{
   id = 423;
   ejectionPeriodMS = "1000";
   ejectionVelocity = "0.15";
   velocityVariance = "0.05";
   ejectionOffset = "0";
   thetaMax = "90";
   softnessDistance = "1000";
   particles = "Dust_from_blow_particle";
   blendStyle = "NORMAL";
   softParticles = "0";
   lifetimeMS = "1";
   noiseStrength = "1000";
   thetaMin = "27";
   ambientFactor = "0.6";
};

//Универсальная пыль. Добавляется к: «щепки при рубке дерева», «опилки при распиливании досок», «осколки породы при ударе киркой»
datablock ParticleEmitterData(Universal_dust)
{
   id = 425;
   ejectionPeriodMS = "60";
   ejectionVelocity = "0.5";
   velocityVariance = "0.3";
   ejectionOffset = "0.1";
   thetaMax = "180";
   softnessDistance = "1";
   particles = "Universal_dust_particle";
   blendStyle = "NORMAL";
   softParticles = "0";
   lifetimeMS = "200";
   ejectionOffsetVariance = "0";
   noiseStrength = "1000";
   ambientFactor = "0.75";
};

//Щепки при рубке дерева»
datablock ParticleEmitterData(Sawdust)
{
   id = 427;
   particles = "Sawdust_particle";
   ejectionPeriodMS = "10";
   periodVarianceMS = "9";
   ejectionVelocity = "0.4";
   velocityVariance = "0.2";
   phiVariance = "360";
   blendStyle = "PREMULTALPHA";
   softnessDistance = "1";
   softParticles = "0";
   thetaMin = "15";
   thetaMax = "90";
   ejectionOffset = "0.3";
   lifetimeMS = "80";
   ambientFactor = "0.92";
   lifetimeVarianceMS = "60";
   noiseStrength = "200";
   ejectionOffsetVariance = "0.15";
   scale = "1 0.5";
   ambientFactor = "1";
};

//Опилки при распиливании досок
datablock ParticleEmitterData(Scobs)
{
   id = 429;
   particles = "Scobs_particle";
   ejectionPeriodMS = "1";
   periodVarianceMS = "0";
   ejectionVelocity = "0.02";
   velocityVariance = "0.005";
   phiVariance = "360";
   blendStyle = "PREMULTALPHA";
   softnessDistance = "1";
   softParticles = "0";
   thetaMin = "0";
   thetaMax = "90";
   ejectionOffset = "0.1";
   lifetimeMS = "30";
   ambientFactor = "0.5";
   lifetimeVarianceMS = "0";
   noiseStrength = "12";
   ejectionOffsetVariance = "0.03";
   ambientFactor = "1";
};

//Осколки породы при ударе киркой
datablock ParticleEmitterData(Stone_fragments)
{
   id = 431;
   particles = "Stone_fragments_particle";
   ejectionPeriodMS = "40";
   periodVarianceMS = "14";
   ejectionVelocity = "0.2";
   velocityVariance = "0.1";
   phiVariance = "360";
   blendStyle = "PREMULTALPHA";
   softnessDistance = "1";
   softParticles = "0";
   thetaMin = "0";
   thetaMax = "80";
   ejectionOffset = "0.1";
   lifetimeMS = "200";
   ambientFactor = "0.8";
   lifetimeVarianceMS = "50";
   ambientFactor = "1";
};

//Атмосферный эффект, состоящий из 2 элементов
   //Летающие листья в воздухе
datablock ParticleEmitterData(flying_leaves)
{
   id = 434;
   ejectionPeriodMS = "50";
   periodVarianceMS = "20";
   ejectionVelocity = "0.6";
   velocityVariance = "0.2";
   ejectionOffset = "40";
   thetaMin = "45";
   phiVariance = "45";
   softnessDistance = "1000";
   particles = "flying_leaves_particle";
   blendStyle = "PREMULTALPHA";
   randomArea = "1 1 1";
   noiseStrength = "450";
   phiVariance = "45";
   softParticles = "0";
   ejectionOffsetVariance = "20";
   scale = "1 0.5";
   ambientFactor = "0.75";
};

   //Летающая пыль в воздухе
datablock ParticleEmitterData(flying_dust)
{
   id = 435;
   ejectionPeriodMS = "30";
   ejectionVelocity = "0.2";
   velocityVariance = "0.2";
   ejectionOffset = "6";
   thetaMax = "90";
   softnessDistance = "1000";
   particles = "flying_dust_particle";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   scale = "1 1";
   randomArea = "1 1 1";
   noiseStrength = "300";
   phiVariance = "45";
   phiVariance = "45";
   ejectionOffsetVariance = "2";
   periodVarianceMS = "4";
   ambientFactor = "0.75";
};

//Кровь тестовая A
datablock ParticleEmitterData(blood_test_A)
{
   id = 437;
   ejectionPeriodMS = "1500";
   ejectionVelocity = "0";
   velocityVariance = "0";
   ejectionOffset = "0.2";
   thetaMax = "40";
   softnessDistance = "1";
   particles = "blood_test_A_particle";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   lifetimeMS = "1500";
   ambientFactor = "0.85";
};

//Кровь тестовая Б
datablock ParticleEmitterData(blood_test_B)
{
   id = 439;
   ejectionPeriodMS = "1000";
   ejectionVelocity = "0";
   velocityVariance = "0";
   ejectionOffset = "0.2";
   thetaMax = "40";
   softnessDistance = "1";
   particles = "blood_test_B_particle";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   lifetimeMS = "500";
   ambientFactor = "0.85";
};

//Земля и пыль из под плуга
   //Пыль из под плуга
datablock ParticleEmitterData(plough_dirt_elements)
{
   id = 443;
   ejectionPeriodMS = "25";
   ejectionVelocity = "2.3";
   velocityVariance = "0.3";
   ejectionOffset = "0.1";
   thetaMax = "80";
   softnessDistance = "1000";
   particles = "plough_dirt_elements_particle";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   ejectionOffsetVariance = "0.02";
   noiseStrength = "15";
   lifetimeMS = "0";
   lifetimeVarianceMS = "0";
   phiVariance = "180";
   phiVariance = "180";
   ambientFactor = "0.7";
};

   //Земля из под плуга 1
datablock ParticleEmitterData(plough_dirt_elements_2)
{
   id = 444;
   ejectionPeriodMS = "4";
   ejectionVelocity = "1";
   velocityVariance = "0.05";
   ejectionOffset = "0.2";
   thetaMax = "180";
   softnessDistance = "1000";
   particles = "plough_dirt_elements_particle_2";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   noiseStrength = "20";
   ejectionOffsetVariance = "0.1";
   lifetimeMS = "0";
   lifetimeVarianceMS = "0";
   phiVariance = "180";
   phiVariance = "180";
   ambientFactor = "0.8";
};

   //Земля из под плуга 2
datablock ParticleEmitterData(plough_dirt_elements_2)
{
   id = 445;
   ejectionPeriodMS = "4";
   ejectionVelocity = "1";
   velocityVariance = "0.05";
   ejectionOffset = "0.2";
   thetaMax = "180";
   softnessDistance = "1000";
   particles = "plough_dirt_elements_particle_2";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   noiseStrength = "20";
   ejectionOffsetVariance = "0.1";
   lifetimeMS = "0";
   lifetimeVarianceMS = "0";
   ambientFactor = "1";
};

//Сигнальный костёр
   //Огонь для сигнального костра
datablock ParticleEmitterData(Watchfire)
{
   id = 394;
   ejectionPeriodMS = "50";
   ejectionVelocity = "0.2";
   velocityVariance = "0.05";
   ejectionOffset = "0";
   thetaMax = "100";
   softnessDistance = "3";
   particles = "Watchfire_particle";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   periodVarianceMS = "19";
   randomArea = "0.57735 0.57735 0.57735";
   orientParticles = "0";
   alignDirection = "0 0 0";
   ejectionOffsetVariance = "0,2";
   noiseStrength = "25";
   phiVariance = "180";
   phiVariance = "180";
   ambientFactor = "0";
};

   //Дым для сигнального костра
datablock ParticleEmitterData(Watchfire_smoke)
{
   id = 395;
   particles = "Watchfire_smoke_particle";
   ejectionPeriodMS = "40";
   periodVarianceMS = "10";
   ejectionVelocity = "0.5";
   velocityVariance = "0.1";
   phiVariance = "20";
   blendStyle = "NORMAL";
   softnessDistance = "70";
   softParticles = "1";
   thetaMin = "0";
   thetaMax = "10";
   ejectionOffset = "0";
   ejectionOffsetVariance = "2";
   noiseStrength = "3";
   ambientFactor = "0.6";
};

   //Искры для сигнального костра
datablock ParticleEmitterData(Watchfire_sparks)
{
   id = 396;
   ejectionPeriodMS = "6";
   ejectionVelocity = "0.8";
   velocityVariance = "0.4";
   ejectionOffset = "2";
   thetaMax = "40";
   softnessDistance = "1";
   particles = "Watchfire_sparks_particle";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   lifetimeMS = "0";
   noiseStrength = "20";
   periodVarianceMS = "5";
   randomArea = "0.707107 0.707107 0";
   phiVariance = "80";
   phiVariance = "80";
   scale = "0.5 1";
   ejectionOffsetVariance = "2";
   orientParticles = "1";
   ambientFactor = "0";
};

//Огонь для мелких печей (BrawingTank)
datablock ParticleEmitterData(Stove_small_fire)
{
   id = 446;
   particles = "Stove_small_fire_particle";
   ejectionPeriodMS = "4000";
   ejectionVelocity = "0";
   velocityVariance = "0";
   ejectionOffset = "0";
   thetaMax = "180";
   softnessDistance = "1";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   randomArea = "0 0 0";
   ejectionOffsetVariance = "0";
   periodVarianceMS = "0";
   lifetimeMS = "0";
   lifetimeVarianceMS = "0";
   noiseStrength = "0";
   ambientFactor = "0";
};

//Эффект от взрыва коровы
   //Кровь от взрыва коровы
datablock ParticleEmitterData(cow_blood)
{
   id = 388;
   ejectionPeriodMS = "2000";
   ejectionVelocity = "0";
   velocityVariance = "0";
   ejectionOffset = "0";
   thetaMax = "180";
   softnessDistance = "1000";
   particles = "cow_blood_particle";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   lifetimeMS = "1000";
   ambientFactor = "0.92";
};

   //Пыль от взрыва коровы
datablock ParticleEmitterData(cow_meat_element)
{
   id = 389;
   ejectionPeriodMS = "100";
   ejectionVelocity = "1";
   velocityVariance = "0.7";
   ejectionOffset = "1";
   thetaMax = "90";
   softnessDistance = "1000";
   particles = "cow_meat_element_particle";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   lifetimeMS = "1000";
   ejectionOffsetVariance = "1";
   noiseStrength = "2";
   periodVarianceMS = "30";
   lifetimeVarianceMS = "0";
   ambientFactor = "0.88";
};

   //Куски мяса от взрыва коровы
datablock ParticleEmitterData(cow_meat_element)
{
   id = 390;
   ejectionPeriodMS = "100";
   ejectionVelocity = "1";
   velocityVariance = "0.7";
   ejectionOffset = "1";
   thetaMax = "90";
   softnessDistance = "1000";
   particles = "cow_meat_element_particle";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   ejectionOffsetVariance = "1";
   lifetimeMS = "1000";
   periodVarianceMS = "30";
   noiseStrength = "2";
   ambientFactor = "1";
};

//Эффект для снежка
	//Пыль при ударе снежком
datablock ParticleEmitterData(snowball_element)
{
   id = 382;
   ejectionPeriodMS = "15";
   ejectionVelocity = "0.9";
   velocityVariance = "0.5";
   ejectionOffset = "0.2";
   thetaMax = "180";
   softnessDistance = "1000";
   particles = "snowball_element_particle";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   periodVarianceMS = "5";
   phiVariance = "180";
   noiseStrength = "3";
   phiVariance = "180";
   ejectionOffsetVariance = "0.3";
   lifetimeMS = "200";
   ambientFactor = "0.9";
};

	//Отлетающие фрагменты снежка
datablock ParticleEmitterData(snowball_element)
{
   id = 383;
   ejectionPeriodMS = "15";
   ejectionVelocity = "0.9";
   velocityVariance = "0.5";
   ejectionOffset = "0.2";
   thetaMax = "180";
   softnessDistance = "1000";
   particles = "snowball_element_particle";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   ejectionOffsetVariance = "0.3";
   noiseStrength = "3";
   lifetimeMS = "200";
   periodVarianceMS = "5";
   ambientFactor = "1";
};

//Пожар для больших (по масштабу) построек
   //Огонь для пожара
datablock ParticleEmitterData(Conflagration_fire_big)
{
   id = 484;
   particles        = "Conflagration_fire_big_particle";
   ejectionPeriodMS = "150";
   ejectionVelocity = "0.4";
   velocityVariance = "0.05";
   ejectionOffset = "0.3";
   thetaMax = "100";
   softnessDistance = "3";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   periodVarianceMS = "35";
   randomArea = "0.57735 0.57735 0.57735";
   orientParticles = "0";
   alignDirection = "0 0 0";
   ejectionOffsetVariance = "0.5";
   noiseStrength = "4";
   phiVariance = "180";
   phiVariance = "180";
   ambientFactor = "0";
};

   //Дым для пожара
datablock ParticleEmitterData(Conflagration_smoke_big)
{
   id = 485;
   particles        = "Conflagration_smoke_big_particle";
   ejectionPeriodMS = "70";
   ejectionVelocity = "0.3";
   velocityVariance = "0.1";
   ejectionOffset = "5";
   thetaMax = "40";
   softnessDistance = "1";
   blendStyle = "NORMAL";
   softParticles = "0";
   noiseStrength = "50";
   periodVarianceMS = "1";
   phiVariance = "180";
   phiVariance = "180";
   ejectionOffsetVariance = "4";
   ambientFactor = "0.92";
};

   //Искры для пожара
datablock ParticleEmitterData(Conflagration_sparks_big)
{
   id = 486;
   ejectionPeriodMS = "27";
   ejectionVelocity = "3";
   velocityVariance = "2";
   ejectionOffset = "2";
   thetaMax = "40";
   softnessDistance = "1";
   particles = "Conflagration_sparks_big_particle";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   lifetimeMS = "0";
   noiseStrength = "150";
   periodVarianceMS = "8";
   randomArea = "0.707107 0.707107 0";
   phiVariance = "80";
   phiVariance = "80";
   scale = "0.5 1";
   ejectionOffsetVariance = "0";
   ambientFactor = "0";
};

//Пожар для средних (по масштабу) построек
   //Огонь для пожара
datablock ParticleEmitterData(Conflagration_fire_medium)
{
   id = 379;
   particles = "Conflagration_fire_medium_particle";
   ejectionPeriodMS = "150";
   ejectionVelocity = "0.2";
   velocityVariance = "0.08";
   ejectionOffset = "0.2";
   thetaMax = "100";
   softnessDistance = "3";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   periodVarianceMS = "35";
   randomArea = "0.57735 0.57735 0.57735";
   orientParticles = "0";
   alignDirection = "0 0 0";
   ejectionOffsetVariance = "0.5";
   noiseStrength = "2";
   phiVariance = "180";
   phiVariance = "180";
   ambientFactor = "0";
};

   //Дым для пожара
datablock ParticleEmitterData(Conflagration_smoke_medium)
{
   id = 380;
   particles = "Conflagration_smoke_medium_particle";
   ejectionPeriodMS = "70";
   ejectionVelocity = "0.3";
   velocityVariance = "0.1";
   ejectionOffset = "5";
   thetaMax = "40";
   softnessDistance = "1";
   blendStyle = "NORMAL";
   softParticles = "0";
   noiseStrength = "20";
   periodVarianceMS = "1";
   phiVariance = "180";
   phiVariance = "180";
   ejectionOffsetVariance = "4";
   ambientFactor = "0.92";
};

   //Искры для пожара
datablock ParticleEmitterData(Conflagration_sparks_medium)
{
   id = 381;
   ejectionPeriodMS = "40";
   ejectionVelocity = "2";
   velocityVariance = "1";
   ejectionOffset = "2";
   thetaMax = "40";
   softnessDistance = "1";
   particles = "Conflagration_sparks_medium_particle";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   lifetimeMS = "0";
   noiseStrength = "150";
   periodVarianceMS = "9";
   randomArea = "0.707107 0.707107 0";
   phiVariance = "80";
   phiVariance = "80";
   scale = "0.5 1";
   ejectionOffsetVariance = "0";
   ambientFactor = "0";
};

//Пожар для малых (по масштабу) построек
   //Огонь для пожара
datablock ParticleEmitterData(Conflagration_fire_small)
{
   id = 373;
   particles = "Conflagration_fire_small_particle";
   ejectionPeriodMS = "150";
   ejectionVelocity = "0.05";
   velocityVariance = "0.05";
   ejectionOffset = "0.05";
   thetaMax = "100";
   softnessDistance = "3";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   periodVarianceMS = "35";
   randomArea = "0.5 0.5 0.2";
   orientParticles = "0";
   alignDirection = "0 0 0";
   ejectionOffsetVariance = "0";
   noiseStrength = "2";
   phiVariance = "180";
   phiVariance = "180";
   ambientFactor = "0";
};

   //Дым для пожара
datablock ParticleEmitterData(Conflagration_smoke_small)
{
   id = 374;
   particles = "Conflagration_smoke_small_particle";
   ejectionPeriodMS = "70";
   ejectionVelocity = "0.2";
   velocityVariance = "0.1";
   ejectionOffset = "1.5";
   thetaMax = "40";
   softnessDistance = "1";
   blendStyle = "NORMAL";
   softParticles = "0";
   noiseStrength = "20";
   periodVarianceMS = "1";
   phiVariance = "180";
   phiVariance = "180";
   ejectionOffsetVariance = "0.8";
   ambientFactor = "0.92";
};

   //Искры для пожара
datablock ParticleEmitterData(Conflagration_sparks_small)
{
   id = 375;
   ejectionPeriodMS = "80";
   ejectionVelocity = "2";
   velocityVariance = "1";
   ejectionOffset = "2";
   thetaMax = "40";
   softnessDistance = "1";
   particles = "Conflagration_sparks_small_particle";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   lifetimeMS = "0";
   noiseStrength = "150";
   periodVarianceMS = "9";
   randomArea = "0.707107 0.707107 0";
   phiVariance = "80";
   phiVariance = "80";
   scale = "0.5 1";
   ejectionOffsetVariance = "0";
   ambientFactor = "0";
};

datablock ParticleEmitterData(PowderKeg_smoke1)
{
   id = 595;
   ejectionPeriodMS = "200";
   ejectionVelocity = "0.6";
   velocityVariance = "0.2";
   ejectionOffset = "0.05";
   thetaMax = "15";
   softnessDistance = "1000";
   particles = "PowderKeg_smoke1_particle";
   blendStyle = "NORMAL";
   softParticles = "0";
   periodVarianceMS = "50";
   noiseStrength = "1";
   ejectionOffsetVariance = "0.1";
   ambientFactor = "0.6";
};

datablock ParticleEmitterData(PowderKeg_smoke2)
{
   id = 596;
   ejectionPeriodMS = "50";
   ejectionVelocity = "0.5";
   velocityVariance = "0.5";
   ejectionOffset = "0.3";
   thetaMax = "30";
   softnessDistance = "1000";
   particles = "PowderKeg_smoke2_particle";
   blendStyle = "NORMAL";
   softParticles = "0";
   ejectionOffsetVariance = "0.2";
   ambientFactor = "0.85";
};

datablock ParticleEmitterData(PowderKeg_sparks)
{
   id = 597;
   ejectionPeriodMS = "30";
   ejectionVelocity = "2";
   velocityVariance = "0.3";
   ejectionOffset = "0.05";
   thetaMax = "180";
   softnessDistance = "1000";
   particles = "PowderKeg_sparks_particle";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   noiseStrength = "500";
   periodVarianceMS = "20";
   randomArea = "0 0 0";
   ejectionOffsetVariance = "0";
   ambientFactor = "0";
};

//Искры №1 при ударе о металлическую поверхность
datablock ParticleEmitterData(sparks1_from_blow_metal)
{
   id = 601;
   ejectionPeriodMS = "20";
   ejectionVelocity = "4";
   velocityVariance = "0.2";
   ejectionOffset = "0.02";
   thetaMax = "180";
   softnessDistance = "1000";
   particles = "sparks1_from_blow_metal_particle";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   lifetimeMS = "300";
   noiseStrength = "800";
   periodVarianceMS = "0";
   ejectionOffsetVariance = ".05";
   ambientFactor = "0";
};


//Искры №2 при ударе о металлическую поверхность
datablock ParticleEmitterData(sparks2_from_blow_metal)
{
   id = 602;
   ejectionPeriodMS = "10";
   ejectionVelocity = "2";
   velocityVariance = "0.3";
   ejectionOffset = "0.05";
   thetaMax = "180";
   softnessDistance = "1000";
   particles = "sparks2_from_blow_metal_particle";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   lifetimeMS = "100";
   noiseStrength = "8";
   ambientFactor = "0";
};

//Щепки №1 при ударе о неметаллическую поверхность
datablock ParticleEmitterData(flinders1_from_blow)
{
   id = 605;
   ejectionPeriodMS = "25";
   ejectionVelocity = "5";
   velocityVariance = "1";
   ejectionOffset = "0.15";
   thetaMax = "120";
   softnessDistance = "1000";
   particles = "flinders1_from_blow_particle";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   lifetimeMS = "200";
   noiseStrength = "50";
   lifetimeVarianceMS = "70";
   periodVarianceMS = "10";
   scale = "1 0.5";
   ambientFactor = "0.85";
};

//Щепки №2 при ударе о неметаллическую поверхность
datablock ParticleEmitterData(flinders2_from_blow)
{
   id = 606;
   ejectionPeriodMS = "15";
   ejectionVelocity = "5";
   velocityVariance = "1";
   ejectionOffset = "0.15";
   thetaMax = "120";
   softnessDistance = "1000";
   particles = "flinders2_from_blow_particle";
   blendStyle = "PREMULTALPHA";
   softParticles = "0";
   lifetimeMS = "200";
   noiseStrength = "50";
   periodVarianceMS = "5";
   ejectionOffsetVariance = ".2";
   lifetimeVarianceMS = "50";
   scale = "1 0.5";
   ambientFactor = "0.7";
};

datablock ParticleEmitterData(RevokingRitualSmokeEmitter)
{
   id = 179; //CM_REV
   particles = "RevokingRitualParticle";
   ejectionPeriodMS = "40";
   periodVarianceMS = "10";
   ejectionVelocity = "0.7";
   velocityVariance = "0.3";
   phiVariance = "20";
   blendStyle = "NORMAL";
   softnessDistance = "70";
   softParticles = "1";
   thetaMin = "0";
   thetaMax = "10";
   ejectionOffset = "0";
   ejectionOffsetVariance = "2";
   noiseStrength = "3";
   ambientFactor = "0.6";
};
