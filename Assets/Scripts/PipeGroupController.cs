using UnityEngine;

public class PipeGroupController : MonoBehaviour
{
    [SerializeField] private float _pipeGroupSpeed;
    [SerializeField] private float _pipeDestroyTime;
    
    private void OnEnable()
    {   
        Destroy(gameObject, _pipeDestroyTime);
    }

    private void Update()
    {
        transform.position -= new Vector3 (_pipeGroupSpeed, 0, 0) * Time.deltaTime;
    }



    

}