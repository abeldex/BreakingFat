﻿#pragma checksum "..\..\BuscarCliente.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "948CD88AFBEC1B1002C5DD26F37DFDC34D01C317"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using SistemaGym;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace SistemaGym {
    
    
    /// <summary>
    /// BuscarCliente
    /// </summary>
    public partial class BuscarCliente : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\BuscarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_salir;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\BuscarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_buscar;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\BuscarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lb_clientes;
        
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
            System.Uri resourceLocater = new System.Uri("/SistemaGym;component/buscarcliente.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BuscarCliente.xaml"
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
            this.btn_salir = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\BuscarCliente.xaml"
            this.btn_salir.Click += new System.Windows.RoutedEventHandler(this.btn_salir_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_buscar = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\BuscarCliente.xaml"
            this.txt_buscar.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_buscar_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lb_clientes = ((System.Windows.Controls.ListBox)(target));
            
            #line 46 "..\..\BuscarCliente.xaml"
            this.lb_clientes.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.lb_clientes_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
