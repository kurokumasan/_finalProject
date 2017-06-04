﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordSubmit : MonoBehaviour {
	public Text[] field;
	public string[] passwd;
	public int size;
	public ChangeImage ci;
	public FolderChange fc;
	[SerializeField] GameObject passwdWindow;

	public bool isUnlock = false;

	public bool submitPasswd () {
		bool flag = true;
		for (int i=0; i<size; i++) {
			if (field[i].text != passwd[i]) {
				flag = false;
			}
		}

		if (flag)
			print ("unlock");
		else
			print ("wrong password!!!");

		return flag;
	}

	public void react() {
		if (submitPasswd()) {
			passwdWindow.SetActive(false);
			isUnlock = true;
			ci.changeImage();
			fc.react();
		}
	}
}
