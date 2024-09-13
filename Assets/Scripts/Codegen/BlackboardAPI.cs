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
        public const int AttackDistance = 5; // float
        public const int AttackTag = 6; // bool
        public const int AttackAngle = 7; // float


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
		public static bool HasAttackDistance(this IBlackboard obj) => obj.HasFloat(AttackDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetAttackDistance(this IBlackboard obj) => obj.GetFloat(AttackDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackDistance(this IBlackboard obj, out float value) => obj.TryGetFloat(AttackDistance, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackDistance(this IBlackboard obj, float value) => obj.SetFloat(AttackDistance, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackDistance(this IBlackboard obj) => obj.DelFloat(AttackDistance);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackTag(this IBlackboard obj) => obj.HasBool(AttackTag);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GetAttackTag(this IBlackboard obj) => obj.GetBool(AttackTag);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackTag(this IBlackboard obj, out bool value) => obj.TryGetBool(AttackTag, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackTag(this IBlackboard obj, bool value) => obj.SetBool(AttackTag, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackTag(this IBlackboard obj) => obj.DelBool(AttackTag);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackAngle(this IBlackboard obj) => obj.HasFloat(AttackAngle);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetAttackAngle(this IBlackboard obj) => obj.GetFloat(AttackAngle);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackAngle(this IBlackboard obj, out float value) => obj.TryGetFloat(AttackAngle, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackAngle(this IBlackboard obj, float value) => obj.SetFloat(AttackAngle, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackAngle(this IBlackboard obj) => obj.DelFloat(AttackAngle);

    }
}
