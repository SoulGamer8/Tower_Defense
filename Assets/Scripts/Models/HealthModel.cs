using UnityEngine;
using UnityEngine.Events;

namespace NeverMindEver.Models{
    public class HealthModel{
        public event UnityAction<int> OnHealthChanged;
        private int _currentHealth;
        private readonly int _maxHealth;
        
        public HealthModel(int maxHealth){
            _maxHealth = maxHealth;
            _currentHealth = maxHealth;
        }
        
        public void TakeDamage(int damage) {
            _currentHealth -= damage;
            if (_currentHealth <= 0) _currentHealth = 0;
            OnHealthChanged?.Invoke(_currentHealth);
        }

        public void Heal(int amount) {
            _currentHealth += amount;
            if (_currentHealth > _maxHealth) _currentHealth = _maxHealth;
            OnHealthChanged?.Invoke(_currentHealth);
        }
    }
}
