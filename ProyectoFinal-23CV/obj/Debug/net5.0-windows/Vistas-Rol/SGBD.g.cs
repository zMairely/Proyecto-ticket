﻿#pragma checksum "..\..\..\..\Vistas-Rol\SGBD.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0EC73089ED7DDC638D000A544623A99EBE4F273D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ProyectoFinal_23CV.Vistas_Wpf;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ProyectoFinal_23CV.Vistas_Wpf {
    
    
    /// <summary>
    /// SGBD
    /// </summary>
    public partial class SGBD : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Vistas-Rol\SGBD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnaggPoducto;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Vistas-Rol\SGBD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnaggUsuario;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Vistas-Rol\SGBD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVentasAdmin;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProyectoFinal-23CV;component/vistas-rol/sgbd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Vistas-Rol\SGBD.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnaggPoducto = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\Vistas-Rol\SGBD.xaml"
            this.btnaggPoducto.Click += new System.Windows.RoutedEventHandler(this.btnaggPoducto_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnaggUsuario = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\Vistas-Rol\SGBD.xaml"
            this.btnaggUsuario.Click += new System.Windows.RoutedEventHandler(this.btnaggUsuario_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnVentasAdmin = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\Vistas-Rol\SGBD.xaml"
            this.btnVentasAdmin.Click += new System.Windows.RoutedEventHandler(this.btnVentasAdmin_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 76 "..\..\..\..\Vistas-Rol\SGBD.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
