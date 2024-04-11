using UnityEngine;
using UnityEngine.UIElements;

public class Laser : MonoBehaviour
{
    private GameObject laser;
    public float endTranslationPositionY;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.up);

        if(transform.position.y > endTranslationPositionY)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collide");
        if (collision != null && collision.gameObject.CompareTag("Enemy"))
        {
                Destroy(gameObject);
        }
    }
}

