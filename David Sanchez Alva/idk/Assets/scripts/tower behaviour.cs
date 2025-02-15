using System.Globalization;
using System.Collections;
using UnityEngine;
using Microsoft.Win32.SafeHandles;

public class towerbehaviour : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float attackRange = 2f;
    [SerializeField] private float firecooldown = 0f;
    [SerializeField] private float firerate = 1f;

     void Update(){
        firecooldown -= Time.deltaTime;
        Enemy target = FindClosestEnemy();
        if (target != null && firecooldown <= 0){
            Shoot(target);
            firecooldown = 1f / firerate;
        }
    }
    Enemy FindClosestEnemy(){
        Enemy[] enemies = FindObjectsByType<Enemy>(FindObjectsSortMode.None);
        Enemy closest = null;
        float closestDistance = attackRange;
        foreach (Enemy e in enemies){
            float distance = Vector2.Distance(transform.position, e.transform.position);
            closest = e;
            closestDistance = distance;
        }
        return closest;
    }
    void Shoot(Enemy target){
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        //bullet.GetComponent<Bullet>().setTarget(target.transform);
    }
}


