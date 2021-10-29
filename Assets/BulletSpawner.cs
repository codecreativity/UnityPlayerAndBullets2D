using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField]
    private float _bulletSpawnIntervalSeconds = 1;

    [SerializeField]
    private GameObject _bulletPrefab = null;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBullet", 2.0f, this._bulletSpawnIntervalSeconds);
    }

    void SpawnBullet()
    {
        Instantiate(this._bulletPrefab, this.transform.position, this.transform.rotation);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + 5);
    }
}
