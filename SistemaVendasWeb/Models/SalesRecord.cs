﻿using SistemaVendasWeb.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaVendasWeb.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }
        public SalesStatus Status { get; set; }

        [Display(Name = "Vendedor")]
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
