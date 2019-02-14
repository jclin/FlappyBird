using UnityEngine;

public class SkillzInitializer : MonoBehaviour
{
    public void InitializeSkillz()
    {
        SkillzCrossPlatform.LaunchSkillz(new GameController());
    }
}
