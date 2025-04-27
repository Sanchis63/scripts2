using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    int level = 1;
    int health = 3;
    int speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        

        // прибавляем к здоровью уровень
        health += level;
        // выводим здоровье в консоль
        Debug.Log(health);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z +=
        speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
