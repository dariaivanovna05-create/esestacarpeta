using UnityEngine;

public class ArmaScript : MonoBehaviour
{
    [SerializeField] Quests ArmaQuest;
    [SerializeField] Item Info;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && ArmaQuest.questProgress == Quests.QuestProgress.inProgress)
        {
            ArmaQuest.IncrementCounter();

            Destroy(gameObject);
        }


    }
}
