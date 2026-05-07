using UnityEngine;
using DialogueEditor;
public class ActivatesSelf_and_VariableEnding : MonoBehaviour
{

    [SerializeField] private NPCConversation DefaultConversastionEnding;
    [SerializeField] private NPCConversation AlternateEndingConversastion;

    public int EndingConversationDecider = 0;

    //E promt game object
    public GameObject PromtObject;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            //check for input key E
            if (Input.GetKeyDown(KeyCode.E))
            {
                //hide E promt
                //EPromtCanvas.enabled = false;
                PromtObject.SetActive(false);

                if (EndingConversationDecider == 0)
                {
                    Debug.Log("ending1");
                    ConversationManager.Instance.StartConversation(DefaultConversastionEnding);
                }

                else
                {
                    Debug.Log("ending2");
                    ConversationManager.Instance.StartConversation(AlternateEndingConversastion);
                }
            }
        }

    }

    public void GetALTERNATEEnding()
    {
        Debug.Log("alternate ending!");
        EndingConversationDecider = EndingConversationDecider + 1;
    }

}
