using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BULLET_TYPE
{
    White,
    Red,
    Bule,
    Green,
}

public class Bullet : MonoBehaviour
{
    public BULLET_TYPE bullettype;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent(out Bullet otherBllets))
        {
            if (otherBllets.bullettype == bullettype)
            {
                Destroy(gameObject);
            }
        }
    }
}
