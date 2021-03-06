﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asset.Scripts.Qbik.Static.Controller
{
    public static class SInput
    {
        public static float InputControll()
        {
            float _moveDir;
            _moveDir = Input.GetAxisRaw("Horizontal");
            return _moveDir;
        }

        public static bool InputJump() 
        {
            if (Input.GetKeyDown(KeyCode.Space))
                return true;
            return false;
        }

        public static int InputAttack()
        {
            int typeAttack = 0;

            if (Input.GetMouseButtonDown(0))
            {
                typeAttack = 1;
            }
            if (Input.GetMouseButtonDown(1))
            {
                typeAttack = 2;
            }
            return typeAttack;
        }
    }
}
