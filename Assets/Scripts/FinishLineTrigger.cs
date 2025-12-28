using UnityEngine;

public class FinishLineTrigger : MonoBehaviour
{
    [SerializeField] private GameObject CongratulationsMessage;
    [SerializeField] private GameObject InputManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<UnityEngine.AI.NavMeshAgent>() != null)
            {
                Debug.Log("Navigator, the agent crossed the line!");
                CongratulationsMessage.SetActive(true);
                InputManager.gameObject.SetActive(false);
            }
        }
}
