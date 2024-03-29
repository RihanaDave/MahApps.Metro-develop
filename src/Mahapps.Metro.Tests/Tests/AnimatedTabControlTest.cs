﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Threading.Tasks;
using System.Windows.Controls;
using MahApps.Metro.Controls;
using MahApps.Metro.Tests.TestHelpers;
using MahApps.Metro.Tests.Views;
using Xunit;

namespace MahApps.Metro.Tests.Tests
{
    public class AnimatedTabControlTest : AutomationTestBase
    {
        [Fact]
        [DisplayTestMethodName]
        public async Task MetroAnimatedSingleRowTabControlShouldSelectTheCorrectTemplate()
        {
            await TestHost.SwitchToAppThread();

            var window = await WindowHelpers.CreateInvisibleWindowAsync<AnimatedTabControlWindow>();
            var templateSelector = window.TryFindResource("TabControlContentTemplateSelector") as TabControlContentTemplateSelector;
            Assert.NotNull(templateSelector);

            var tabControl = window.MetroTabControl;
            Assert.Equal(2, tabControl.Items.Count);

            var tabItem = ((TabItem)tabControl.ItemContainerGenerator.ContainerFromIndex(0));
            var contentPresenter = tabControl.FindChild<ContentPresenter>("PART_SelectedContentHost");
            contentPresenter.ApplyTemplate();
            var textBlock = contentPresenter.FindChild<TextBlock>(null);
            Assert.Equal(((FirstViewModel)tabItem.Content).Name, textBlock.Text);

            tabItem = ((TabItem)tabControl.ItemContainerGenerator.ContainerFromIndex(1));
            window.Invoke(() => tabItem.IsSelected = true);
            contentPresenter = tabControl.FindChild<ContentPresenter>("PART_SelectedContentHost");
            contentPresenter.ApplyTemplate();
            textBlock = contentPresenter.FindChild<TextBlock>(null);
            Assert.Equal(((SecondViewModel)tabItem.Content).Name, textBlock.Text);
        }

        [Fact]
        [DisplayTestMethodName]
        public async Task TabControlWithAnimatedSingleRowTabControlStyleShouldSelectTheCorrectTemplate()
        {
            await TestHost.SwitchToAppThread();

            var window = await WindowHelpers.CreateInvisibleWindowAsync<AnimatedTabControlWindow>();
            var templateSelector = window.TryFindResource("TabControlContentTemplateSelector") as TabControlContentTemplateSelector;
            Assert.NotNull(templateSelector);

            var tabControl = window.NormalTabControl;
            Assert.Equal(2, tabControl.Items.Count);

            var tabItem = ((TabItem)tabControl.ItemContainerGenerator.ContainerFromIndex(0));
            var contentPresenter = tabControl.FindChild<ContentPresenter>("PART_SelectedContentHost");
            contentPresenter.ApplyTemplate();
            var textBlock = contentPresenter.FindChild<TextBlock>(null);
            Assert.Equal(((FirstViewModel)tabItem.Content).Name, textBlock.Text);

            tabItem = ((TabItem)tabControl.ItemContainerGenerator.ContainerFromIndex(1));
            window.Invoke(() => tabItem.IsSelected = true);
            contentPresenter = tabControl.FindChild<ContentPresenter>("PART_SelectedContentHost");
            contentPresenter.ApplyTemplate();
            textBlock = contentPresenter.FindChild<TextBlock>(null);
            Assert.Equal(((SecondViewModel)tabItem.Content).Name, textBlock.Text);
        }

        [Fact]
        [DisplayTestMethodName]
        public async Task MetroAnimatedTabControlShouldSelectTheCorrectTemplate()
        {
            await TestHost.SwitchToAppThread();

            var window = await WindowHelpers.CreateInvisibleWindowAsync<AnimatedTabControlWindow>();
            var templateSelector = window.TryFindResource("TabControlContentTemplateSelector") as TabControlContentTemplateSelector;
            Assert.NotNull(templateSelector);

            var tabControl = window.MetroTabControl2;
            Assert.Equal(2, tabControl.Items.Count);

            var tabItem = ((TabItem)tabControl.ItemContainerGenerator.ContainerFromIndex(0));
            var contentPresenter = tabControl.FindChild<ContentPresenter>("PART_SelectedContentHost");
            contentPresenter.ApplyTemplate();
            var textBlock = contentPresenter.FindChild<TextBlock>(null);
            Assert.Equal(((FirstViewModel)tabItem.Content).Name, textBlock.Text);

            tabItem = ((TabItem)tabControl.ItemContainerGenerator.ContainerFromIndex(1));
            window.Invoke(() => tabItem.IsSelected = true);
            contentPresenter = tabControl.FindChild<ContentPresenter>("PART_SelectedContentHost");
            contentPresenter.ApplyTemplate();
            textBlock = contentPresenter.FindChild<TextBlock>(null);
            Assert.Equal(((SecondViewModel)tabItem.Content).Name, textBlock.Text);
        }

        [Fact]
        [DisplayTestMethodName]
        public async Task TabControlWithAnimatedTabControlStyleShouldSelectTheCorrectTemplate()
        {
            await TestHost.SwitchToAppThread();

            var window = await WindowHelpers.CreateInvisibleWindowAsync<AnimatedTabControlWindow>();
            var templateSelector = window.TryFindResource("TabControlContentTemplateSelector") as TabControlContentTemplateSelector;
            Assert.NotNull(templateSelector);

            var tabControl = window.NormalTabControl2;
            Assert.Equal(2, tabControl.Items.Count);

            var tabItem = ((TabItem)tabControl.ItemContainerGenerator.ContainerFromIndex(0));
            var contentPresenter = tabControl.FindChild<ContentPresenter>("PART_SelectedContentHost");
            contentPresenter.ApplyTemplate();
            var textBlock = contentPresenter.FindChild<TextBlock>(null);
            Assert.Equal(((FirstViewModel)tabItem.Content).Name, textBlock.Text);

            tabItem = ((TabItem)tabControl.ItemContainerGenerator.ContainerFromIndex(1));
            window.Invoke(() => tabItem.IsSelected = true);
            contentPresenter = tabControl.FindChild<ContentPresenter>("PART_SelectedContentHost");
            contentPresenter.ApplyTemplate();
            textBlock = contentPresenter.FindChild<TextBlock>(null);
            Assert.Equal(((SecondViewModel)tabItem.Content).Name, textBlock.Text);
        }
    }
}