using TMPro;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    // for legacy text
    // [SerializeField] Text TextComponent;

    // check out other TextMesh types to see what types are available
    [SerializeField] TextMeshProUGUI storyTitle;
    [SerializeField] TextMeshProUGUI storyText;
    [SerializeField] State initialState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = initialState;
        // TextComponent.text = ("State Stte.");
        storyTitle.text = state.GetStateTitle();
        storyText.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }

    private void ManageState()
    {
        // var automatically detects variable type based on the value assign
        var nextStates = state.GetNextStates();

        for (int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextStates[i];
            }
        }

        // causes out of bound error
        // if (Input.GetKeyDown(KeyCode.Alpha1))
        // {
        //     state = NextStates[0];
        // }
        // else if (Input.GetKeyDown(KeyCode.Alpha2))
        // {
        //     state = NextStates[1];
        // }
        // else if (Input.GetKeyDown(KeyCode.Alpha3))
        // {
        //     state = NextStates[2];
        // }
        // else
        // {
        //     state = state;
        // }

        storyTitle.text = state.GetStateTitle();
        storyText.text = state.GetStateStory();
    }
}
