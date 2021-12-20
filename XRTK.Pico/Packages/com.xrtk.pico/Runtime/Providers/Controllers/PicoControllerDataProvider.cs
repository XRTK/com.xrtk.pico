// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using XRTK.Attributes;
using XRTK.Definitions.Platforms;
using XRTK.Interfaces.InputSystem;
using XRTK.Pico.Profiles;
using XRTK.Providers.Controllers;

namespace XRTK.Pico.Providers.Controllers
{
    [RuntimePlatform(typeof(PicoPlatform))]
    [System.Runtime.InteropServices.Guid("ab929180-f710-4f29-966b-08be77135020")]
    public class PicoControllerDataProvider : BaseControllerDataProvider
    {
        /// <inheritdoc />
        public PicoControllerDataProvider(string name, uint priority, PicoControllerDataProviderProfile profile, IMixedRealityInputSystem parentService)
            : base(name, priority, profile, parentService)
        {
        }
    }
}
