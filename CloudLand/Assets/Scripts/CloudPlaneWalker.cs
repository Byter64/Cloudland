using UnityEngine;

public class CloudPlaneWalker : MonoBehaviour
{
    [SerializeField] private Material _cloudMPlaneMaterial;

    private const int maxWalkers = 4;
    private static int currentWalkers = 0;
    private int walkerId = -1;
    private string materialName;

    private void Start()
    {
        if(currentWalkers < maxWalkers)
        {
            walkerId = currentWalkers;
            currentWalkers++;
            materialName = "_Walker_" + walkerId.ToString();
        }
        else
        {
            Destroy(this);
        }
    }

    private void Update()
    {
        _cloudMPlaneMaterial.SetVector(materialName, transform.position);
    }
}
