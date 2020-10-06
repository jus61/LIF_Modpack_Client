//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

// Load up all datablocks.  This function is called when
// a server is constructed.

exec("./environment.cs");
exec("./triggers.cs");

// до оружия, так как в стрелах есть ссылка на звук.
exec("./audioProfiles.cs");
// до оружия, так как факел - это оружие, а ему нужны партиклы
exec("./particles.cs");
// Load the weapon datablocks
exec("art/datablocks/weapons/LiFWeapons.cs");
exec("art/datablocks/weapons/LiFArrows.cs");
exec("art/datablocks/weapons/LiFRanged.cs");
exec("art/datablocks/weapons/LiFThrowing.cs");
exec("art/datablocks/weapons/LiFSiege.cs");
exec("art/datablocks/weapons/LiFMisc.cs");

// Load the default player datablocks
exec("./player.cs");
exec("./defaultHorse.cs");
exec("./harnessedHorse.cs");

//animals {
exec("./animals.cs");
//} animals

exec("./npc/npc.cs");

exec("./log.cs");

// managed particles data
exec("./managedParticleData.cs");
exec("./managedParticleEmitterData.cs");
   
exec("./audioAmbiences.cs");

exec("art/datablocks/Transport.cs");

// formations
exec("art/datablocks/Formations.cs");