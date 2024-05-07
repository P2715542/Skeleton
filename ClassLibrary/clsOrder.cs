using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool OrderDispatched { get; set; }
        public DateTime DateOrdered { get; set; }
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public int SofaId { get; set; }
        public int CustomerId { get; set; }
        public int StaffId { get; set; }
    }
}