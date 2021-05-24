using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    int score = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            Destroy(collision.gameObject);
            score++;
            print("score is "+score);
            //collision.gameObject.SetActive(true);

        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            print("score is  " + score);
            print("Game End");
        }
    }

}
