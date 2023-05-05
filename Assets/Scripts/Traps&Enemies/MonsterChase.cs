using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterChase : DamagePlayer
{
    public float speed;
    public string tagTarget = "Player";

    // Update is called once per frame
    void Update()
    {
        transform.Translate(2 * Time.deltaTime * speed, 0, 0);
        transform.localScale = new Vector2(2, 2);
    }

    void OnTriggerEnter2D(Collider2D trig)
    {
        base.OnTriggerEnter2D(trig);
        Debug.Log("Nom");
    }
}
