﻿using Hedgehog.Core.Domain;

namespace Hedgehog.Core.Application
{
    public class CustomerAccount : HedgehogUserAccount
    {
        //public int WebStoreId { get; set; }
        public WebStore WebStore { get; set; }
    }
}
