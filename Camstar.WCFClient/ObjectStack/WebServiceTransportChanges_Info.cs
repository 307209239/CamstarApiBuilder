// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WebServiceTransportChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class WebServiceTransportChanges_Info : DataTransportChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_Info_TransportAssembly")]
    protected new Info _TransportAssembly;
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_Info_URL")]
    protected new Info _URL;
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_Info_IsSynchronous")]
    protected new Info _IsSynchronous;
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_Info_OkToTerminateIfFails")]
    protected new Info _OkToTerminateIfFails;
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_Info_TransportType")]
    protected new Info _TransportType;
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_Info_Name")]
    protected new Info _Name;

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info TransportAssembly
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransportAssembly), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TransportAssembly));
      }
    }

    public new Info URL
    {
      [param: In] set
      {
        this.PropertySet(nameof (URL), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (URL));
      }
    }

    public new Info IsSynchronous
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSynchronous), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsSynchronous));
      }
    }

    public new Info OkToTerminateIfFails
    {
      [param: In] set
      {
        this.PropertySet(nameof (OkToTerminateIfFails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OkToTerminateIfFails));
      }
    }

    public new Info TransportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransportType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TransportType));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
