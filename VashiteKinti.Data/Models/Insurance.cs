﻿using System;
using System.Collections.Generic;
using System.Text;
using VashiteKinti.Data.Enums;

namespace VashiteKinti.Data.Models
{
    /// <summary>
    /// ** NOTE ** - This is a dummy model needed to populate application's navigation
    /// bar and content. Multiple dummy models implemented throughout the application.
    /// Only real and valid models should be the Deposit and Bank models.
    /// </summary>
    public class Insurance
    {
        public int Id { get; set; }

        public virtual Bank Bank { get; set; }
        public int BankId { get; set; }

        public InsuranceTypes InsuranceType { get; set; }
    }
}
