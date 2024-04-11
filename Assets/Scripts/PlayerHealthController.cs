using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    private int health;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        health -= 1;
    }

    public int GetHealth()
    {
        return health;
    }
}