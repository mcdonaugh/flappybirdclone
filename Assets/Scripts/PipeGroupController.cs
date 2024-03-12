using UnityEngine;

public class PipeGroupController : MonoBehaviour
{
    [SerializeField] private float _pipeGroupSpeed;
    private void Update()
    {
        transform.position -= new Vector3 (_pipeGroupSpeed, 0, 0) * Time.deltaTime;
       
        if (transform.position.x == -2)
        {
            Destroy(gameObject);
        }
    }

}