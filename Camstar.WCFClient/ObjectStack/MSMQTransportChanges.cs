// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MSMQTransportChanges
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
  public class MSMQTransportChanges : DataTransportChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_LabelFormat")]
    protected Primitive<string> _LabelFormat;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_TransportAssembly")]
    protected new Primitive<string> _TransportAssembly;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Priority")]
    protected Enumeration<MSMQPriorityEnum, string> _Priority;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_URL")]
    protected new Primitive<string> _URL;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_IsSynchronous")]
    protected new Primitive<bool> _IsSynchronous;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_OkToTerminateIfFails")]
    protected new Primitive<bool> _OkToTerminateIfFails;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_ByteOrderMark")]
    protected Primitive<bool> _ByteOrderMark;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_DeliveryTimeout")]
    protected Primitive<int> _DeliveryTimeout;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_TransportType")]
    protected new Primitive<string> _TransportType;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is MSMQTransportChanges && object.Equals((object) this._LabelFormat, (object) ((MSMQTransportChanges) obj)._LabelFormat) && (object.Equals((object) this._TransportAssembly, (object) ((MSMQTransportChanges) obj)._TransportAssembly) && object.Equals((object) this._Priority, (object) ((MSMQTransportChanges) obj)._Priority)) && (object.Equals((object) this._ObjectToChange, (object) ((MSMQTransportChanges) obj)._ObjectToChange) && object.Equals((object) this._URL, (object) ((MSMQTransportChanges) obj)._URL) && (object.Equals((object) this._IsSynchronous, (object) ((MSMQTransportChanges) obj)._IsSynchronous) && object.Equals((object) this._OkToTerminateIfFails, (object) ((MSMQTransportChanges) obj)._OkToTerminateIfFails))) && (object.Equals((object) this._ByteOrderMark, (object) ((MSMQTransportChanges) obj)._ByteOrderMark) && object.Equals((object) this._DeliveryTimeout, (object) ((MSMQTransportChanges) obj)._DeliveryTimeout) && (object.Equals((object) this._TransportType, (object) ((MSMQTransportChanges) obj)._TransportType) && object.Equals((object) this._Name, (object) ((MSMQTransportChanges) obj)._Name))) && base.Equals(obj);
    }

    public Primitive<string> LabelFormat
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelFormat), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelFormat));
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

    public Enumeration<MSMQPriorityEnum, string> Priority
    {
      [param: In] set
      {
        this.PropertySet(nameof (Priority), (object) value);
      }
      get
      {
        return (Enumeration<MSMQPriorityEnum, string>) this.PropertyGet(nameof (Priority));
      }
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

    public Primitive<bool> ByteOrderMark
    {
      [param: In] set
      {
        this.PropertySet(nameof (ByteOrderMark), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ByteOrderMark));
      }
    }

    public Primitive<int> DeliveryTimeout
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeliveryTimeout), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (DeliveryTimeout));
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
