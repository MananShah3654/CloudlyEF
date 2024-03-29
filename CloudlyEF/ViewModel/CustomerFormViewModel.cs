﻿using CloudlyEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudlyEF.ViewModel
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipType { get; set; }
        public Customers Customer { get; set; }
    }
}