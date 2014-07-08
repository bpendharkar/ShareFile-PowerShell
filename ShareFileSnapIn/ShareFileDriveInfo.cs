﻿using ShareFile.Api.Client;
using System;
using System.Management.Automation;

namespace ShareFile.Api.Powershell
{
    public class ShareFileDriveInfo : PSDriveInfo
    {
        public ShareFileClient Client { get; private set; }

        public Uri RootUri { get; set; }

        public Models.Item RootItem { get; set; }

        public ShareFileDriveInfo(PSDriveInfo driveInfo, ShareFileDriveParameters driveParams)
            : base( driveInfo )
        {
            Client = driveParams.Client.Client;
            RootUri = driveParams.RootUri;
        }      
    }
}
