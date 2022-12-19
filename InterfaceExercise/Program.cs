using InterfaceExercise;
using System;
using System.Collections.Generic;

var car = new Car();
var truck = new Truck();
var vehicle = new List<IVehicle>() { car, truck, };

foreach (var vehicles in vehicle)
{
    vehicles.Drive();
    vehicles.ChangeGears(true);
    vehicle.Reverse();
    ///// I DON'T KNOW HOW TO FIX THIS ISSUE.....NEED HELP!@!!!
}
