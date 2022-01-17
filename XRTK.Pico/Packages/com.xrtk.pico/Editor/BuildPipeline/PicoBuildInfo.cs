// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Linq;
using UnityEditor;
using UnityEditor.Build.Reporting;
using XRTK.Attributes;
using XRTK.Definitions.Platforms;
using XRTK.Interfaces;
using XRTK.Services;

namespace XRTK.Editor.BuildPipeline
{
    [RuntimePlatform(typeof(PicoPlatform))]
    public class PicoBuildInfo : AndroidBuildInfo
    {
        /// <inheritdoc />
        public override IMixedRealityPlatform BuildPlatform => new PicoPlatform();

        /// <inheritdoc />
        public override void OnPreProcessBuild(BuildReport report)
        {
            base.OnPreProcessBuild(report);

            if (!MixedRealityToolkit.ActivePlatforms.Contains(BuildPlatform) ||
                EditorUserBuildSettings.activeBuildTarget != BuildTarget)
            {
                return;
            }

            if (BuildPlatform.GetType() == typeof(PicoPlatform))
            {
                // TODO generate manifest
            }
        }
    }
}