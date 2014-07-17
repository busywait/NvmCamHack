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
        PTZDevice _myCamera;

        public CameraController()
        {
            _myCamera = PTZDevice.GetDevice(DeviceName, PTZType.Relative);
        }

        

        
        //public string Get()
        //{
        //    return "Hello, world!";
        //}

        //[HttpPost]
        [HttpGet]
        [ActionName("moveleft")]
        public void MoveLeft()
        {
            _myCamera.Move(-5, 0);
            Console.WriteLine("move left");
        }

        [HttpGet]
        [ActionName("moveright")]
        public void MoveRight()
        {
            _myCamera.Move(5, 0);
            Console.WriteLine("move right");
        }

        [HttpGet]
        [ActionName("moveup")]
        public void MoveUp()
        {
            _myCamera.Move(0, 5);
            Console.WriteLine("move up");
        }

        [HttpGet]
        [ActionName("movedown")]
        public void MoveDown()
        {
            _myCamera.Move(0, -5);
            Console.WriteLine("move down");
        }


        [HttpGet]
        [ActionName("zoomin")]
        public void ZoomIn()
        {
            _myCamera.Zoom(5);
            Console.WriteLine("zoom in");
        }

        [HttpGet]
        [ActionName("zoomout")]
        public void ZoomOut()
        {
            _myCamera.Zoom(-5);
            Console.WriteLine("zoom out");
        }

    }
}
