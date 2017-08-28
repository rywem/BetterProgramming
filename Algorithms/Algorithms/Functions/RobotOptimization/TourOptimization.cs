using Algorithms.DataClasses;
using Algorithms.Request;
using Algorithms.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Functions.RobotOptimization
{
    public class TourOptimization
    {
        /// <summary>
        /// Uses the Nearest Neighbor approach. 
        /// </summary>
        /// <remarks>
        /// Pseudo code:
        /// NearestNeighbor(P)
        ///     Pick and visit an initial point from P0 to Pi-1
        ///     P = P_0
        ///     i = 0
        ///     While there are still unvisited points
        ///         i = i + 1
        ///         Select Pi to be the closest unvisited point to Pi - 1
        ///         Visit Pi
        ///     Return to P_0 from Pn-1
        /// </remarks>
        /// <param name="request"></param>
        /// <returns></returns>
        public PathResponse NearestNeighbor(PathRequest request)
        {
            DateTime startTime = DateTime.Now;
            try
            {                                
                PathResponse response = new Algorithms.Response.PathResponse();

                //Get our starting place.
                PLACE currentPlace = request.places[request.startingPoint];
                currentPlace.unvisited = false;
                PLACE nextPlace = new PLACE();
                int i = 1;
                //While there are unvisited places...
                while (request.places.Exists(p => p.unvisited == true))
                {
                    int index = -1;
                    float bestDistance = 0.0f;

                    foreach (PLACE place in request.places.FindAll(p => p.unvisited == true))
                    {


                        float distance = Helpers.Helper.GetDistance(currentPlace.point, place.point);
                        if (distance <= 0)
                        {
                            throw new Exception("Distance less than 0 error");
                        }

                        if (bestDistance == 0 || distance < bestDistance)
                        {
                            bestDistance = distance;
                            nextPlace = place;
                            index = request.places.FindIndex(p => p == place);
                        }
                    } //After this loop, we should have the next location selected

                    //Create our line.
                    response.lines.Add(new LINE() { startPlace = currentPlace, endPlace = nextPlace, distance = bestDistance, position = i });
                    response.totalDistance += bestDistance; //Keep a running total of the distance traveled.
                    i++;

                    currentPlace = nextPlace;
                    currentPlace.unvisited = false; // see if this works.
                                                    //request.places[i].unvisited = false;
                }
                //Return to the start point when done.
                float lastDistance = Helpers.Helper.GetDistance(currentPlace, request.places[request.startingPoint]);
                response.lines.Add(new LINE() { startPlace = currentPlace, endPlace = request.places[request.startingPoint],
                                                distance = lastDistance, position = i++ });
                response.totalDistance += lastDistance; //Keep a running total of the distance traveled.            

                Program.output.Add(new Output() { startTime = startTime, endTime = DateTime.Now, title = "Nearest Neighbor", message = "Completed", status = "Completed", distance = response.totalDistance, elements = response.lines.Count, type = "Algorithm" });

                return response;
            }
            catch(Exception e)
            {
                Program.output.Add(new Output() { startTime = startTime, endTime = DateTime.Now, title = "Nearest Neighbor", message = e.Message, status = "Error", type = "Exception", elements = request.places.Count });
                return new PathResponse(string.Format("{0} \r\n {1} \r\n {2}", e.StackTrace, e.Message, e.InnerException));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// ClosestPair(P)
        ///     Let n be the number of points in set P
        ///     For i = 1, to n - 1 do
        ///         d = infinity
        ///         For each pair of endpoints (s, s) from distinct vertex chains
        ///             if(dist(s, t) <= d then s_m = s, t_m = t, and d = dist(s, t)
        ///         Connect (s_m, t_m) by an edge
        ///     Connect the two endpoints by an edge
        /// </remarks>
        /// <param name="request"></param>
        /// <returns></returns>
        
        internal PathResponse ClosestPair(PathRequest request)
        {
            int n = request.places.Count;

            for (int i = 0; i < n; i++)
            {
                //float d = -1.0f; 
                //for
            }
            return null;
        }
        /*
        internal PathResponse ClosestPairBruteForce(PathRequest request)
        {
            
        }*/
    }
}
