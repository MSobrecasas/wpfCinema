﻿#pragma checksum "..\..\..\..\FlowDocs\FlowDocUsuario.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C3CCF0BA4F5035D5D44181BBDC66FE4945C0FB46"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ClasesBase.Enlaces;
using System;
using System.ComponentModel;
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
using Vistas.FlowDocs;


namespace Vistas.FlowDocs {
    
    
    /// <summary>
    /// FlowDocUsuario
    /// </summary>
    public partial class FlowDocUsuario : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\..\FlowDocs\FlowDocUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button close;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\FlowDocs\FlowDocUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.FlowDocument DocMain;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\FlowDocs\FlowDocUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnImprimir;
        
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
            System.Uri resourceLocater = new System.Uri("/Vistas;component/flowdocs/flowdocusuario.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\FlowDocs\FlowDocUsuario.xaml"
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
            this.close = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\FlowDocs\FlowDocUsuario.xaml"
            this.close.Click += new System.Windows.RoutedEventHandler(this.close_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DocMain = ((System.Windows.Documents.FlowDocument)(target));
            return;
            case 3:
            this.btnImprimir = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\FlowDocs\FlowDocUsuario.xaml"
            this.btnImprimir.Click += new System.Windows.RoutedEventHandler(this.btnImprimir_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
