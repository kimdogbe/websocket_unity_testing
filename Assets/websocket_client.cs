using UnityEngine;
using WebSocketSharp;

public class websocket_client : MonoBehaviour
{
    WebSocket ws;
    private void Start()
    {
        ws = new WebSocket("ws://localhost:8080");
        ws.Connect();
        ws.OnMessage += (sender, e) =>
        {
            Debug.Log("Message Received from "+((WebSocket)sender).Url+", Data : "+e.Data);
        };
    }
private void Update()
    {
        if(ws == null)
        {
            return;
        }
if (Input.GetKeyDown(KeyCode.Space))
        {
            ws.Send("Hello");
        }  
    }
}
