using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int NumberOfFiresKicked;

    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Kicked: " + GetFireKickedCounter() + " times");
    }

    public int GetFireKickedCounter()
    {
        return NumberOfFiresKicked;
    }

    public void IncreaseFireKickedCounter()
    {
        NumberOfFiresKicked++;
    }
}
