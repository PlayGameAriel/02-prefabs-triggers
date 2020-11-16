using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component spawns the given object whenever the player clicks a given key.
 * The player can't fire without a break, half a second between shots.
 */
public class KeyboardSpawner: MonoBehaviour {
    [SerializeField] protected KeyCode keyToPress;
    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] protected Vector3 velocityOfSpawnedObject;
     float timer = 0;
    [SerializeField] private float duration = 0.5f;


    protected virtual GameObject spawnObject() {
        // Step 1: spawn the new object.
       
        Vector3 positionOfSpawnedObject = transform.position;  // span at the containing object position.
        Quaternion rotationOfSpawnedObject = Quaternion.identity;  // no rotation.
       
        GameObject newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, rotationOfSpawnedObject);
        // Step 2: modify the velocity of the new object.
     
        Mover newObjectMover = newObject.GetComponent<Mover>();
        if (newObjectMover) {
            newObjectMover.SetVelocity(velocityOfSpawnedObject);
            
        }

        return newObject;
    }

    
    private void Update() {
        timer = Time.deltaTime + timer;
        if (Input.GetKeyDown(KeyCode.Space) && timer > duration)
         { 
            
            spawnObject();
            timer = 0;
        }
       
    }
   
}
