﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudienceController : MonoBehaviour {

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Dead");

        if (collision.GetComponent<TowerProjectile>().projectileType == this.GetComponentInParent<AudienceUnit>().instrumentType)
        Destroy(transform.parent.gameObject);


    }

    //TODO - Move to seat?? - destroy object?? - (move "pawn" from unit make unit spawn from a pos instead.)

}
