﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Website.ChiTietDonHang_Service {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ChiTietDonHang_Service.ChiTietDonHang_ServiceSoap")]
    public interface ChiTietDonHang_ServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ChiTietDonHang_GetByID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable ChiTietDonHang_GetByID(int ma_donhang);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete_ChiTietDonHang", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool Delete_ChiTietDonHang(int ma_dh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insert_ChiTietDonHang", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool Insert_ChiTietDonHang(int ma_dh, int ma_sp, int soluong, int gia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update_ChiTietDonHang", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool Update_ChiTietDonHang(int ma_donhang, int ma_sp, int soluong, int gia);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ChiTietDonHang_ServiceSoapChannel : Website.ChiTietDonHang_Service.ChiTietDonHang_ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChiTietDonHang_ServiceSoapClient : System.ServiceModel.ClientBase<Website.ChiTietDonHang_Service.ChiTietDonHang_ServiceSoap>, Website.ChiTietDonHang_Service.ChiTietDonHang_ServiceSoap {
        
        public ChiTietDonHang_ServiceSoapClient() {
        }
        
        public ChiTietDonHang_ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ChiTietDonHang_ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChiTietDonHang_ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChiTietDonHang_ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable ChiTietDonHang_GetByID(int ma_donhang) {
            return base.Channel.ChiTietDonHang_GetByID(ma_donhang);
        }
        
        public bool Delete_ChiTietDonHang(int ma_dh) {
            return base.Channel.Delete_ChiTietDonHang(ma_dh);
        }
        
        public bool Insert_ChiTietDonHang(int ma_dh, int ma_sp, int soluong, int gia) {
            return base.Channel.Insert_ChiTietDonHang(ma_dh, ma_sp, soluong, gia);
        }
        
        public bool Update_ChiTietDonHang(int ma_donhang, int ma_sp, int soluong, int gia) {
            return base.Channel.Update_ChiTietDonHang(ma_donhang, ma_sp, soluong, gia);
        }
    }
}
