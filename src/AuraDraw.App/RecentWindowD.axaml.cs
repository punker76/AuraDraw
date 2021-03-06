﻿using Aura.CommonCore.CommonWindows;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using System;

namespace AuraDraw.App
{
    public class RecentWindowD : RecentElementsWindowxaml
    {
        public RecentWindowD()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.TitleText = new GlobalData().GetName();

            this.Button1Text = "Nuevo Documento";
            this.Button2Text = "Abrir Documento";
            this.Button3Text = "Continuar sin ningún Documento";

            this.Icon = new WindowIcon(new Bitmap(@"Assets/Logo.png"));
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void ClickOnButton3(object sender, EventArgs e)
        {
            base.ClickOnButton3(sender, e);

            var mainwindow = new MainWindow();
            mainwindow.Show();

            this.Close();
        }
    }
}
