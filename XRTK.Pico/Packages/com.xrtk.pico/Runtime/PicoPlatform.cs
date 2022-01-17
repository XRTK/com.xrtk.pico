// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using XRTK.Interfaces;

namespace XRTK.Definitions.Platforms
{
    /// <summary>
    /// Used by the XRTK to signal that the feature is available on the Pico platform.
    /// </summary>
    [System.Runtime.InteropServices.Guid("91d05795-d44e-4a4d-8055-e770b592137f")]
    public class PicoPlatform : AndroidPlatform
    {
        /// <inheritdoc />
        public override bool IsAvailable => true; // TODO

        /// <inheritdoc />
        public override IMixedRealityPlatform[] PlatformOverrides { get; } =
        {
            new AndroidPlatform()
        };

#if UNITY_EDITOR
        /// <inheritdoc />
        public override bool IsBuildTargetAvailable => base.IsBuildTargetAvailable; // TODO

        /// <inheritdoc />
        public override UnityEditor.BuildTarget[] ValidBuildTargets { get; } =
        {
            UnityEditor.BuildTarget.Android,
        };
#endif // UNITY_EDITOR
    }
}