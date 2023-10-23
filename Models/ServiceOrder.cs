namespace NøstedProsjekt.Models
{
    public class ServiceOrder
    {
        public int Id { get; set; }
        public string Customer { get; set; } = string.Empty;
        public string RecivedDate { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string YearModell { get; set; } = string.Empty;
        public string ProductType { get; set; } = string.Empty;
        public string Insurance { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public string WhatIsPlanned { get; set; } = string.Empty;
        public string OperationDescription { get; set; } = string.Empty;
        public string UsedParts { get; set; } = string.Empty;
        public string WorkHours { get; set; } = string.Empty;
        public string FinishedDate { get; set; } = string.Empty;
        public string UsedPartsReturned { get; set; } = string.Empty;
        public string ShippingMethod { get; set; } = string.Empty;
        public string SignCustomer { get; set; } = string.Empty;
        public string SignMechanic { get; set; } = string.Empty;
    }
}
