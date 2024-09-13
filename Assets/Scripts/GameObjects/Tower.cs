using Sample;
using UnityEngine;

namespace Sample
{
    public class Tower : MonoBehaviour
    {
        [SerializeField] private RotationComponent _rotationComponent;
        [SerializeField] private LifeComponent _lifeComponent;
        [SerializeField] private ShootComponent _shootComponent;

        [SerializeField] private Transform _target;
        [SerializeField] private float _radius;

        private void Awake()
        {
            _rotationComponent.AppendCondition(_lifeComponent.IsAlive);
            _shootComponent.AppendCondition(_lifeComponent.IsAlive);
        }
        
        private void FixedUpdate()
        {
            if (!_lifeComponent.IsAlive())
            {
                Destroy(this.gameObject);
            }
        }

        private void Update()
        {
            if (_target == null)
            {
                return;
            }
            
            var direction = _target.position - transform.position;
            _rotationComponent.Rotate(direction);
            
            if (direction.magnitude < _radius)
            {
                _shootComponent.Shoot();
            }
        }
    }
}