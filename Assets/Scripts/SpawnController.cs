using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private float _spawnInterval;
    [SerializeField] private GameObject _pipeGroup;
    [SerializeField] private float _pipeGroupXPosition;
    [SerializeField] private float _pipeGroupYBotLimit;
    [SerializeField] private float _pipeGroupYTopLimit;
    private float _pipeGroupYPosition;
    

    private void Update()
    {
        _pipeGroupYPosition = UnityEngine.Random.Range(_pipeGroupYBotLimit, _pipeGroupYTopLimit);
    }

    public void EnableSpawn()
    {
        InvokeRepeating("SpawnPipeGroup", 0, _spawnInterval);    
    }

    public void DisableSpawn()
    {
        CancelInvoke();
    }

    private void SpawnPipeGroup()
    {
        Instantiate(_pipeGroup, new Vector3 (_pipeGroupXPosition, _pipeGroupYPosition, 0), Quaternion.identity);
    }

    public void DestroyRemainingPipes()
    {
        PipeGroupController[] pipeGroupCollection = FindObjectsOfType<PipeGroupController>();
        Debug.Log($"{pipeGroupCollection.Length}");
        foreach(var pipe in pipeGroupCollection)
        {
            Destroy(pipe.gameObject);
        } 

        Debug.Log($"Cleaned Remaining Pipes");
    }
}