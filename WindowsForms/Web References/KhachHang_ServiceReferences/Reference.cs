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

namespace WindowsForms.KhachHang_ServiceReferences {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="KhachHang_ServiceSoap", Namespace="http://tempuri.org/")]
    public partial class KhachHang_Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback KhachHang_CheckLoginOperationCompleted;
        
        private System.Threading.SendOrPostCallback KhachHang_GetAllOperationCompleted;
        
        private System.Threading.SendOrPostCallback KhachHang_GetByIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback KhachHang_GetByNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback KhachHang_GetByPhoneOperationCompleted;
        
        private System.Threading.SendOrPostCallback KhachHang_GetByUsernameOperationCompleted;
        
        private System.Threading.SendOrPostCallback KhachHang_CheckUsernameOperationCompleted;
        
        private System.Threading.SendOrPostCallback KhachHang_GetLastIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback Delete_KhachHangOperationCompleted;
        
        private System.Threading.SendOrPostCallback Update_KhachHangOperationCompleted;
        
        private System.Threading.SendOrPostCallback Insert_KhachHangOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public KhachHang_Service() {
            this.Url = global::WindowsForms.Properties.Settings.Default.WindowsForms_KhachHang_ServiceReferences_KhachHang_Service;
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
        public event KhachHang_CheckLoginCompletedEventHandler KhachHang_CheckLoginCompleted;
        
        /// <remarks/>
        public event KhachHang_GetAllCompletedEventHandler KhachHang_GetAllCompleted;
        
        /// <remarks/>
        public event KhachHang_GetByIDCompletedEventHandler KhachHang_GetByIDCompleted;
        
        /// <remarks/>
        public event KhachHang_GetByNameCompletedEventHandler KhachHang_GetByNameCompleted;
        
        /// <remarks/>
        public event KhachHang_GetByPhoneCompletedEventHandler KhachHang_GetByPhoneCompleted;
        
        /// <remarks/>
        public event KhachHang_GetByUsernameCompletedEventHandler KhachHang_GetByUsernameCompleted;
        
        /// <remarks/>
        public event KhachHang_CheckUsernameCompletedEventHandler KhachHang_CheckUsernameCompleted;
        
        /// <remarks/>
        public event KhachHang_GetLastIDCompletedEventHandler KhachHang_GetLastIDCompleted;
        
        /// <remarks/>
        public event Delete_KhachHangCompletedEventHandler Delete_KhachHangCompleted;
        
        /// <remarks/>
        public event Update_KhachHangCompletedEventHandler Update_KhachHangCompleted;
        
        /// <remarks/>
        public event Insert_KhachHangCompletedEventHandler Insert_KhachHangCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/KhachHang_CheckLogin", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable KhachHang_CheckLogin(string username, string pass) {
            object[] results = this.Invoke("KhachHang_CheckLogin", new object[] {
                        username,
                        pass});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void KhachHang_CheckLoginAsync(string username, string pass) {
            this.KhachHang_CheckLoginAsync(username, pass, null);
        }
        
        /// <remarks/>
        public void KhachHang_CheckLoginAsync(string username, string pass, object userState) {
            if ((this.KhachHang_CheckLoginOperationCompleted == null)) {
                this.KhachHang_CheckLoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnKhachHang_CheckLoginOperationCompleted);
            }
            this.InvokeAsync("KhachHang_CheckLogin", new object[] {
                        username,
                        pass}, this.KhachHang_CheckLoginOperationCompleted, userState);
        }
        
        private void OnKhachHang_CheckLoginOperationCompleted(object arg) {
            if ((this.KhachHang_CheckLoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.KhachHang_CheckLoginCompleted(this, new KhachHang_CheckLoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/KhachHang_GetAll", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable KhachHang_GetAll() {
            object[] results = this.Invoke("KhachHang_GetAll", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void KhachHang_GetAllAsync() {
            this.KhachHang_GetAllAsync(null);
        }
        
        /// <remarks/>
        public void KhachHang_GetAllAsync(object userState) {
            if ((this.KhachHang_GetAllOperationCompleted == null)) {
                this.KhachHang_GetAllOperationCompleted = new System.Threading.SendOrPostCallback(this.OnKhachHang_GetAllOperationCompleted);
            }
            this.InvokeAsync("KhachHang_GetAll", new object[0], this.KhachHang_GetAllOperationCompleted, userState);
        }
        
        private void OnKhachHang_GetAllOperationCompleted(object arg) {
            if ((this.KhachHang_GetAllCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.KhachHang_GetAllCompleted(this, new KhachHang_GetAllCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/KhachHang_GetByID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable KhachHang_GetByID(int ma_kh) {
            object[] results = this.Invoke("KhachHang_GetByID", new object[] {
                        ma_kh});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void KhachHang_GetByIDAsync(int ma_kh) {
            this.KhachHang_GetByIDAsync(ma_kh, null);
        }
        
        /// <remarks/>
        public void KhachHang_GetByIDAsync(int ma_kh, object userState) {
            if ((this.KhachHang_GetByIDOperationCompleted == null)) {
                this.KhachHang_GetByIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnKhachHang_GetByIDOperationCompleted);
            }
            this.InvokeAsync("KhachHang_GetByID", new object[] {
                        ma_kh}, this.KhachHang_GetByIDOperationCompleted, userState);
        }
        
        private void OnKhachHang_GetByIDOperationCompleted(object arg) {
            if ((this.KhachHang_GetByIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.KhachHang_GetByIDCompleted(this, new KhachHang_GetByIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/KhachHang_GetByName", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable KhachHang_GetByName(string ten_kh) {
            object[] results = this.Invoke("KhachHang_GetByName", new object[] {
                        ten_kh});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void KhachHang_GetByNameAsync(string ten_kh) {
            this.KhachHang_GetByNameAsync(ten_kh, null);
        }
        
        /// <remarks/>
        public void KhachHang_GetByNameAsync(string ten_kh, object userState) {
            if ((this.KhachHang_GetByNameOperationCompleted == null)) {
                this.KhachHang_GetByNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnKhachHang_GetByNameOperationCompleted);
            }
            this.InvokeAsync("KhachHang_GetByName", new object[] {
                        ten_kh}, this.KhachHang_GetByNameOperationCompleted, userState);
        }
        
        private void OnKhachHang_GetByNameOperationCompleted(object arg) {
            if ((this.KhachHang_GetByNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.KhachHang_GetByNameCompleted(this, new KhachHang_GetByNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/KhachHang_GetByPhone", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable KhachHang_GetByPhone(string sdt) {
            object[] results = this.Invoke("KhachHang_GetByPhone", new object[] {
                        sdt});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void KhachHang_GetByPhoneAsync(string sdt) {
            this.KhachHang_GetByPhoneAsync(sdt, null);
        }
        
        /// <remarks/>
        public void KhachHang_GetByPhoneAsync(string sdt, object userState) {
            if ((this.KhachHang_GetByPhoneOperationCompleted == null)) {
                this.KhachHang_GetByPhoneOperationCompleted = new System.Threading.SendOrPostCallback(this.OnKhachHang_GetByPhoneOperationCompleted);
            }
            this.InvokeAsync("KhachHang_GetByPhone", new object[] {
                        sdt}, this.KhachHang_GetByPhoneOperationCompleted, userState);
        }
        
        private void OnKhachHang_GetByPhoneOperationCompleted(object arg) {
            if ((this.KhachHang_GetByPhoneCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.KhachHang_GetByPhoneCompleted(this, new KhachHang_GetByPhoneCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/KhachHang_GetByUsername", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable KhachHang_GetByUsername(string username) {
            object[] results = this.Invoke("KhachHang_GetByUsername", new object[] {
                        username});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void KhachHang_GetByUsernameAsync(string username) {
            this.KhachHang_GetByUsernameAsync(username, null);
        }
        
        /// <remarks/>
        public void KhachHang_GetByUsernameAsync(string username, object userState) {
            if ((this.KhachHang_GetByUsernameOperationCompleted == null)) {
                this.KhachHang_GetByUsernameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnKhachHang_GetByUsernameOperationCompleted);
            }
            this.InvokeAsync("KhachHang_GetByUsername", new object[] {
                        username}, this.KhachHang_GetByUsernameOperationCompleted, userState);
        }
        
        private void OnKhachHang_GetByUsernameOperationCompleted(object arg) {
            if ((this.KhachHang_GetByUsernameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.KhachHang_GetByUsernameCompleted(this, new KhachHang_GetByUsernameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/KhachHang_CheckUsername", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable KhachHang_CheckUsername(string username) {
            object[] results = this.Invoke("KhachHang_CheckUsername", new object[] {
                        username});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void KhachHang_CheckUsernameAsync(string username) {
            this.KhachHang_CheckUsernameAsync(username, null);
        }
        
        /// <remarks/>
        public void KhachHang_CheckUsernameAsync(string username, object userState) {
            if ((this.KhachHang_CheckUsernameOperationCompleted == null)) {
                this.KhachHang_CheckUsernameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnKhachHang_CheckUsernameOperationCompleted);
            }
            this.InvokeAsync("KhachHang_CheckUsername", new object[] {
                        username}, this.KhachHang_CheckUsernameOperationCompleted, userState);
        }
        
        private void OnKhachHang_CheckUsernameOperationCompleted(object arg) {
            if ((this.KhachHang_CheckUsernameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.KhachHang_CheckUsernameCompleted(this, new KhachHang_CheckUsernameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/KhachHang_GetLastID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable KhachHang_GetLastID() {
            object[] results = this.Invoke("KhachHang_GetLastID", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void KhachHang_GetLastIDAsync() {
            this.KhachHang_GetLastIDAsync(null);
        }
        
        /// <remarks/>
        public void KhachHang_GetLastIDAsync(object userState) {
            if ((this.KhachHang_GetLastIDOperationCompleted == null)) {
                this.KhachHang_GetLastIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnKhachHang_GetLastIDOperationCompleted);
            }
            this.InvokeAsync("KhachHang_GetLastID", new object[0], this.KhachHang_GetLastIDOperationCompleted, userState);
        }
        
        private void OnKhachHang_GetLastIDOperationCompleted(object arg) {
            if ((this.KhachHang_GetLastIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.KhachHang_GetLastIDCompleted(this, new KhachHang_GetLastIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Delete_KhachHang", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Delete_KhachHang(int ma_kh) {
            object[] results = this.Invoke("Delete_KhachHang", new object[] {
                        ma_kh});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void Delete_KhachHangAsync(int ma_kh) {
            this.Delete_KhachHangAsync(ma_kh, null);
        }
        
        /// <remarks/>
        public void Delete_KhachHangAsync(int ma_kh, object userState) {
            if ((this.Delete_KhachHangOperationCompleted == null)) {
                this.Delete_KhachHangOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDelete_KhachHangOperationCompleted);
            }
            this.InvokeAsync("Delete_KhachHang", new object[] {
                        ma_kh}, this.Delete_KhachHangOperationCompleted, userState);
        }
        
        private void OnDelete_KhachHangOperationCompleted(object arg) {
            if ((this.Delete_KhachHangCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Delete_KhachHangCompleted(this, new Delete_KhachHangCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Update_KhachHang", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Update_KhachHang(int ma_kh, string hoten, string sdt, string diachi, string email, string username, string pass) {
            object[] results = this.Invoke("Update_KhachHang", new object[] {
                        ma_kh,
                        hoten,
                        sdt,
                        diachi,
                        email,
                        username,
                        pass});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void Update_KhachHangAsync(int ma_kh, string hoten, string sdt, string diachi, string email, string username, string pass) {
            this.Update_KhachHangAsync(ma_kh, hoten, sdt, diachi, email, username, pass, null);
        }
        
        /// <remarks/>
        public void Update_KhachHangAsync(int ma_kh, string hoten, string sdt, string diachi, string email, string username, string pass, object userState) {
            if ((this.Update_KhachHangOperationCompleted == null)) {
                this.Update_KhachHangOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdate_KhachHangOperationCompleted);
            }
            this.InvokeAsync("Update_KhachHang", new object[] {
                        ma_kh,
                        hoten,
                        sdt,
                        diachi,
                        email,
                        username,
                        pass}, this.Update_KhachHangOperationCompleted, userState);
        }
        
        private void OnUpdate_KhachHangOperationCompleted(object arg) {
            if ((this.Update_KhachHangCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Update_KhachHangCompleted(this, new Update_KhachHangCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Insert_KhachHang", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Insert_KhachHang(string hoten, string sdt, string diachi, string email, string username, string pass) {
            object[] results = this.Invoke("Insert_KhachHang", new object[] {
                        hoten,
                        sdt,
                        diachi,
                        email,
                        username,
                        pass});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void Insert_KhachHangAsync(string hoten, string sdt, string diachi, string email, string username, string pass) {
            this.Insert_KhachHangAsync(hoten, sdt, diachi, email, username, pass, null);
        }
        
        /// <remarks/>
        public void Insert_KhachHangAsync(string hoten, string sdt, string diachi, string email, string username, string pass, object userState) {
            if ((this.Insert_KhachHangOperationCompleted == null)) {
                this.Insert_KhachHangOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsert_KhachHangOperationCompleted);
            }
            this.InvokeAsync("Insert_KhachHang", new object[] {
                        hoten,
                        sdt,
                        diachi,
                        email,
                        username,
                        pass}, this.Insert_KhachHangOperationCompleted, userState);
        }
        
        private void OnInsert_KhachHangOperationCompleted(object arg) {
            if ((this.Insert_KhachHangCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Insert_KhachHangCompleted(this, new Insert_KhachHangCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void KhachHang_CheckLoginCompletedEventHandler(object sender, KhachHang_CheckLoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class KhachHang_CheckLoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal KhachHang_CheckLoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void KhachHang_GetAllCompletedEventHandler(object sender, KhachHang_GetAllCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class KhachHang_GetAllCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal KhachHang_GetAllCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void KhachHang_GetByIDCompletedEventHandler(object sender, KhachHang_GetByIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class KhachHang_GetByIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal KhachHang_GetByIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void KhachHang_GetByNameCompletedEventHandler(object sender, KhachHang_GetByNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class KhachHang_GetByNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal KhachHang_GetByNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void KhachHang_GetByPhoneCompletedEventHandler(object sender, KhachHang_GetByPhoneCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class KhachHang_GetByPhoneCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal KhachHang_GetByPhoneCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void KhachHang_GetByUsernameCompletedEventHandler(object sender, KhachHang_GetByUsernameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class KhachHang_GetByUsernameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal KhachHang_GetByUsernameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void KhachHang_CheckUsernameCompletedEventHandler(object sender, KhachHang_CheckUsernameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class KhachHang_CheckUsernameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal KhachHang_CheckUsernameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void KhachHang_GetLastIDCompletedEventHandler(object sender, KhachHang_GetLastIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class KhachHang_GetLastIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal KhachHang_GetLastIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void Delete_KhachHangCompletedEventHandler(object sender, Delete_KhachHangCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Delete_KhachHangCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Delete_KhachHangCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void Update_KhachHangCompletedEventHandler(object sender, Update_KhachHangCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Update_KhachHangCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Update_KhachHangCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void Insert_KhachHangCompletedEventHandler(object sender, Insert_KhachHangCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Insert_KhachHangCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Insert_KhachHangCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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