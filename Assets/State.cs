using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [SerializeField] string storyTitle;
    // text area is to convert this text box to text area
    // first number in text area in min height of the text area
    // second is the max height before we need to scroll
    [TextArea(10, 14)][SerializeField] string storyText;
    [SerializeField] State[] nextStates;

    public string GetStateTitle()
    {
        return storyTitle;
    }

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
