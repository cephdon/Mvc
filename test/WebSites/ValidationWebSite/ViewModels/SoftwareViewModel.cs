// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Mvc;
using ValidationWebSite.Models;

namespace ValidationWebSite.ViewModels
{
    [ModelMetadataType(typeof(Software))]
    public class SoftwareViewModel 
    {
        [RegularExpression("^[0-9]*$")]
        public string Version { get; set; }

        public DateTime DatePurchased { get; set; }

        public int Price { get; set; }

        public string Contact { get; set; }

        public string Country { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string CompanyName { get; set; }
    }
}