using System.Collections.Generic;
using UnityEngine;

public class NPCDialogue : MonoBehaviour
{
    [SerializeField] List<string> Dialogo;
    [SerializeField] NPCDialogueUI DialogueUI;
    [SerializeField] Quests Pelea;
    public void Hablar()
    {
        DialogueUI.TextoVisible(Dialogo);
        DialogueUI.OnFinish += IniciarMisionPelea;
        Debug.Log("Hablando con NPC");
    }

    public void IniciarMisionPelea()
    {
        Pelea.StartQuest();
        DialogueUI.OnFinish -= IniciarMisionPelea;
        Debug.Log("Iniciar mision");
    }

}
