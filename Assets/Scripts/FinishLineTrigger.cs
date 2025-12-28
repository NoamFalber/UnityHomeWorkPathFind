using UnityEngine;

public class FinishLineTrigger : MonoBehaviour
{
    [SerializeField] private GameObject CongratulationsMessage;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<UnityEngine.AI.NavMeshAgent>() != null)
            {
                Debug.Log("Navigator, the agent crossed the line!");
                CongratulationsMessage.SetActive(true);
            }
        }
}
