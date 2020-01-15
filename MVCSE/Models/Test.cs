using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCSE.Controllers;
using WindowManager;

namespace MVCSE.Models
{
    public class Test
    {
        public static bool TestMul()
        {
            int res = MVCSE.Controllers.HousesController.Mul(2, 3);
            WindowManager.MsgBoxResult resul = WindowManager.Interaction
    .MsgBox(res.ToString(), "Mul(Using Ws Add) Result is :", MsgBoxStyle.OkCancel);
            if (res==6)
            {
                WindowManager.MsgBoxResult result = WindowManager.Interaction
    .MsgBox("True ", "Mul Unit Test returned : ", MsgBoxStyle.OkCancel);
                return true;
            }
            else
            {
                WindowManager.MsgBoxResult result = WindowManager.Interaction
    .MsgBox("False ", "Mul Unit Test returned :", MsgBoxStyle.OkCancel);
                return false;
            }
        }
    }
}
