using System.Runtime.InteropServices;

namespace OOP02G03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01
            //Class refrance tybe , heap , pass by reference , يدعم التوريث من  class  تاني , ممكن يبقي ب null 

            //struct value type , stack , pass by value , لا يدعم التوريث من struct تاني , لا يمكن ان يكون ب null 
            #endregion
            #region 02
            //a) parent class : shipment ,  b) child class:ExpressShipment , c) members are inherited by ExpressShipment :Trackingcode ,
            //d) Why is inheritance better than duplicating the same code in multiple classes?
            //     reason: Inheritance promotes code reusability and maintainability.By creating a parent class with common functionality, child classes can inherit that functionality without duplicating code.
            #endregion
            #region 03
            //public virtual void PrintShipment()
            //{
            //    Console.WriteLine(
            //        "Tracking Code: " + TrackingCode);

            //    Console.WriteLine(
            //        "Description: " + Description);

            //    Console.WriteLine(
            //        "Weight: " + Weight + " KG");

            //    Console.WriteLine(
            //        "Delivery Fee: " + DeliveryFee + " EGP");

            //    Console.WriteLine(
            //        "Destination: " +
            //        Destination.GetFullAddress());

            //    Console.WriteLine(
            //        "Estimated Cost: " +
            //        EstimatedCost + " EGP");


            #endregion

            #region 04
            //Deliverycenter center = new Deliverycenter("Cairo Center");
            #endregion
            #region 05
            //StandardShipment std = new StandardShipment("SH001", "Laptop", 3, 80);
            //ExpressShipment exp = new ExpressShipment("SH002", "Mobile Phone", 2, 60, 30);
            //var dest = new DeliveryAddress(/* fill required fields: street, city, etc. */);
            //InternationalShipment intl = new InternationalShipment(
            //    "SH003", "Television", 8m, 120m, dest, "Germany", 100m);
            #endregion
            #region 06
            //center.AddShipment(std);
            //center.AddShipment(exp);
            //center.AddShipment(intl);
            #endregion
        }        
    }             
}
