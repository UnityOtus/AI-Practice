using System;
using System.Linq;
using Atomic.AI;
using UnityEngine;

namespace Sample
{
    [Serializable]
    public sealed class ClosestTargetReasoner : IAIUpdate
    {
        public void OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            if (blackboard.TryGetPossibleTargetCount(out int targetCount) &&
                blackboard.TryGetPossibleTargets(out var targets) 
                && blackboard.TryGetSensorCenter(out var center))
            {
                if (targetCount > 0)
                    blackboard.SetTarget(FindClosestTarget(targets, targetCount, center.position));
                else
                    blackboard.DelTarget();
            }
        }

        private GameObject FindClosestTarget(Collider[] possibleTargets, int availableTargetCount, Vector3 center)
        {
            float closestDist = float.MaxValue;
            GameObject result = null;

            for (int i = 0; i < availableTargetCount; i++)
            {
                float curDist = Vector3.Distance(center, possibleTargets[i].transform.position);
                
                if (curDist < closestDist)
                {
                    result = possibleTargets[i].gameObject;
                    closestDist = curDist;
                }
            }

            return result;
        }
    }
}