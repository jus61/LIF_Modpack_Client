/// Звуковые профайлы для AI_Animal

/// Стандартные настройки воспроизведения звука - в профайлах Audio_animal_default и Audio_animal_default_loop
/// Звуковой профайл конкретного звука имеет имя Audio_sound_name, где sound_name - имя звукового файла.

singleton SFXDescription( Audio_animal_default : AudioDefault3D)
{
   is3D              = true;
   ReferenceDistance = 20.0;
   MaxDistance       = 100.0;
   volume = 0.4;
};
singleton SFXDescription( Audio_animal_default_looped : AudioDefault3D)
{
   isLooping = true;
};

/// Звуковой профайл для bear_attackfast.wav
singleton SFXDescription( Audio_bear_attackfast : Audio_animal_default)
{
   volume = 0.6;
};

exec("./animals/DeerMale.cs");
exec("./animals/AurochsBull.cs");
exec("./animals/Bear.cs");
exec("./animals/Boar.cs");
exec("./animals/Sow.cs");
exec("./animals/WildHorse.cs");
exec("./animals/Grouse.cs");
exec("./animals/Hare.cs");
exec("./animals/Hind.cs");
exec("./animals/Wolf.cs");
exec("./animals/Moose.cs");
exec("./animals/Mutton.cs");
exec("./animals/AurochsCow.cs");
