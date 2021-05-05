﻿using System.IO;
using System.Reflection;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using UebungsMomentReminder.Contracts.Services;
using UebungsMomentReminder.Core.Contracts.Services;
using UebungsMomentReminder.Core.Services;
using UebungsMomentReminder.Models;
using UebungsMomentReminder.Services;
using UebungsMomentReminder.ViewModels;
using UebungsMomentReminder.Views;

namespace UebungsMomentReminder.Tests.MSTest
{
    [TestClass]
    public class PagesTests
    {
        private readonly IHost _host;

        public PagesTests()
        {
            var appLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location);
            _host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(c => c.SetBasePath(appLocation))
                .ConfigureServices(ConfigureServices)
                .Build();
        }

        private void ConfigureServices(HostBuilderContext context, IServiceCollection services)
        {
            // Core Services
            services.AddSingleton<IFileService, FileService>();

            // Services
            services.AddSingleton<IThemeSelectorService, ThemeSelectorService>();
            services.AddSingleton<ISystemService, SystemService>();
            services.AddSingleton<ISampleDataService, SampleDataService>();
            services.AddSingleton<IPersistAndRestoreService, PersistAndRestoreService>();
            services.AddSingleton<IApplicationInfoService, ApplicationInfoService>();
            services.AddSingleton<IPageService, PageService>();
            services.AddSingleton<INavigationService, NavigationService>();

            // ViewModels
            services.AddTransient<SettingsViewModel>();
            services.AddTransient<MainViewModel>();
            services.AddTransient<LernMailsSubscriberViewModel>();

            // Configuration
            services.Configure<AppConfig>(context.Configuration.GetSection(nameof(AppConfig)));
        }

        // TODO WTS: Add tests for functionality you add to SettingsViewModel.
        [TestMethod]
        public void TestSettingsViewModelCreation()
        {
            var vm = _host.Services.GetService(typeof(SettingsViewModel));
            Assert.IsNotNull(vm);
        }

        [TestMethod]
        public void TestGetSettingsPageType()
        {
            if (_host.Services.GetService(typeof(IPageService)) is IPageService pageService)
            {
                var pageType = pageService.GetPageType(typeof(SettingsViewModel).FullName);
                Assert.AreEqual(typeof(SettingsPage), pageType);
            }
            else
            {
                Assert.Fail($"Can't resolve {nameof(IPageService)}");
            }
        }

        // TODO WTS: Add tests for functionality you add to MainViewModel.
        [TestMethod]
        public void TestMainViewModelCreation()
        {
            var vm = _host.Services.GetService(typeof(MainViewModel));
            Assert.IsNotNull(vm);
        }

        [TestMethod]
        public void TestGetMainPageType()
        {
            if (_host.Services.GetService(typeof(IPageService)) is IPageService pageService)
            {
                var pageType = pageService.GetPageType(typeof(MainViewModel).FullName);
                Assert.AreEqual(typeof(MainPage), pageType);
            }
            else
            {
                Assert.Fail($"Can't resolve {nameof(IPageService)}");
            }
        }

        // TODO WTS: Add tests for functionality you add to LernMailsSubscriberViewModel.
        [TestMethod]
        public void TestLernMailsSubscriberViewModelCreation()
        {
            var vm = _host.Services.GetService(typeof(LernMailsSubscriberViewModel));
            Assert.IsNotNull(vm);
        }

        [TestMethod]
        public void TestGetLernMailsSubscriberPageType()
        {
            if (_host.Services.GetService(typeof(IPageService)) is IPageService pageService)
            {
                var pageType = pageService.GetPageType(typeof(LernMailsSubscriberViewModel).FullName);
                Assert.AreEqual(typeof(LernMailsSubscriberPage), pageType);
            }
            else
            {
                Assert.Fail($"Can't resolve {nameof(IPageService)}");
            }
        }
    }
}
