// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MSMQTransportChanges_Environment
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
  public class MSMQTransportChanges_Environment : DataTransportChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Environment_LabelFormat")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1050016, false, false, false, "InSiteLabel<__txnId/><__docId/>")]
    protected Environment _LabelFormat;
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1049996, false, false, false, "Camstar.XMLConnect.Transport.MSMQ.dll")]
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Environment_TransportAssembly")]
    protected new Environment _TransportAssembly;
    [Metadata("MSMQ Priority. Enumerators: Lowest, VeryLow, Low, Normal, AboveNormal, High, VeryHigh, Highest", "MSMQPriorityEnum", false, false, false, "String", 1050015, false, false, true, "Normal")]
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Environment_Priority")]
    protected Environment _Priority;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Environment_ObjectToChange")]
    [Metadata("MSMQ Transport", "MSMQTransport", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Environment_URL")]
    [Metadata("URL", "", false, true, false, "String", 1049620, false, false, false, null)]
    protected new Environment _URL;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049995, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Environment_IsSynchronous")]
    protected new Environment _IsSynchronous;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049999, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Environment_OkToTerminateIfFails")]
    protected new Environment _OkToTerminateIfFails;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Environment_ByteOrderMark")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050004, false, false, false, "1")]
    protected Environment _ByteOrderMark;
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Environment_DeliveryTimeout")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050416, false, false, false, "3")]
    protected Environment _DeliveryTimeout;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1049892, false, false, false, "MSMQ")]
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Environment_TransportType")]
    protected new Environment _TransportType;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050058, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MSMQTransportChanges_Environment_Name")]
    protected new Environment _Name;

    public Environment LabelFormat
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelFormat), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelFormat));
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

    public Environment Priority
    {
      [param: In] set
      {
        this.PropertySet(nameof (Priority), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Priority));
      }
    }

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

    public Environment ByteOrderMark
    {
      [param: In] set
      {
        this.PropertySet(nameof (ByteOrderMark), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ByteOrderMark));
      }
    }

    public Environment DeliveryTimeout
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeliveryTimeout), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeliveryTimeout));
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
