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
            //var p = PTZDevice.GetDevice(DeviceName, PTZType.Relative);
            //p.Move(x, y);
            Console.WriteLine("move {0},{1}",-1, 0);
        }

        [HttpPost]
        public void Zoom(int value)
        {
            var p = PTZDevice.GetDevice(DeviceName, PTZType.Relative);
            p.Zoom(value);
        }

    }
}
