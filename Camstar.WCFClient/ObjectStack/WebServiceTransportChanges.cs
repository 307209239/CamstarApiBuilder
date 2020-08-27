// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WebServiceTransportChanges
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
  public class WebServiceTransportChanges : DataTransportChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_TransportAssembly")]
    protected new Primitive<string> _TransportAssembly;
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_URL")]
    protected new Primitive<string> _URL;
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_IsSynchronous")]
    protected new Primitive<bool> _IsSynchronous;
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_OkToTerminateIfFails")]
    protected new Primitive<bool> _OkToTerminateIfFails;
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_TransportType")]
    protected new Primitive<string> _TransportType;
    [DataMember(EmitDefaultValue = false, Name = "WebServiceTransportChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is WebServiceTransportChanges && object.Equals((object) this._ObjectToChange, (object) ((WebServiceTransportChanges) obj)._ObjectToChange) && (object.Equals((object) this._TransportAssembly, (object) ((WebServiceTransportChanges) obj)._TransportAssembly) && object.Equals((object) this._URL, (object) ((WebServiceTransportChanges) obj)._URL)) && (object.Equals((object) this._IsSynchronous, (object) ((WebServiceTransportChanges) obj)._IsSynchronous) && object.Equals((object) this._OkToTerminateIfFails, (object) ((WebServiceTransportChanges) obj)._OkToTerminateIfFails) && (object.Equals((object) this._TransportType, (object) ((WebServiceTransportChanges) obj)._TransportType) && object.Equals((object) this._Name, (object) ((WebServiceTransportChanges) obj)._Name))) && base.Equals(obj);
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Primitive<string> TransportAssembly
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransportAssembly), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TransportAssembly));
      }
    }

    public new Primitive<string> URL
    {
      [param: In] set
      {
        this.PropertySet(nameof (URL), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (URL));
      }
    }

    public new Primitive<bool> IsSynchronous
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSynchronous), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsSynchronous));
      }
    }

    public new Primitive<bool> OkToTerminateIfFails
    {
      [param: In] set
      {
        this.PropertySet(nameof (OkToTerminateIfFails), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OkToTerminateIfFails));
      }
    }

    public new Primitive<string> TransportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransportType), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TransportType));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
