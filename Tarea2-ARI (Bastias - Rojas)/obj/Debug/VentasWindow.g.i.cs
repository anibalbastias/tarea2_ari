﻿#pragma checksum "..\..\VentasWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EB3168201616CA2FD4B1004CECFE7EC3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34003
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Tarea2_ARI__Bastias___Rojas_ {
    
    
    /// <summary>
    /// VentasWindow
    /// </summary>
    public partial class VentasWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\VentasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVolver;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\VentasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtPrincipal;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\VentasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listProductos;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\VentasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPagar;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\VentasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtPrincipal_Copy;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\VentasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFuncionariosDestacados;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\VentasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtPrincipal_Copy1;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\VentasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listCompras;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tarea2-ARI (Bastias - Rojas);component/ventaswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VentasWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnVolver = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\VentasWindow.xaml"
            this.btnVolver.Click += new System.Windows.RoutedEventHandler(this.btnVolver_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtPrincipal = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.listProductos = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.btnPagar = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\VentasWindow.xaml"
            this.btnPagar.Click += new System.Windows.RoutedEventHandler(this.btnPagar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtPrincipal_Copy = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.btnFuncionariosDestacados = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\VentasWindow.xaml"
            this.btnFuncionariosDestacados.Click += new System.Windows.RoutedEventHandler(this.btnFuncionariosDestacados_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtPrincipal_Copy1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.listCompras = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

