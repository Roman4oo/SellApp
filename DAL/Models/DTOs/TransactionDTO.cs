﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DTOs
{
    public class TransactionDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }

    }
}