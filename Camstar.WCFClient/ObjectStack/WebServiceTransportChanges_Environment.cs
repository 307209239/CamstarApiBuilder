// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WebServiceTransportChanges_Environment
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
  public class WebServiceTransportChanges_Environment : DataTransportChanges_Environment
  {
    [Metadata("Configures a Transport to communicate to a WebService.", "WebServiceTransport", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_Environment_TransportAssembly")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1049996, false, false, false, "Camstar.XMLConnect.Transport.WebService.dll")]
    protected new Environment _TransportAssembly;
    [Metadata("URL", "", false, false, false, "String", 1050942, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_Environment_URL")]
    protected new Environment _URL;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049995, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_Environment_IsSynchronous")]
    protected new Environment _IsSynchronous;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049999, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_Environment_OkToTerminateIfFails")]
    protected new Environment _OkToTerminateIfFails;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049892, false, false, false, "WebService")]
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_Environment_TransportType")]
    protected new Environment _TransportType;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050941, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_Environment_Name")]
    protected new Environment _Name;

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment TransportAssembly
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransportAssembly), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TransportAssembly));
      }
    }

    public new Environment URL
    {
      [param: In] set
      {
        this.PropertySet(nameof (URL), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (URL));
      }
    }

    public new Environment IsSynchronous
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSynchronous), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsSynchronous));
      }
    }

    public new Environment OkToTerminateIfFails
    {
      [param: In] set
      {
        this.PropertySet(nameof (OkToTerminateIfFails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OkToTerminateIfFails));
      }
    }

    public new Environment TransportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransportType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TransportType));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
