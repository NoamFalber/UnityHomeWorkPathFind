using UnityEngine;
using UnityEngine.AI;

public class AreaSpeedZone : MonoBehaviour
{
    [Header("Who is affected (leave empty = any agent)")]
    [SerializeField] private NavMeshAgent targetAgent;

    [Header("Speed while inside this zone")]
    [SerializeField] private float zoneSpeed = 3f;

    private float _originalSpeed;
    private bool _hasOriginal;

    private void Awake()
    {
        // If assigned in inspector, remember its normal speed.
        if (targetAgent != null)
        {
            _originalSpeed = targetAgent.speed;
            _hasOriginal = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var agent = other.GetComponentInParent<NavMeshAgent>();
        if (agent == null) return;

        if (targetAgent != null && agent != targetAgent) return;

        if (!_hasOriginal)
        {
            _originalSpeed = agent.speed;
            _hasOriginal = true;
        }

        agent.speed = zoneSpeed;
    }

    private void OnTriggerExit(Collider other)
    {
        var agent = other.GetComponentInParent<NavMeshAgent>();
        if (agent == null) return;

        if (targetAgent != null && agent != targetAgent) return;

        agent.speed = _originalSpeed;
    }
}
