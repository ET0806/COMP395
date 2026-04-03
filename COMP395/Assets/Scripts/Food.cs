using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int nutritionalValue;

    private void despawn()
    {
        Destroy(gameObject);
    }

    //It decrements the nutrient value by 1 per second and then despawns the GameObject.
    public IEnumerator decreaseNutritionalValue()
    {
        while (nutritionalValue > 0)
        {
            nutritionalValue--;
            yield return new WaitForSeconds(1.0f);
        }
        despawn();
    }

}
