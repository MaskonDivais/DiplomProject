﻿#pragma checksum "C:\Users\PC\Desktop\Distance Learning Odessa College_All\Distance Learning Odessa College-Ink\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9FB3A0AC4BF6668CCA2E729130ED850A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GettingStarted_Ink
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_InkToolbar_TargetInkCanvas(global::Windows.UI.Xaml.Controls.InkToolbar obj, global::Windows.UI.Xaml.Controls.InkCanvas value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Controls.InkCanvas) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Controls.InkCanvas), targetNullValue);
                }
                obj.TargetInkCanvas = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::GettingStarted_Ink.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.InkToolbar obj10;

            public MainPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 10: // MainPage.xaml line 25
                        this.obj10 = (global::Windows.UI.Xaml.Controls.InkToolbar)target;
                        break;
                    default:
                        break;
                }
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::GettingStarted_Ink.MainPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::GettingStarted_Ink.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_inkCanvas(obj.inkCanvas, phase);
                    }
                }
            }
            private void Update_inkCanvas(global::Windows.UI.Xaml.Controls.InkCanvas obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 25
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_InkToolbar_TargetInkCanvas(this.obj10, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // MainPage.xaml line 1
                {
                    this.Main = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2: // MainPage.xaml line 16
                {
                    this.HeaderPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3: // MainPage.xaml line 23
                {
                    this.ToolPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4: // MainPage.xaml line 45
                {
                    this.drawingCanvas = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5: // MainPage.xaml line 68
                {
                    this.recognizeText = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.recognizeText).Click += this.recognizeText_ClickAsync;
                }
                break;
            case 6: // MainPage.xaml line 73
                {
                    this.recognitionResult = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // MainPage.xaml line 80
                {
                    this.recognizeShape = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.recognizeShape).Click += this.recognizeShape_ClickAsync;
                }
                break;
            case 8: // MainPage.xaml line 49
                {
                    this.canvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 9: // MainPage.xaml line 53
                {
                    this.inkCanvas = (global::Windows.UI.Xaml.Controls.InkCanvas)(target);
                }
                break;
            case 10: // MainPage.xaml line 25
                {
                    this.inkToolbar = (global::Windows.UI.Xaml.Controls.InkToolbar)(target);
                }
                break;
            case 11: // MainPage.xaml line 32
                {
                    this.buttonSave = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonSave).Click += this.buttonSave_ClickAsync;
                }
                break;
            case 12: // MainPage.xaml line 37
                {
                    this.buttonLoad = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonLoad).Click += this.buttonLoad_ClickAsync;
                }
                break;
            case 13: // MainPage.xaml line 17
                {
                    this.Header = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // MainPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}
