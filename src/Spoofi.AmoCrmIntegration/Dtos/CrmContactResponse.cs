﻿using System.Collections.Generic;
using Spoofi.AmoCrmIntegration.AmoCrmEntity;
using Spoofi.AmoCrmIntegration.Interface;

namespace Spoofi.AmoCrmIntegration.Dtos
{
    public class CrmContactResponse : IAmoCrmResponse
    {
        public CrmContactResponseDto Response { get; set; }
    }

    public class CrmContactResponseDto
    {
        public List<CrmContact> Contacts { get; set; }
    }
}