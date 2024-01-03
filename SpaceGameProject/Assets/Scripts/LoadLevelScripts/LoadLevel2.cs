using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace SpaceGame
{
    public class LoadLevel2 : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKey(KeyCode.P))
            {
                LoadLevel("Level2");
            }
        }

        public void LoadLevel(string name)
        {
            SceneManager.LoadScene(name);
        }

        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Rocket"))
            {
                LoadLevel("Level2");
            }
        }
    }
}
