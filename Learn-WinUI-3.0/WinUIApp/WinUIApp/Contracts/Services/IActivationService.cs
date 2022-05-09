﻿using System.Threading.Tasks;

namespace WinUIApp.Contracts.Services
{
    public interface IActivationService
    {
        Task ActivateAsync(object activationArgs);
    }
}
