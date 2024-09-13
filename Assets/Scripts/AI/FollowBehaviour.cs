using System;
using Atomic.AI;
using UnityEngine;

namespace Sample
{
    [Serializable]
    public sealed class FollowBehaviour : IAIUpdate
    {
        public void OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            if (blackboard.TryGetCharacter(out GameObject character) &&
                blackboard.TryGetTarget(out GameObject target) &&
                blackboard.TryGetStoppingDistance(out float stoppingDistance))
            {
                Debug.Log("FOLLOW");
                this.Follow(character, target, stoppingDistance);
            }
        }
        
        private void Follow(GameObject character, GameObject target, float stoppingDistance)
        {
            Vector3 currentPosition = character.transform.position;
            Vector3 targetPosition = target.transform.position;
            Vector3 distanceVector = targetPosition - currentPosition;
            distanceVector.y = 0;
            
            Vector3 moveDirection = distanceVector.sqrMagnitude <= stoppingDistance * stoppingDistance
                ? Vector3.zero
                : distanceVector.normalized;
            
            character.GetComponent<MoveComponent>().SetDirection(moveDirection);
        }
    }
}