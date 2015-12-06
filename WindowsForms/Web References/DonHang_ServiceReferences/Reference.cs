﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18408.
// 
#pragma warning disable 1591

namespace WindowsForms.DonHang_ServiceReferences {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="DonHang_ServiceSoap", Namespace="http://tempuri.org/")]
    public partial class DonHang_Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback DonHang_GetAllOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetInfo_KhachHangOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetInfo_KhachHangPhoneOperationCompleted;
        
        private System.Threading.SendOrPostCallback DonHang_GetByDateOperationCompleted;
        
        private System.Threading.SendOrPostCallback DonHang_GetByCustomerOperationCompleted;
        
        private System.Threading.SendOrPostCallback DonHang_GetLastIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback Delete_DonHangOperationCompleted;
        
        private System.Threading.SendOrPostCallback Update_DonHangOperationCompleted;
        
        private System.Threading.SendOrPostCallback Insert_DonHangOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public DonHang_Service() {
            this.Url = global::WindowsForms.Properties.Settings.Default.WindowsForms_DonHang_ServiceReference_DonHang_Service;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event DonHang_GetAllCompletedEventHandler DonHang_GetAllCompleted;
        
        /// <remarks/>
        public event GetInfo_KhachHangCompletedEventHandler GetInfo_KhachHangCompleted;
        
        /// <remarks/>
        public event GetInfo_KhachHangPhoneCompletedEventHandler GetInfo_KhachHangPhoneCompleted;
        
        /// <remarks/>
        public event DonHang_GetByDateCompletedEventHandler DonHang_GetByDateCompleted;
        
        /// <remarks/>
        public event DonHang_GetByCustomerCompletedEventHandler DonHang_GetByCustomerCompleted;
        
        /// <remarks/>
        public event DonHang_GetLastIDCompletedEventHandler DonHang_GetLastIDCompleted;
        
        /// <remarks/>
        public event Delete_DonHangCompletedEventHandler Delete_DonHangCompleted;
        
        /// <remarks/>
        public event Update_DonHangCompletedEventHandler Update_DonHangCompleted;
        
        /// <remarks/>
        public event Insert_DonHangCompletedEventHandler Insert_DonHangCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DonHang_GetAll", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable DonHang_GetAll() {
            object[] results = this.Invoke("DonHang_GetAll", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void DonHang_GetAllAsync() {
            this.DonHang_GetAllAsync(null);
        }
        
        /// <remarks/>
        public void DonHang_GetAllAsync(object userState) {
            if ((this.DonHang_GetAllOperationCompleted == null)) {
                this.DonHang_GetAllOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDonHang_GetAllOperationCompleted);
            }
            this.InvokeAsync("DonHang_GetAll", new object[0], this.DonHang_GetAllOperationCompleted, userState);
        }
        
        private void OnDonHang_GetAllOperationCompleted(object arg) {
            if ((this.DonHang_GetAllCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DonHang_GetAllCompleted(this, new DonHang_GetAllCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetInfo_KhachHang", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable GetInfo_KhachHang(int ma_kh) {
            object[] results = this.Invoke("GetInfo_KhachHang", new object[] {
                        ma_kh});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void GetInfo_KhachHangAsync(int ma_kh) {
            this.GetInfo_KhachHangAsync(ma_kh, null);
        }
        
        /// <remarks/>
        public void GetInfo_KhachHangAsync(int ma_kh, object userState) {
            if ((this.GetInfo_KhachHangOperationCompleted == null)) {
                this.GetInfo_KhachHangOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetInfo_KhachHangOperationCompleted);
            }
            this.InvokeAsync("GetInfo_KhachHang", new object[] {
                        ma_kh}, this.GetInfo_KhachHangOperationCompleted, userState);
        }
        
        private void OnGetInfo_KhachHangOperationCompleted(object arg) {
            if ((this.GetInfo_KhachHangCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetInfo_KhachHangCompleted(this, new GetInfo_KhachHangCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetInfo_KhachHangPhone", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable GetInfo_KhachHangPhone(string sdt) {
            object[] results = this.Invoke("GetInfo_KhachHangPhone", new object[] {
                        sdt});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void GetInfo_KhachHangPhoneAsync(string sdt) {
            this.GetInfo_KhachHangPhoneAsync(sdt, null);
        }
        
        /// <remarks/>
        public void GetInfo_KhachHangPhoneAsync(string sdt, object userState) {
            if ((this.GetInfo_KhachHangPhoneOperationCompleted == null)) {
                this.GetInfo_KhachHangPhoneOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetInfo_KhachHangPhoneOperationCompleted);
            }
            this.InvokeAsync("GetInfo_KhachHangPhone", new object[] {
                        sdt}, this.GetInfo_KhachHangPhoneOperationCompleted, userState);
        }
        
        private void OnGetInfo_KhachHangPhoneOperationCompleted(object arg) {
            if ((this.GetInfo_KhachHangPhoneCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetInfo_KhachHangPhoneCompleted(this, new GetInfo_KhachHangPhoneCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DonHang_GetByDate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable DonHang_GetByDate(System.DateTime fromDay, System.DateTime toDay) {
            object[] results = this.Invoke("DonHang_GetByDate", new object[] {
                        fromDay,
                        toDay});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void DonHang_GetByDateAsync(System.DateTime fromDay, System.DateTime toDay) {
            this.DonHang_GetByDateAsync(fromDay, toDay, null);
        }
        
        /// <remarks/>
        public void DonHang_GetByDateAsync(System.DateTime fromDay, System.DateTime toDay, object userState) {
            if ((this.DonHang_GetByDateOperationCompleted == null)) {
                this.DonHang_GetByDateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDonHang_GetByDateOperationCompleted);
            }
            this.InvokeAsync("DonHang_GetByDate", new object[] {
                        fromDay,
                        toDay}, this.DonHang_GetByDateOperationCompleted, userState);
        }
        
        private void OnDonHang_GetByDateOperationCompleted(object arg) {
            if ((this.DonHang_GetByDateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DonHang_GetByDateCompleted(this, new DonHang_GetByDateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DonHang_GetByCustomer", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable DonHang_GetByCustomer(int ma_kh) {
            object[] results = this.Invoke("DonHang_GetByCustomer", new object[] {
                        ma_kh});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void DonHang_GetByCustomerAsync(int ma_kh) {
            this.DonHang_GetByCustomerAsync(ma_kh, null);
        }
        
        /// <remarks/>
        public void DonHang_GetByCustomerAsync(int ma_kh, object userState) {
            if ((this.DonHang_GetByCustomerOperationCompleted == null)) {
                this.DonHang_GetByCustomerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDonHang_GetByCustomerOperationCompleted);
            }
            this.InvokeAsync("DonHang_GetByCustomer", new object[] {
                        ma_kh}, this.DonHang_GetByCustomerOperationCompleted, userState);
        }
        
        private void OnDonHang_GetByCustomerOperationCompleted(object arg) {
            if ((this.DonHang_GetByCustomerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DonHang_GetByCustomerCompleted(this, new DonHang_GetByCustomerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DonHang_GetLastID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable DonHang_GetLastID() {
            object[] results = this.Invoke("DonHang_GetLastID", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void DonHang_GetLastIDAsync() {
            this.DonHang_GetLastIDAsync(null);
        }
        
        /// <remarks/>
        public void DonHang_GetLastIDAsync(object userState) {
            if ((this.DonHang_GetLastIDOperationCompleted == null)) {
                this.DonHang_GetLastIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDonHang_GetLastIDOperationCompleted);
            }
            this.InvokeAsync("DonHang_GetLastID", new object[0], this.DonHang_GetLastIDOperationCompleted, userState);
        }
        
        private void OnDonHang_GetLastIDOperationCompleted(object arg) {
            if ((this.DonHang_GetLastIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DonHang_GetLastIDCompleted(this, new DonHang_GetLastIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Delete_DonHang", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Delete_DonHang(int ma_dh) {
            object[] results = this.Invoke("Delete_DonHang", new object[] {
                        ma_dh});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void Delete_DonHangAsync(int ma_dh) {
            this.Delete_DonHangAsync(ma_dh, null);
        }
        
        /// <remarks/>
        public void Delete_DonHangAsync(int ma_dh, object userState) {
            if ((this.Delete_DonHangOperationCompleted == null)) {
                this.Delete_DonHangOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDelete_DonHangOperationCompleted);
            }
            this.InvokeAsync("Delete_DonHang", new object[] {
                        ma_dh}, this.Delete_DonHangOperationCompleted, userState);
        }
        
        private void OnDelete_DonHangOperationCompleted(object arg) {
            if ((this.Delete_DonHangCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Delete_DonHangCompleted(this, new Delete_DonHangCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Update_DonHang", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Update_DonHang(int ma_donhang, string tinh_trang, int ma_nv) {
            object[] results = this.Invoke("Update_DonHang", new object[] {
                        ma_donhang,
                        tinh_trang,
                        ma_nv});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void Update_DonHangAsync(int ma_donhang, string tinh_trang, int ma_nv) {
            this.Update_DonHangAsync(ma_donhang, tinh_trang, ma_nv, null);
        }
        
        /// <remarks/>
        public void Update_DonHangAsync(int ma_donhang, string tinh_trang, int ma_nv, object userState) {
            if ((this.Update_DonHangOperationCompleted == null)) {
                this.Update_DonHangOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdate_DonHangOperationCompleted);
            }
            this.InvokeAsync("Update_DonHang", new object[] {
                        ma_donhang,
                        tinh_trang,
                        ma_nv}, this.Update_DonHangOperationCompleted, userState);
        }
        
        private void OnUpdate_DonHangOperationCompleted(object arg) {
            if ((this.Update_DonHangCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Update_DonHangCompleted(this, new Update_DonHangCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Insert_DonHang", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Insert_DonHang(System.DateTime ngay_dh, string tinh_trang, int ma_kh, int ma_nv) {
            object[] results = this.Invoke("Insert_DonHang", new object[] {
                        ngay_dh,
                        tinh_trang,
                        ma_kh,
                        ma_nv});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void Insert_DonHangAsync(System.DateTime ngay_dh, string tinh_trang, int ma_kh, int ma_nv) {
            this.Insert_DonHangAsync(ngay_dh, tinh_trang, ma_kh, ma_nv, null);
        }
        
        /// <remarks/>
        public void Insert_DonHangAsync(System.DateTime ngay_dh, string tinh_trang, int ma_kh, int ma_nv, object userState) {
            if ((this.Insert_DonHangOperationCompleted == null)) {
                this.Insert_DonHangOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsert_DonHangOperationCompleted);
            }
            this.InvokeAsync("Insert_DonHang", new object[] {
                        ngay_dh,
                        tinh_trang,
                        ma_kh,
                        ma_nv}, this.Insert_DonHangOperationCompleted, userState);
        }
        
        private void OnInsert_DonHangOperationCompleted(object arg) {
            if ((this.Insert_DonHangCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Insert_DonHangCompleted(this, new Insert_DonHangCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void DonHang_GetAllCompletedEventHandler(object sender, DonHang_GetAllCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DonHang_GetAllCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DonHang_GetAllCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetInfo_KhachHangCompletedEventHandler(object sender, GetInfo_KhachHangCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetInfo_KhachHangCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetInfo_KhachHangCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetInfo_KhachHangPhoneCompletedEventHandler(object sender, GetInfo_KhachHangPhoneCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetInfo_KhachHangPhoneCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetInfo_KhachHangPhoneCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void DonHang_GetByDateCompletedEventHandler(object sender, DonHang_GetByDateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DonHang_GetByDateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DonHang_GetByDateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void DonHang_GetByCustomerCompletedEventHandler(object sender, DonHang_GetByCustomerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DonHang_GetByCustomerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DonHang_GetByCustomerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void DonHang_GetLastIDCompletedEventHandler(object sender, DonHang_GetLastIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DonHang_GetLastIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DonHang_GetLastIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void Delete_DonHangCompletedEventHandler(object sender, Delete_DonHangCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Delete_DonHangCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Delete_DonHangCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void Update_DonHangCompletedEventHandler(object sender, Update_DonHangCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Update_DonHangCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Update_DonHangCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void Insert_DonHangCompletedEventHandler(object sender, Insert_DonHangCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Insert_DonHangCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Insert_DonHangCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591