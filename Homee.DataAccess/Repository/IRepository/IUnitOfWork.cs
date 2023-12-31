﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homee.DataAccess.Repository.IRepository;

public interface IUnitOfWork
{
    Task SaveAsync();

    IDeviceRepo Devices { get; }
    IDeviceStateRepo DeviceStates { get; }
    IRoomRepo Rooms { get; }
}
