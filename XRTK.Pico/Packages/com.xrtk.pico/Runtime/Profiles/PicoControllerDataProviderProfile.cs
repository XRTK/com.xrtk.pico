// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using XRTK.Definitions.Controllers;
using XRTK.Definitions.Utilities;
using XRTK.Pico.Providers.Controllers;

namespace XRTK.Pico.Profiles
{
    public class PicoControllerDataProviderProfile : BaseMixedRealityControllerDataProviderProfile
    {
        public override ControllerDefinition[] GetDefaultControllerOptions()
        {
            return new[]
            {
                new ControllerDefinition(typeof(PicoController), Handedness.Left),
                new ControllerDefinition(typeof(PicoController), Handedness.Right)
            };
        }
    }
}
