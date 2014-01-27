﻿using System.Collections.Generic;

namespace SalesforceClient.Responses
{
    public class DescribeGlobalResponse
    {
        public string Encoding { get; set; }
        public List<DescribeResponse> SObjects { get; set; }
        public int MaxBatchSize { get; set; }
    }
}