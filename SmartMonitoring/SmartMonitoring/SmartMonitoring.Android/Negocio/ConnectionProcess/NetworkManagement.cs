﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using SmartMonitoring.Droid.Negocio.ConnectionProcess;
using SmartMonitoring;
using Android.Net;

[assembly: Dependency(typeof(NetworkManagement))]
namespace SmartMonitoring.Droid.Negocio.ConnectionProcess
{
    public class NetworkManagement : INetworkManagement
    {
        public bool IsOn()
        {
            return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        }
    }
}