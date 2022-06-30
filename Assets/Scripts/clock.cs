using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock : MonoBehaviour
{
    [SerializeField] private float dayTime;
    [SerializeField] private float dayCount;

    [SerializeField] private bool isDay;
    public Light it;



    void Start()
    {
        it = GetComponent<Light>();
        isDay = false;
        dayTime = 0;
        dayCount = 0;
    }


    void Update()
    {
        dayTime += Time.deltaTime;
     

        if (dayTime >= 0f || dayTime <= 20f)
        {
            isDay = true;
        }
        else if(dayTime > 20f)
        {
            isDay = false;

        }
        mudaDia();
        if (dayTime >= 40f)
        {
            dayCount++;
            dayTime = 0;
        }
    }

    void mudaDia()
    {
        if (isDay == true)
        {
            it.intensity = 2;
        }
        else if (isDay == false)
        {
            it.intensity = 1;
        }
    }
}
