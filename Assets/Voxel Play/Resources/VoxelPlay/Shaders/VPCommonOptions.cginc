#ifndef VOXELPLAY_COMMON_OPTIONS
#define VOXELPLAY_COMMON_OPTIONS

//#define USES_TINTING

//#define USES_SEE_THROUGH

//#define USES_BRIGHT_POINT_LIGHTS

float _VPObscuranceIntensity;
#define AO_FUNCTION ao = pow(ao, _VPObscuranceIntensity - ao)


#endif // VOXELPLAY_COMMON_OPTIONS

