﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jobportalclient.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompanyDetails", Namespace="http://schemas.datacontract.org/2004/07/jobportalservice")]
    [System.SerializableAttribute()]
    public partial class CompanyDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JobidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QualificationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SalaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int VacancyField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Jobid {
            get {
                return this.JobidField;
            }
            set {
                if ((object.ReferenceEquals(this.JobidField, value) != true)) {
                    this.JobidField = value;
                    this.RaisePropertyChanged("Jobid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Postname {
            get {
                return this.PostnameField;
            }
            set {
                if ((object.ReferenceEquals(this.PostnameField, value) != true)) {
                    this.PostnameField = value;
                    this.RaisePropertyChanged("Postname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Qualification {
            get {
                return this.QualificationField;
            }
            set {
                if ((object.ReferenceEquals(this.QualificationField, value) != true)) {
                    this.QualificationField = value;
                    this.RaisePropertyChanged("Qualification");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((object.ReferenceEquals(this.SalaryField, value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Vacancy {
            get {
                return this.VacancyField;
            }
            set {
                if ((this.VacancyField.Equals(value) != true)) {
                    this.VacancyField = value;
                    this.RaisePropertyChanged("Vacancy");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JobApplication", Namespace="http://schemas.datacontract.org/2004/07/jobportalservice")]
    [System.SerializableAttribute()]
    public partial class JobApplication : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanynameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int JobidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Companyname {
            get {
                return this.CompanynameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanynameField, value) != true)) {
                    this.CompanynameField = value;
                    this.RaisePropertyChanged("Companyname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Jobid {
            get {
                return this.JobidField;
            }
            set {
                if ((this.JobidField.Equals(value) != true)) {
                    this.JobidField = value;
                    this.RaisePropertyChanged("Jobid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/jobportalservice")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contact {
            get {
                return this.ContactField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactField, value) != true)) {
                    this.ContactField = value;
                    this.RaisePropertyChanged("Contact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Role {
            get {
                return this.RoleField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleField, value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertData", ReplyAction="http://tempuri.org/IService1/InsertDataResponse")]
        string InsertData(Jobportalclient.ServiceReference2.CompanyDetails c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertData", ReplyAction="http://tempuri.org/IService1/InsertDataResponse")]
        System.Threading.Tasks.Task<string> InsertDataAsync(Jobportalclient.ServiceReference2.CompanyDetails c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCompanyData", ReplyAction="http://tempuri.org/IService1/GetCompanyDataResponse")]
        System.Data.DataSet GetCompanyData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCompanyData", ReplyAction="http://tempuri.org/IService1/GetCompanyDataResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetCompanyDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSingleCompanyData", ReplyAction="http://tempuri.org/IService1/GetSingleCompanyDataResponse")]
        System.Data.DataSet GetSingleCompanyData(string cname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSingleCompanyData", ReplyAction="http://tempuri.org/IService1/GetSingleCompanyDataResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetSingleCompanyDataAsync(string cname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePostedJob", ReplyAction="http://tempuri.org/IService1/DeletePostedJobResponse")]
        string DeletePostedJob(string name, string postname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePostedJob", ReplyAction="http://tempuri.org/IService1/DeletePostedJobResponse")]
        System.Threading.Tasks.Task<string> DeletePostedJobAsync(string name, string postname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ApplyForCompany", ReplyAction="http://tempuri.org/IService1/ApplyForCompanyResponse")]
        string ApplyForCompany(Jobportalclient.ServiceReference2.JobApplication a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ApplyForCompany", ReplyAction="http://tempuri.org/IService1/ApplyForCompanyResponse")]
        System.Threading.Tasks.Task<string> ApplyForCompanyAsync(Jobportalclient.ServiceReference2.JobApplication a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUser", ReplyAction="http://tempuri.org/IService1/AddUserResponse")]
        string AddUser(Jobportalclient.ServiceReference2.User u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUser", ReplyAction="http://tempuri.org/IService1/AddUserResponse")]
        System.Threading.Tasks.Task<string> AddUserAsync(Jobportalclient.ServiceReference2.User u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getUser", ReplyAction="http://tempuri.org/IService1/getUserResponse")]
        System.Data.DataSet getUser(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getUser", ReplyAction="http://tempuri.org/IService1/getUserResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> getUserAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectUserbyCompany", ReplyAction="http://tempuri.org/IService1/SelectUserbyCompanyResponse")]
        System.Data.DataSet SelectUserbyCompany(string CompanyName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectUserbyCompany", ReplyAction="http://tempuri.org/IService1/SelectUserbyCompanyResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectUserbyCompanyAsync(string CompanyName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateUser", ReplyAction="http://tempuri.org/IService1/UpdateUserResponse")]
        string UpdateUser(Jobportalclient.ServiceReference2.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateUser", ReplyAction="http://tempuri.org/IService1/UpdateUserResponse")]
        System.Threading.Tasks.Task<string> UpdateUserAsync(Jobportalclient.ServiceReference2.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectUserbyPostCompany", ReplyAction="http://tempuri.org/IService1/SelectUserbyPostCompanyResponse")]
        System.Data.DataSet SelectUserbyPostCompany(string CompanyName, string jobid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectUserbyPostCompany", ReplyAction="http://tempuri.org/IService1/SelectUserbyPostCompanyResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectUserbyPostCompanyAsync(string CompanyName, string jobid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        string Login(Jobportalclient.ServiceReference2.User u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(Jobportalclient.ServiceReference2.User u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdatePostedJob", ReplyAction="http://tempuri.org/IService1/UpdatePostedJobResponse")]
        string UpdatePostedJob(Jobportalclient.ServiceReference2.CompanyDetails c, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdatePostedJob", ReplyAction="http://tempuri.org/IService1/UpdatePostedJobResponse")]
        System.Threading.Tasks.Task<string> UpdatePostedJobAsync(Jobportalclient.ServiceReference2.CompanyDetails c, int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Jobportalclient.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Jobportalclient.ServiceReference2.IService1>, Jobportalclient.ServiceReference2.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertData(Jobportalclient.ServiceReference2.CompanyDetails c) {
            return base.Channel.InsertData(c);
        }
        
        public System.Threading.Tasks.Task<string> InsertDataAsync(Jobportalclient.ServiceReference2.CompanyDetails c) {
            return base.Channel.InsertDataAsync(c);
        }
        
        public System.Data.DataSet GetCompanyData() {
            return base.Channel.GetCompanyData();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetCompanyDataAsync() {
            return base.Channel.GetCompanyDataAsync();
        }
        
        public System.Data.DataSet GetSingleCompanyData(string cname) {
            return base.Channel.GetSingleCompanyData(cname);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetSingleCompanyDataAsync(string cname) {
            return base.Channel.GetSingleCompanyDataAsync(cname);
        }
        
        public string DeletePostedJob(string name, string postname) {
            return base.Channel.DeletePostedJob(name, postname);
        }
        
        public System.Threading.Tasks.Task<string> DeletePostedJobAsync(string name, string postname) {
            return base.Channel.DeletePostedJobAsync(name, postname);
        }
        
        public string ApplyForCompany(Jobportalclient.ServiceReference2.JobApplication a) {
            return base.Channel.ApplyForCompany(a);
        }
        
        public System.Threading.Tasks.Task<string> ApplyForCompanyAsync(Jobportalclient.ServiceReference2.JobApplication a) {
            return base.Channel.ApplyForCompanyAsync(a);
        }
        
        public string AddUser(Jobportalclient.ServiceReference2.User u) {
            return base.Channel.AddUser(u);
        }
        
        public System.Threading.Tasks.Task<string> AddUserAsync(Jobportalclient.ServiceReference2.User u) {
            return base.Channel.AddUserAsync(u);
        }
        
        public System.Data.DataSet getUser(string username) {
            return base.Channel.getUser(username);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getUserAsync(string username) {
            return base.Channel.getUserAsync(username);
        }
        
        public System.Data.DataSet SelectUserbyCompany(string CompanyName) {
            return base.Channel.SelectUserbyCompany(CompanyName);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectUserbyCompanyAsync(string CompanyName) {
            return base.Channel.SelectUserbyCompanyAsync(CompanyName);
        }
        
        public string UpdateUser(Jobportalclient.ServiceReference2.User user) {
            return base.Channel.UpdateUser(user);
        }
        
        public System.Threading.Tasks.Task<string> UpdateUserAsync(Jobportalclient.ServiceReference2.User user) {
            return base.Channel.UpdateUserAsync(user);
        }
        
        public System.Data.DataSet SelectUserbyPostCompany(string CompanyName, string jobid) {
            return base.Channel.SelectUserbyPostCompany(CompanyName, jobid);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectUserbyPostCompanyAsync(string CompanyName, string jobid) {
            return base.Channel.SelectUserbyPostCompanyAsync(CompanyName, jobid);
        }
        
        public string Login(Jobportalclient.ServiceReference2.User u) {
            return base.Channel.Login(u);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(Jobportalclient.ServiceReference2.User u) {
            return base.Channel.LoginAsync(u);
        }
        
        public string UpdatePostedJob(Jobportalclient.ServiceReference2.CompanyDetails c, int id) {
            return base.Channel.UpdatePostedJob(c, id);
        }
        
        public System.Threading.Tasks.Task<string> UpdatePostedJobAsync(Jobportalclient.ServiceReference2.CompanyDetails c, int id) {
            return base.Channel.UpdatePostedJobAsync(c, id);
        }
    }
}
