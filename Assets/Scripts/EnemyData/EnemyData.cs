using UnityEngine;

namespace NeverMindEver.EnemiesData {
    [CreateAssetMenu(fileName = "EnemyData", menuName = "Scriptable Objects/EnemyData")]
    public class EnemyData : ScriptableObject {
        [Header("Health Settings")]
        public int maxHealth = 100;
    
        [Header("Combat Settings")]
        public int attackDamage = 10;
        public float attackCooldown = 1.5f;
    
        [Header("Movement Settings")]
        public float moveSpeed = 3f;
    
        [Header("Rewards")]
        public int goldReward = 25;

        
    }
}
