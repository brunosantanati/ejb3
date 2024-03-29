﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=1.1.4322.2032.
// 
using System.Diagnostics;
using System.Xml.Serialization;
using System;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Web.Services;


/// <remarks/>
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="TravelAgentBinding", Namespace="http://travelagent.titan.com/jaws")]
public class TravelAgentService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    /// <remarks/>
    public TravelAgentService() {
        this.Url = "http://localhost:8080/titan/TravelAgentBean";
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://travelagent.titan.com/jaws", ResponseNamespace="http://travelagent.titan.com/jaws", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void createCabin([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Cabin Cabin) {
        this.Invoke("createCabin", new object[] {
                    Cabin});
    }
    
    /// <remarks/>
    public System.IAsyncResult BegincreateCabin(Cabin Cabin, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("createCabin", new object[] {
                    Cabin}, callback, asyncState);
    }
    
    /// <remarks/>
    public void EndcreateCabin(System.IAsyncResult asyncResult) {
        this.EndInvoke(asyncResult);
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://travelagent.titan.com/jaws", ResponseNamespace="http://travelagent.titan.com/jaws", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("Cabin", IsNullable=true)]
    public Cabin findCabin(int ID) {
        object[] results = this.Invoke("findCabin", new object[] {
                    ID});
        return ((Cabin)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginfindCabin(int ID, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("findCabin", new object[] {
                    ID}, callback, asyncState);
    }
    
    /// <remarks/>
    public Cabin EndfindCabin(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((Cabin)(results[0]));
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://domain.titan.com/jaws")]
public class Cabin {
    
    /// <remarks/>
    public int bedCount;
    
    /// <remarks/>
    public int deckLevel;
    
    /// <remarks/>
    public int id;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string name;
    
    /// <remarks/>
    public int shipId;
}
