﻿#pragma checksum "..\..\..\..\Vistas\Ventas.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BEC0B929D0FD612667FC05F67E56E1248E5D741D"
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
    /// Ventas
    /// </summary>
    public partial class Ventas : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 14 "..\..\..\..\Vistas\Ventas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_Guardar;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Vistas\Ventas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridVentas;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\Vistas\Ventas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSubtotal;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\Vistas\Ventas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIva;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\Vistas\Ventas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTotal;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\Vistas\Ventas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbProductos;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\Vistas\Ventas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCantidad;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\Vistas\Ventas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrecio;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\Vistas\Ventas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIDVenta;
        
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
            System.Uri resourceLocater = new System.Uri("/ProyectoFinal-23CV;V1.0.0.0;component/vistas/ventas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Vistas\Ventas.xaml"
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
            this.BT_Guardar = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\Vistas\Ventas.xaml"
            this.BT_Guardar.Click += new System.Windows.RoutedEventHandler(this.BTGuardar);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GridVentas = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.txtSubtotal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtIva = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtTotal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.cmbProductos = ((System.Windows.Controls.ComboBox)(target));
            
            #line 95 "..\..\..\..\Vistas\Ventas.xaml"
            this.cmbProductos.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbProductos_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 95 "..\..\..\..\Vistas\Ventas.xaml"
            this.cmbProductos.Loaded += new System.Windows.RoutedEventHandler(this.cmbProductos_Loaded);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtCantidad = ((System.Windows.Controls.TextBox)(target));
            
            #line 96 "..\..\..\..\Vistas\Ventas.xaml"
            this.txtCantidad.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtCantidad_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtPrecio = ((System.Windows.Controls.TextBox)(target));
            
            #line 97 "..\..\..\..\Vistas\Ventas.xaml"
            this.txtPrecio.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtPrecio_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.txtIDVenta = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 110 "..\..\..\..\Vistas\Ventas.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 70 "..\..\..\..\Vistas\Ventas.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTImprimirTicket_Click);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 77 "..\..\..\..\Vistas\Ventas.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Editar_Click);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 84 "..\..\..\..\Vistas\Ventas.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Eliminar_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

