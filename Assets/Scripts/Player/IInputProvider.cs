using UnityEngine;

namespace ProjectNJSJ.Assets.Scripts.Player
{
    interface IInputProvider
    {
        bool GetKeyMove(KeyCode keyCode);
        bool GetKeyMoveRight();
        bool GetKeyMoveLeft();
        bool GetKeyMoveUnder();
        bool GetKeySliding();
        bool GetJump();
        Vector3 GetMoveDirection();
    }
}