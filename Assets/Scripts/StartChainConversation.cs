using UnityEngine;
using DialogueEditor;

public class StartChainConversation : MonoBehaviour
{
    [SerializeField] private NPCConversation NextConvo;
    public void StartNextConversastion()
    {
        ConversationManager.Instance.StartConversation(NextConvo);
    }
}
