using PTZ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace NvmRemoteCameraControlServer
{

    public class CameraController : ApiController
    {

        const string DeviceName = "ConferenceCam CC3000e Camera";


        //public string Get()
        //{
        //    return "Hello, world!";
        //}

        //[HttpPost]
        [HttpGet]
        [ActionName("moveleft")]
        public void MoveLeft()
        {
            var p = PTZDevice.GetDevice(DeviceName, PTZType.Relative);
            p.Move(-5, 0);
            Console.WriteLine("move left");
        }

        [HttpGet]
        [ActionName("moveright")]
        public void MoveRight()
        {
            var p = PTZDevice.GetDevice(DeviceName, PTZType.Relative);
            p.Move(5, 0);
            Console.WriteLine("move right");
        }

        [HttpPost]
        public void Zoom(int value)
        {
            var p = PTZDevice.GetDevice(DeviceName, PTZType.Relative);
            p.Zoom(value);
        }

    }
}
