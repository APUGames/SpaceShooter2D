using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycontroller : MonoBehaviour
{
    [SerializeField]
    private float fallingSpeed = 2.0f;
    [SerializeField]
    private float horizontalRangeMin = -9f;
    [SerializeField]
    private float horizontalRangeMax = 9f;
    [SerializeField]
    private float endZ = -10.0f;
    [SerializeField]
    private Vector2 startLocation = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckRespawn();
    }

    private void Move()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - (fallingSpeed * Time.deltaTime));
    }

    private void CheckRespawn()
    {
        if (transform.position.y < endZ)
        {
            // Respawn at a random X
            float newX = Random.Range(horizontalRangeMin, horizontalRangeMax);
            transform.position = new Vector2(newX, startLocation.y);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collide");
        if (collision != null && collision.gameObject.CompareTag("Laser"))
        {
            //lasers deal damage to enemy health before destorying the object
                Destroy(gameObject);
        }
        if (collision != null && collision.gameObject.CompareTag("Ship"))
        {
            //lasers deal damage to enemy health before destorying the object
            Destroy(this.gameObject);
        }
    }
}
