using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Menu : MonoBehaviourPunCallbacks
{
    [SerializeField] private MenuEntrada menuEntrada;
    private void Start() {
        menuEntrada.gameObject.SetActive(false);
    }
  public override void OnConnectedToMaster()
  {
        menuEntrada.gameObject.SetActive(true);
  }
}
