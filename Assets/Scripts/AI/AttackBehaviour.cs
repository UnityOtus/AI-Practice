using Atomic.AI;
using Sample;
using System;
using UnityEngine;

[Serializable]
public sealed class AttackBehaviour : IAIUpdate
{
    public void OnUpdate(IBlackboard blackboard, float deltaTime)
    {
        if (blackboard.HasAttackTag() &&
            blackboard.TryGetCharacter(out GameObject character) && character != null &&
            blackboard.TryGetTarget(out GameObject target) && target != null &&
            blackboard.TryGetAttackDistance(out float attackDistance) &&
            blackboard.TryGetAttackAngle(out float attackAngle))
        {
            this.Shoot(character, target, attackDistance, attackAngle);
        }
    }

    private void Shoot(GameObject character, GameObject target, float attackDistance, float attackAngle)
    {

        Vector3 currentPosition = character.transform.position; 
        Vector3 targetPosition = target.transform.position;
        Vector3 distanceVector = targetPosition - currentPosition;
        distanceVector.y = 0;

        float distance = Vector3.Distance(currentPosition, targetPosition);

        if (distance < attackDistance)
        {
            character.GetComponent<RotationComponent>().Rotate(distanceVector.normalized);

            Vector3 currentDirection = character.transform.forward;

            if (Vector3.Angle(currentDirection, targetPosition) < attackAngle)
            {
                character.GetComponent<ShootComponent>().Shoot();
            }

        }
    }
}