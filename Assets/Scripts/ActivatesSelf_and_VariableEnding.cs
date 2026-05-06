using UnityEngine;
using DialogueEditor;
public class ActivatesSelf_and_VariableEnding : MonoBehaviour
{

    [SerializeField] private NPCConversation DefaultConversastionEnding;
    [SerializeField] private NPCConversation AlternateEndingConversastion;

    int EndingConversationDecider = 0;

    public void PlayConvoDecider()
    {
        if (EndingConversationDecider == 1)
        {
            ConversationManager.Instance.StartConversation(DefaultConversastionEnding);
        }

        else
        {
            ConversationManager.Instance.StartConversation(AlternateEndingConversastion);
        }
    }

    public void GetALTERNATEEnding()
    {
        EndingConversationDecider = EndingConversationDecider + 1;
    }

}
