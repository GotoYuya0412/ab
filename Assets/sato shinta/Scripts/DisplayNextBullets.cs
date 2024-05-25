using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayNextBullets : MonoBehaviour
{

    [SerializeField] private Image nextBulletsImage;
    [SerializeField] private RandomSelect randomBulletsSelect;

    // Update is called once per frame
    private void Update()
    {
        if (randomBulletsSelect.ReservedBullets != null)
        {
            nextBulletsImage.sprite = randomBulletsSelect.ReservedBullets.GetComponent<SpriteRenderer>().sprite;
        }
    }
}
