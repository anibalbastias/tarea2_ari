﻿#pragma checksum "..\..\FuncionariosWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7B8BE488CEB7CED6AF26A83D9E0D598B"
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
    /// FuncionariosWindow
    /// </summary>
    public partial class FuncionariosWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\FuncionariosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Tarea2_ARI__Bastias___Rojas_.FuncionariosWindow windowFuncionarios;
        
        #line default
        #line hidden
        
        
        #line 6 "..\..\FuncionariosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridFuncionarios;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\FuncionariosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIngresarFuncionario;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\FuncionariosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnListarFuncionario;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\FuncionariosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVolver;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\FuncionariosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtPrincipal;
        
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
            System.Uri resourceLocater = new System.Uri("/Tarea2-ARI (Bastias - Rojas);component/funcionarioswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FuncionariosWindow.xaml"
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
            this.windowFuncionarios = ((Tarea2_ARI__Bastias___Rojas_.FuncionariosWindow)(target));
            return;
            case 2:
            this.gridFuncionarios = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.btnIngresarFuncionario = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\FuncionariosWindow.xaml"
            this.btnIngresarFuncionario.Click += new System.Windows.RoutedEventHandler(this.btnIngresarFuncionario_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnListarFuncionario = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\FuncionariosWindow.xaml"
            this.btnListarFuncionario.Click += new System.Windows.RoutedEventHandler(this.btnListarFuncionario_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnVolver = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\FuncionariosWindow.xaml"
            this.btnVolver.Click += new System.Windows.RoutedEventHandler(this.btnVolver_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtPrincipal = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

