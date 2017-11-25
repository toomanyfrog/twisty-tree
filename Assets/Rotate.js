#pragma strict
 
 public var speed = 55.0;
 private var rotation = 0.0;
 private var qTo = Quaternion.identity;
 
 function Update () {
  
     if (Input.GetKeyDown(KeyCode.C)) {
     	var frame_floor = Mathf.Floor(GameObject.Find("SelectFrame").GetComponent(Transform).position.y/10);
     	var my_floor = Mathf.Floor(transform.position.y/10);
     	var controller = GameObject.Find("Player").GetComponent(CharacterController);
     	if(controller.isGrounded && my_floor == frame_floor) {
	     	rotation += 90.0;
    	    qTo = Quaternion.Euler(0.0, rotation, 0.0);
        } 
     }
	 
      
     transform.rotation = Quaternion.RotateTowards(transform.rotation, qTo, speed * Time.deltaTime);
     
 }