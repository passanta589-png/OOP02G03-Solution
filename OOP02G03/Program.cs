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
        }
}
}
