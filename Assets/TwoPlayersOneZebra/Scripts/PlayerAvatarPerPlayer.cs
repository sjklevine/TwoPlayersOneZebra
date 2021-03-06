﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatarPerPlayer : MonoBehaviour {

	public GameObject leftHand;
	public GameObject rightHand;
	public GameObject head;

	private int playerNumber;

	public void SetPlayerNumber(int playerNumber) {
		this.playerNumber = playerNumber;
		if (playerNumber == 0) {
			leftHand.SetActive (false);
		} else {
			rightHand.SetActive (false);
		}

	}

	void Update() {
		if (head.activeSelf) {
			PhotonView photonView = GetComponent<PhotonView> ();
			if (!photonView.isMine) {
				head.SetActive (false);
			}
		}
	}

}
