using Dessins.Events;
using Microsoft.AspNetCore.Mvc;

namespace Dessins.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class DessinsController : ControllerBase
    {
        [HttpGet]
        // Rien à modifier ici, juste un exemple de dessin très simple
        public ActionResult GetDrawing1()
        {
            var drawSquare = new DrawSquare(2, 2);
            
            return Ok(drawSquare);
        }

        // TODO: Il faut ajouter une nouvelle action pour dessiner la séquence mentionnée dans l'énoncé
        [HttpGet]
        public ActionResult GetDrawing2()
        {
            var changcolor = new changecolor("blue")
            {
                DrawingEvents =
                [
                    new DrawCircle(1, 1)
                    {
                       DrawingEvents = [
                            new Wait(3){
                            DrawingEvents = 
                            [

                                new changecolor("red")
                                {
                                    DrawingEvents =
                                    [
                                         new  DrawSquare(0, 2),
                                           new DrawSquare(2, 2)
                                          {
                                              DrawingEvents  =
                                              [
                                                   new Wait(1)
                                                   {
                                                       DrawingEvents =
                                                       [
                                                           new changecolor("yellow")
                                                           {
                                                               DrawingEvents =
                                                               [
                                                                   new DrawStar(1, 3, 20)
                                                               ]
                                                           }
                                                       ]
                                                   }
                                              ]
                                          }
                                    ]
                                }
                                ]
                                    
                            }
                       ]
                    }
                ]
            };
            
            
           
           

           
               
               
                
                
  
            return Ok(changcolor);
        }
    }
}
