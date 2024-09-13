using System;
using Atomic.AI;
using UnityEngine;

namespace Sample
{
    [Serializable]
    public sealed class TargetSensor : IAIUpdate
    {
        [SerializeField]
        private LayerMask _layerMask;

        [SerializeField] 
        private int _targetsCapacity = 32;
        
        public void OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            int targetCount = FindPossibleTargets(blackboard, out Collider[] targets);
            blackboard.SetPossibleTargetCount(targetCount);
            blackboard.SetPossibleTargets(targets);
        }
        
        private int FindPossibleTargets(IBlackboard blackboard, out Collider[] colliders)
        {
            colliders = Array.Empty<Collider>();
            
            if (!blackboard.TryGetSensorCenter(out Transform center) ||
                !blackboard.TryGetSensorRadius(out float radius))
            {
                return 0;
            }
            
            Collider[] results = new Collider[_targetsCapacity];
            int detectedColliderCount = Physics.OverlapSphereNonAlloc(center.position, radius, results, _layerMask);

            colliders = results;
            return detectedColliderCount;
        }
    }
}