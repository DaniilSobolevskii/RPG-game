using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    private Vector3 _destination;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hitInfo))
        {
            if (Input.GetMouseButton(0))
            {
                _destination = hitInfo.point;
            }
        }
        _navMeshAgent.SetDestination(_destination);
        
    }
   
}