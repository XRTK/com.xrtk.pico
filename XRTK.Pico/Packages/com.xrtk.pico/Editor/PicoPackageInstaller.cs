// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.IO;
using UnityEditor;
using XRTK.Editor;
using XRTK.Editor.Utilities;
using XRTK.Extensions;

namespace XRTK.Pico.Editor
{
    [InitializeOnLoad]
    internal static class PicoPackageInstaller
    {
        private static readonly string DefaultPath = $"{MixedRealityPreferences.ProfileGenerationPath}Pico";
        private static readonly string HiddenPath = Path.GetFullPath($"{PathFinderUtility.ResolvePath<IPathFinder>(typeof(PicoPathFinder)).ForwardSlashes()}\\{MixedRealityPreferences.HIDDEN_PROFILES_PATH}");

        static PicoPackageInstaller()
        {
            if (!EditorPreferences.Get($"{nameof(PicoPackageInstaller)}", false))
            {
                EditorPreferences.Set($"{nameof(PicoPackageInstaller)}", PackageInstaller.TryInstallAssets(HiddenPath, DefaultPath));
            }
        }
    }
}
