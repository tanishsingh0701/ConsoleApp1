using System;

namespace InterfaceExample
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalcuator;

        public OrderProcessor(IShippingCalculator shippingCalculator) 
        {
            _shippingCalcuator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException();
            order.Shipment = new Shipment()
            {
                Cost = _shippingCalcuator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
        };
        }
    }
}
