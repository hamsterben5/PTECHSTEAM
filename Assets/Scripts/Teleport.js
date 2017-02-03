var target : Transform;
 
function Update () {
 
}
 
function OnTriggerEnter (col : Collider) {
 
    if(col.gameObject.tag == "teleport") {
        this.transform.position = target.position;
    }
}