using SolarSystem.Modules.Core.Enums;
using StansAssets.SceneManagement;
using UnityEngine;

namespace SolarSystem.Modules.Core.States
{
    public class GameExitState : ApplicationState
    {
        protected override void OnChangeState(StackChangeEvent<GameState> evt, IProgressReporter reporter)
        {
            Application.Quit();
        }
    }
}