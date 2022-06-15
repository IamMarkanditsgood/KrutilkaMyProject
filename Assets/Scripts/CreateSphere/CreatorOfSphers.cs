using UnityEngine;

public class CreatorOfSphers : MonoBehaviour, ICreator
{
    
    [SerializeField] private Color[] _colorForSphere = new Color[_numberOfColorForSpheres];
    private bool _recreateOfSphere;
    private const int _numberOfColorForSpheres = 8;
    public void SetRecreator(bool Recreate)
    {
        this._recreateOfSphere = Recreate;
    }
    private void Start()
    {
        CreateNewFeatures();
    }
    private void Update()
    {
        if (gameObject.activeInHierarchy && _recreateOfSphere)
        {
            CreateNewFeatures();
            _recreateOfSphere = false;
        }
    }
    private void CreateNewFeatures()
        {
            
            CreateColorForSphere();
            CreateTagForSphere();
            CreateScriptOfSphere();
        }
    private void CreateColorForSphere()
        {
            gameObject.GetComponent<Renderer>().material.color = _colorForSphere[Random.Range(0, _numberOfColorForSpheres)];
        }
    private void CreateTagForSphere()
        {
        
        if (gameObject.GetComponent<Renderer>().material.color == new Color(1, 0, 0, 1))
            {
                gameObject.tag = "Red";
            }
            else if(gameObject.GetComponent<Renderer>().material.color == new Color(1, 0.5f, 0, 1))
            {
                gameObject.tag = "Orange";
            }
            else if (gameObject.GetComponent<Renderer>().material.color == new Color(1, 1, 0, 1))
            {
                gameObject.tag = "Yellow";
            }
            else if (gameObject.GetComponent<Renderer>().material.color == new Color(0, 0.3f, 0, 1))
            {
                gameObject.tag = "Green";
            }
            else if (gameObject.GetComponent<Renderer>().material.color == new Color(0, 1, 1, 1))
            {
                gameObject.tag = "Azure";
            }
            else if (gameObject.GetComponent<Renderer>().material.color == new Color(0, 0, 1, 1))
            {
                gameObject.tag = "Blue";
            }
            else if (gameObject.GetComponent<Renderer>().material.color == new Color(0.3f, 0, 0.3f, 1))
            {
                gameObject.tag = "Purple";
            }
            else if (gameObject.GetComponent<Renderer>().material.color == new Color(1, 0, 1, 1))
            {
                gameObject.tag = "Pink";
            }
        }
    private void CreateScriptOfSphere()
        {
            
            switch (NumberOfSpheresType())// Свитч для будущих дополнений
            {
                case 0:
                    
                    gameObject.AddComponent<Teleporter>();
                    break;
                default:
                    
                    break;
            }
        }
    private int NumberOfSpheresType()//Give number of spheres type basik on chance that change if level complexity uped 
        {
            int levelComplexity = DataForLevels.GetDatas.LevelComplexity;
            int RandomTypeOfSphereOnScene = Random.Range(0, 101);
            
            int ChanceForTeleportSpher = 0;
            switch (levelComplexity)
            {
                case 0:
                    ChanceForTeleportSpher = -1;
                    break;
                case 1:
               
                    ChanceForTeleportSpher = 10;//10
                    break;
                case 2:
                    ChanceForTeleportSpher = 25;//25
                    break;
            case 3:
                ChanceForTeleportSpher = 50;//50
                break;
            default:
                    ChanceForTeleportSpher = 50;//50
                    break;

            }
            if (RandomTypeOfSphereOnScene <= ChanceForTeleportSpher)
            {
                return 0;
            }
            else
            {
                return 1;
            }
           
        }
}

