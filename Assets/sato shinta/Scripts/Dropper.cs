using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private RandomSelect randomBulletSelector;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            var BulletPrefab = randomBulletSelector.Pop();
            Instantiate(BulletPrefab, transform.position, Quaternion.identity);
        }
    }
}
