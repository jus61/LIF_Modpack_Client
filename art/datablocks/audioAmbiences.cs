//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton SFXState( AudioLocationOutside )
{
   local = 1;
   parentGroup = AudioLocation;
   className = "AudioStateExclusive";
};

singleton SFXAmbience( AudioAmbienceOutside )
{
   local = 1;   
   environment = AudioEnvPlain;
   soundTrack = env_outdoor_loop_day;    
   states[ 0 ] = AudioLocationOutside;  
};

// removed for economy of id's
/*
singleton SFXAmbience( AudioAmbienceInside )
{
   environment = AudioEnvRoom;
   states[ 0 ] = AudioLocationInside;
};

singleton SFXAmbience( AudioAmbienceUnderwater )
{
   environment = AudioEnvUnderwater;
   states[ 0 ] = AudioLocationUnderwater;
};
*/
