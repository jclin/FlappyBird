using SkillzSDK;
using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class GameController : MonoBehaviour, SkillzMatchDelegate
{
    public void OnMatchWillBegin(Match matchInfo)
    {
        SceneManager.LoadScene("Main");
    }

    public void OnSkillzWillExit()
    {
    }
}
