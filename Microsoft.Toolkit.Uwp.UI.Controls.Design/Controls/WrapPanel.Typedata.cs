// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.Toolkit.Uwp.UI.Controls.Design
{
#if VS_DESIGNER_PROCESS_ISOLATION
    internal static partial class ControlTypes
    {
        internal static readonly Type WrapPanel = typeof(WrapPanel);
    }
#else
    internal static partial class ControlTypes
    {
        internal const string WrapPanel = RootNamespace + "." + nameof(WrapPanel);
    }

    internal static class WrapPanel
    {
        internal const string HorizontalSpacing = nameof(HorizontalSpacing);
        internal const string Orientation = nameof(Orientation);
        internal const string VerticalSpacing = nameof(VerticalSpacing);
    }
#endif
}