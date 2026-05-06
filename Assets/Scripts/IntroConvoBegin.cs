using UnityEngine;
using DialogueEditor;

public class IntroConvoBegin : MonoBehaviour
{

    [SerializeField] private NPCConversation startConversastion;

    void Start()
    {
        ConversationManager.Instance.StartConversation(startConversastion);
    }


    public void Quitgame()
    {
        Application.Quit();
    }
}
