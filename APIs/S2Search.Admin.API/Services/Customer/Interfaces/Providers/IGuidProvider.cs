﻿using System;

namespace Services.Customer.Interfaces.Providers
{
    public interface IGuidProvider
    {
        Guid NewGuid();
    }
}
