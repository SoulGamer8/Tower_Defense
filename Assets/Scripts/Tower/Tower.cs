using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace NeverMindEver.Towers{
    public class Tower : MonoBehaviour{
        public float _fireRate;
        private List<GameObject> enemiesInRange = new List<GameObject>();

        private void Start() {
            StartCoroutine(Attack());
        }

        private IEnumerator Attack() {
            GameObject target = enemiesInRange.OrderBy(e => Vector3.Distance(transform.position, e.transform.position)).FirstOrDefault();
            if (target != null) 
                Debug.Log("Attack"+ target.name);
            yield return new WaitForSeconds(_fireRate);
        } 
        
        private void OnTriggerEnter(Collider other) {
            if (other.TryGetComponent<GameObject>(out GameObject enemy))
                enemiesInRange.Add(enemy);
        }
        
        private void OnTriggerExit(Collider other) {
            if (other.TryGetComponent<GameObject>(out GameObject enemy)) 
                enemiesInRange.Remove(enemy);
        }
    }
}
