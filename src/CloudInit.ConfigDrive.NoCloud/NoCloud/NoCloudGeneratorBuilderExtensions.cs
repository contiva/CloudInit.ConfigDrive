﻿using Haipa.CloudInit.ConfigDrive.Generator;

namespace Haipa.CloudInit.ConfigDrive.NoCloud
{
    public static class NoCloudGeneratorBuilderExtensions
    {
        public static NoCloudGeneratorBuilder NoCloud(this IGenerateableBuilder builder, NoCloudConfigDriveMetaData metaData)
        {
            return new NoCloudGeneratorBuilder(builder) { Metadata = metaData }; ;
        }
    }
}