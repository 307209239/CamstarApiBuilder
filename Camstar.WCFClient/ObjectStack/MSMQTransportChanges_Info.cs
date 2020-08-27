// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MSMQTransportChanges_Info
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
  public class MSMQTransportChanges_Info : DataTransportChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Info_LabelFormat")]
    protected Info _LabelFormat;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Info_TransportAssembly")]
    protected new Info _TransportAssembly;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Info_Priority")]
    protected Info _Priority;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Info_URL")]
    protected new Info _URL;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Info_IsSynchronous")]
    protected new Info _IsSynchronous;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Info_OkToTerminateIfFails")]
    protected new Info _OkToTerminateIfFails;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Info_ByteOrderMark")]
    protected Info _ByteOrderMark;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Info_DeliveryTimeout")]
    protected Info _DeliveryTimeout;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Info_TransportType")]
    protected new Info _TransportType;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Info_Name")]
    protected new Info _Name;

    public Info LabelFormat
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelFormat), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelFormat));
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

    public Info Priority
    {
      [param: In] set
      {
        this.PropertySet(nameof (Priority), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Priority));
      }
    }

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

    public Info ByteOrderMark
    {
      [param: In] set
      {
        this.PropertySet(nameof (ByteOrderMark), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ByteOrderMark));
      }
    }

    public Info DeliveryTimeout
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeliveryTimeout), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DeliveryTimeout));
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
