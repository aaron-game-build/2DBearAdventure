using System;
using System.Collections;
using System.Collections.Generic;
using Const;
using Unity.VisualScripting;
using UnityEngine;

namespace BearAdventure2D
{
	public class PlayerManager : MonoBehaviour
	{
		public float MoveSpeed = 2f;
		
		private Animator anim;
		
		private Sprite[] playerTexture;
		
		private void Awake()
		{
			anim = transform.Find("Animator")?.GetOrAddComponent<Animator>();
		}

		private void Start()
		{
			LoadPlayerTexture();
			PlayPlayerAnimation();
		}

		private void LoadPlayerTexture()
		{
			playerTexture = Resources.LoadAll<Sprite>(Config.PlayerAnimationResourcePath);
		}
		
		private void PlayPlayerAnimation()
		{
			
		}

		private void Update()
		{
			anim.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
			anim.SetFloat("Vertical", Input.GetAxis("Vertical"));
			
		}
	}
}
