﻿#pragma checksum "..\..\..\..\Paginas\ABMClientes.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C5891EB6B07CF05F21D53C56CD1577D369D75EA4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
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
using Vistas.Control_de_Usuario;


namespace Vistas.Paginas {
    
    
    /// <summary>
    /// ABMClientes
    /// </summary>
    public partial class ABMClientes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\Paginas\ABMClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button close;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Paginas\ABMClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Vistas.Control_de_Usuario.UCDatos txtNombre;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Paginas\ABMClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Vistas.Control_de_Usuario.UCDatos txtApellido;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Paginas\ABMClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Vistas.Control_de_Usuario.UCDatos txtDNI;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Paginas\ABMClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Vistas.Control_de_Usuario.UCDatos txtTelefono;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Paginas\ABMClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Vistas.Control_de_Usuario.UCDatos txtEmail;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Paginas\ABMClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Guardar;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Paginas\ABMClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Cancelar;
        
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
            System.Uri resourceLocater = new System.Uri("/Vistas;component/paginas/abmclientes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Paginas\ABMClientes.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.close = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\Paginas\ABMClientes.xaml"
            this.close.Click += new System.Windows.RoutedEventHandler(this.close_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtNombre = ((Vistas.Control_de_Usuario.UCDatos)(target));
            return;
            case 3:
            this.txtApellido = ((Vistas.Control_de_Usuario.UCDatos)(target));
            return;
            case 4:
            this.txtDNI = ((Vistas.Control_de_Usuario.UCDatos)(target));
            return;
            case 5:
            this.txtTelefono = ((Vistas.Control_de_Usuario.UCDatos)(target));
            return;
            case 6:
            this.txtEmail = ((Vistas.Control_de_Usuario.UCDatos)(target));
            return;
            case 7:
            this.btn_Guardar = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\Paginas\ABMClientes.xaml"
            this.btn_Guardar.Click += new System.Windows.RoutedEventHandler(this.Guardar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_Cancelar = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\Paginas\ABMClientes.xaml"
            this.btn_Cancelar.Click += new System.Windows.RoutedEventHandler(this.Cancelar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

