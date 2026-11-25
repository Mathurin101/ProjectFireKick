using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] TextMeshProUGUI KickScore;

    private int NumberOfFiresKicked;
    private int NumberOfFiresKickedStreak;

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
        KickScore.text = "0";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int GetFireKickedCounter()
    {
        return NumberOfFiresKicked;
    }

    public void IncreaseFireKickedCounter()
    {
        NumberOfFiresKicked++;
        KickScore.text = NumberOfFiresKicked.ToString();
    }
    //public void IncreaseFireKickedStreak()
    //{
    //    NumberOfFiresKickedStreak++;
    //    //KickScore.text = NumberOfFiresKickedStreak.ToString();
    //}
}
