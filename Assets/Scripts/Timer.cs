private var startTime;
var textTime : String;


function Awake()
{


    startTime = Time.time;


}


function OnGUI()
{


    var guiTime = Time.time - startTime;


    var minutes : int = guiTime / 60;
    var seconds : int = guiTime % 60;
    var fraction : int = (guiTime * 100) % 100;


    text = String.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, fraction);
    GUI.Label(Rect(400, 25, 100, 30), textTime);


}