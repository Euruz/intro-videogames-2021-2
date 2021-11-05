using UnityEngine;

namespace MovementController {
    public interface IMovementController
    {
        // Start is called before the first frame update
        public void Move(Vector3 velocity);

        // Update is called once per frame
        public void RotateTo(Quaternion rotation, float rotationSpeed);
    }
}
