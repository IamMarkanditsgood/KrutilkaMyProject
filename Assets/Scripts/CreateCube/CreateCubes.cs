using UnityEngine;

public class CreateCubes : MonoBehaviour, ICreator
{
    [SerializeField] private Color[] _colorForCube = new Color[_numberOfColorForCubes];
    private bool _recreateOfCube;
    private const int _numberOfColorForCubes = 4;

    public void SetRecreator(bool Recreate)
    {
        this._recreateOfCube = Recreate;
    }
    private void Start()
    {
        CreateNewFeatures();
    }
    private void Update()
    {
        if (gameObject.activeInHierarchy && _recreateOfCube)
        {
            CreateNewFeatures();
            _recreateOfCube = false;
        }
    }
    private void CreateNewFeatures()
    {
        CreateColorForCube();
        CreateTagForCube();
        CreateScriptOfCube();
    }
    private void CreateColorForCube()
    {
        gameObject.GetComponent<Renderer>().material.color = _colorForCube[Random.Range(0, _numberOfColorForCubes)];
    }
    private void CreateTagForCube()
    {
        if (gameObject.GetComponent<Renderer>().material.color == new Color(1, 0, 0, 1))
        {
            gameObject.tag = "Red";
        }
        else if (gameObject.GetComponent<Renderer>().material.color == new Color(1, 1, 0, 1))
        {
            gameObject.tag = "Yellow";
        }
        else if (gameObject.GetComponent<Renderer>().material.color == new Color(0, 1, 1, 1))
        {
            gameObject.tag = "Azure";
        }
        else if (gameObject.GetComponent<Renderer>().material.color == new Color(0.3f, 0, 0.3f, 1))
        {
            gameObject.tag = "Purple";
        }
    }
    private void CreateScriptOfCube()
    {
        switch (NumberOfCubesType())// Свитч для будущих дополнений
        {
            case 0:
                gameObject.AddComponent<Teleporter>();
                break;
            default:
                break;
        }
    }
    private int NumberOfCubesType()//Give number of spheres type basik on chance that change if level complexity uped 
    {
        int levelComplexity = DataForLevels.GetDatas.LevelComplexity;
        int RandomTypeOfCubeOnScene = Random.Range(0, 101);
        int ChanceForTeleportCub;
        switch (levelComplexity)
        {
            case 0:
                ChanceForTeleportCub = -1;
                break;
            case 1:
                ChanceForTeleportCub = 10;
                break;
            case 2:
                ChanceForTeleportCub = 25;
                break;
            case 3:
                ChanceForTeleportCub = 50;
                break;
            default:
                ChanceForTeleportCub = 50;
                break;
        }
        if (RandomTypeOfCubeOnScene <= ChanceForTeleportCub)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
}
