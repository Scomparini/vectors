using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private float _randomPosition;
    void Start()
    {
        Teletransport();
    }
    void Update()
    {

    }

    public void Teletransport()
    {
        _randomPosition = Random.Range(1, 21);
        transform.position = new Vector3(_randomPosition, _randomPosition, _randomPosition);
        Task task = Wait();

        //só o msm valor random?
    }
   
    async Task Wait()
    {
        await Task.Delay(5000);
        transform.position = Vector3.zero;  
    }
}
