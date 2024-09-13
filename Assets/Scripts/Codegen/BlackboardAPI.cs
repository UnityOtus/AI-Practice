/**
* Code generation. Don't modify! 
 */
using System.Runtime.CompilerServices;
using Atomic.AI;
using Unity.Mathematics;
using UnityEngine;
using Sample;
namespace Atomic.AI
{
    public static class BlackboardAPI
    {
        public const int Character = 1; // GameObject : class
        public const int Target = 2; // GameObject : class
        public const int StoppingDistance = 3; // float
        public const int Artem = 4; // Transform : class
        public const int SensorCenter = 5; // Transform : class
        public const int SensorRadius = 6; // float
        public const int PossibleTargets = 7; // Collider[] : class
        public const int PossibleTargetCount = 8; // int


        ///Extensions
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCharacter(this IBlackboard obj) => obj.HasObject(Character);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GameObject  GetCharacter(this IBlackboard obj) => obj.GetObject<GameObject >(Character);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCharacter(this IBlackboard obj, out GameObject  value) => obj.TryGetObject(Character, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCharacter(this IBlackboard obj, GameObject  value) => obj.SetObject(Character, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCharacter(this IBlackboard obj) => obj.DelObject(Character);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTarget(this IBlackboard obj) => obj.HasObject(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GameObject  GetTarget(this IBlackboard obj) => obj.GetObject<GameObject >(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTarget(this IBlackboard obj, out GameObject  value) => obj.TryGetObject(Target, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTarget(this IBlackboard obj, GameObject  value) => obj.SetObject(Target, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTarget(this IBlackboard obj) => obj.DelObject(Target);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasStoppingDistance(this IBlackboard obj) => obj.HasFloat(StoppingDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetStoppingDistance(this IBlackboard obj) => obj.GetFloat(StoppingDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetStoppingDistance(this IBlackboard obj, out float value) => obj.TryGetFloat(StoppingDistance, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetStoppingDistance(this IBlackboard obj, float value) => obj.SetFloat(StoppingDistance, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelStoppingDistance(this IBlackboard obj) => obj.DelFloat(StoppingDistance);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasArtem(this IBlackboard obj) => obj.HasObject(Artem);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform  GetArtem(this IBlackboard obj) => obj.GetObject<Transform >(Artem);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetArtem(this IBlackboard obj, out Transform  value) => obj.TryGetObject(Artem, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetArtem(this IBlackboard obj, Transform  value) => obj.SetObject(Artem, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelArtem(this IBlackboard obj) => obj.DelObject(Artem);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasSensorCenter(this IBlackboard obj) => obj.HasObject(SensorCenter);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform  GetSensorCenter(this IBlackboard obj) => obj.GetObject<Transform >(SensorCenter);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetSensorCenter(this IBlackboard obj, out Transform  value) => obj.TryGetObject(SensorCenter, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetSensorCenter(this IBlackboard obj, Transform  value) => obj.SetObject(SensorCenter, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelSensorCenter(this IBlackboard obj) => obj.DelObject(SensorCenter);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasSensorRadius(this IBlackboard obj) => obj.HasFloat(SensorRadius);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetSensorRadius(this IBlackboard obj) => obj.GetFloat(SensorRadius);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetSensorRadius(this IBlackboard obj, out float value) => obj.TryGetFloat(SensorRadius, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetSensorRadius(this IBlackboard obj, float value) => obj.SetFloat(SensorRadius, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelSensorRadius(this IBlackboard obj) => obj.DelFloat(SensorRadius);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPossibleTargets(this IBlackboard obj) => obj.HasObject(PossibleTargets);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Collider[]  GetPossibleTargets(this IBlackboard obj) => obj.GetObject<Collider[] >(PossibleTargets);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPossibleTargets(this IBlackboard obj, out Collider[]  value) => obj.TryGetObject(PossibleTargets, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPossibleTargets(this IBlackboard obj, Collider[]  value) => obj.SetObject(PossibleTargets, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPossibleTargets(this IBlackboard obj) => obj.DelObject(PossibleTargets);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPossibleTargetCount(this IBlackboard obj) => obj.HasInt(PossibleTargetCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetPossibleTargetCount(this IBlackboard obj) => obj.GetInt(PossibleTargetCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPossibleTargetCount(this IBlackboard obj, out int value) => obj.TryGetInt(PossibleTargetCount, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPossibleTargetCount(this IBlackboard obj, int value) => obj.SetInt(PossibleTargetCount, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPossibleTargetCount(this IBlackboard obj) => obj.DelInt(PossibleTargetCount);

    }
}
