using UnityEngine;
using Unity.Netcode;
using static PlayerNetwork;
using Unity.Collections;

public class PlayerNetwork :  NetworkBehaviour
{
    // add NetworkBehaviour 
    //add  if (!IsOwner) return;
    //add unity.netcode
    //private NetworkVariable<int>   30min in first vid
    //virtual- overide google


 //   private NetworkVariable<MyCustomData> randomNumber = new NetworkVariable<MyCustomData>(new MyCustomData { _int = 56, _bool = true,} , NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
    /*

  public struct MyCustomData : INetworkSerializable
  {
      public int _int;
      public bool _bool;
      public FixedString128Bytes message;
      public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
      {
          serializer.SerializeValue(ref _int);
          serializer.SerializeValue(ref _bool);
          serializer.SerializeValue(ref message);
      }
  }

  
  public override void OnNetworkSpawn()
  {
      randomNumber.OnValueChanged += (MyCustomData previousValue, MyCustomData newValue) =>
      {
          Debug.Log(OwnerClientId + "; " + newValue._int + "; " + newValue._bool + "; " + newValue.message);
      };
  }
  */
    private void Update()
    {
       

        if (!IsOwner) return;

       // if (Input.GetKeyDown(KeyCode.T))
        {
        //    TestServerRpc();

            
         //   randomNumber.Value = new MyCustomData
         //   {
            //    _int = 10,
          //      _bool = false,
           //     message = "All your gold is mine!"
        //    };
            
        }


        Vector3 moveDir = new Vector3 (0 ,0 ,0);

        if (Input.GetKey(KeyCode.W)) moveDir.z = +1f;
        if (Input.GetKey(KeyCode.S)) moveDir.z = -1f;
        if (Input.GetKey(KeyCode.A)) moveDir.x = -1f;
        if (Input.GetKey(KeyCode.D)) moveDir.x = +1f;

        float moveSpeed = 3f;
        transform.position += moveDir * moveSpeed * Time.deltaTime;




    }
    /*
    [ServerRpc]
    private void TestServerRpc()
    {
        Debug.Log("TestServerRpc" + OwnerClientId);
    }
    */
}
