using System;
using NeverMindEver.Models;
using NeverMindEver.EnemiesData;
using UnityEngine;

namespace NeverMindEver.Enemy{
    public class Enemy : MonoBehaviour {
        [SerializeField] private EnemyData _enemyData;
        private HealthModel _healthModel;
        private Transform _startTransform;
        
        private void Awake(){
            _startTransform = transform;
            _healthModel = new HealthModel(_enemyData.maxHealth);
        }

        private void Update()
        {
            transform.position += transform.right*Time.deltaTime*_enemyData.moveSpeed;
            if (transform.position.x > 7)
            {
                transform.position =_startTransform.position;
            }    
        }
    }
}