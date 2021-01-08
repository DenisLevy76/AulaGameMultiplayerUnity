using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using System;

public class GestorDeRede : MonoBehaviourPunCallbacks
{
    public static GestorDeRede Instancia { get; private set; }
    private void Awake() {
        if (Instancia != null && Instancia != this){
            gameObject.SetActive(false);
            return;
        }
        Instancia = this;
        DontDestroyOnLoad(gameObject);

    }

  public void CriaSala(string nomeSala)
  {
    PhotonNetwork.CreateRoom(nomeSala);
  }
  public void EntrarSala(string nomeSala)
  {
    PhotonNetwork.JoinRoom(nomeSala);
  }
  public void MudaNick(string nickname){
      PhotonNetwork.NickName = nickname;
  }

  private void Start(){
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Conexão bem sucedida");
    }
}
