using UnityEngine;

public class ProgressionDream2 : MonoBehaviour
{
    public Animator anim;

    public static ProgressionDream2 _instance;
    public bool isholdingStarTrekCharacter, isHoldingCD, jupiterInPlace, starTrekPuzzleCompleted, dream2Completed;
    public GameObject galileoPuzzle;

    public bool[] dollsPlaced = new bool[3];//data = 0; picard = 1; worf = 2;
    void Start()
    {
        isholdingStarTrekCharacter = false;
        isHoldingCD = false;
        dream2Completed = false;
        jupiterInPlace = false;
        starTrekPuzzleCompleted = false;
    }
    void Awake()
    {
        if (_instance == null) _instance = this;
        DontDestroyOnLoad(_instance);
    }
    public void ActiveGalileoPuzzle(bool valueOfDollPlaced, int index)
    {
        if (valueOfDollPlaced && index == 1) galileoPuzzle.SetActive(true);
    }
    public void IsEveryThingInPlace()
    {
        if (dollsPlaced[0] && dollsPlaced[1] && dollsPlaced[2])
        {
            anim.enabled = true;
            starTrekPuzzleCompleted = true;
        }
    }
}

