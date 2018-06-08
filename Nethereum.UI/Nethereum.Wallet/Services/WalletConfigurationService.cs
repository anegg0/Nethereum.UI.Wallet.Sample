﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Nethereum.Wallet.Services
{
    public class WalletConfigurationService:IWalletConfigurationService
    {
        //defaulting to the rinkeby testnet

        public string ClientUrl { get; set; } = "https://rinkeby.infura.io/";
        public bool IsConfigured()
        {
            return !string.IsNullOrEmpty(ClientUrl);
        }

        public Web3.Web3 GetReadOnlyWeb3()
        {
            return new Web3.Web3(ClientUrl);
        }
    }
}
