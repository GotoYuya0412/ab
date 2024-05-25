using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class RandomSelect : MonoBehaviour
{

    [SerializeField] private Bullet[] bulletPrefabs;

    private Bullet reservedBullets;
    public Bullet ReservedBullets
    {
        get { return reservedBullets; }
    }

    private void Start()
    {
        Pop();
    }

    public Bullet Pop()
    {
        Bullet ret = reservedBullets;

        int index = Random.Range(0, bulletPrefabs.Length);
        reservedBullets = bulletPrefabs[index];

        return ret;
    }



}
