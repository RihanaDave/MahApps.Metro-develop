﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Threading.Tasks;
using System.Windows.Controls;
using MahApps.Metro.Controls;
using MahApps.Metro.Tests.TestHelpers;
using Xunit;

namespace MahApps.Metro.Tests.Tests
{
    public class TileTest : AutomationTestBase
    {
        [Fact]
        [DisplayTestMethodName]
        public async Task TemplateBindingShouldGetTheFontSize()
        {
            await TestHost.SwitchToAppThread();

            var testTile = new Tile();
            var window = await WindowHelpers.CreateInvisibleWindowAsync<MetroWindow>(w =>
                {
                    var grid = new Grid();
                    grid.Children.Add(testTile);
                    w.Content = grid;
                });

            window.Invoke(() =>
                {
                    // default values

                    Assert.Equal(16d, testTile.FindChild<AccessText>(string.Empty).FontSize);
                    Assert.Equal(28d, testTile.FindChild<TextBlock>(string.Empty).FontSize);

                    // now change it

                    var fontSize = 42d;

                    testTile.TitleFontSize = fontSize;
                    Assert.Equal(fontSize, testTile.FindChild<AccessText>(string.Empty).FontSize);

                    testTile.CountFontSize = fontSize;
                    Assert.Equal(fontSize, testTile.FindChild<TextBlock>(string.Empty).FontSize);
                });
        }
    }
}