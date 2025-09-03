using NeverMindEver.Models;
using NeverMindEver.EnemiesData;
using UnityEngine;

namespace NeverMindEver.Enemy{
    public class Enemy : MonoBehaviour {
        [SerializeField] private EnemyData _enemyData;
        private HealthModel _healthModel;

        private void Awake(){
            _healthModel = new HealthModel(_enemyData.maxHealth);
        }
        
        
        
    }
}