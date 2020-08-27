// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActualsSerial_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CompDistributeActualSerial_Info))]
  [Serializable]
  public class ActualsSerial_Info : IssueActuals_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Info_Qty2Issued")]
    protected new Info _Qty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Info_FromCarrier")]
    protected Info _FromCarrier;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Info_FromBatch")]
    protected Info _FromBatch;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Info_FromContainer")]
    protected Info _FromContainer;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Info_ToContainer")]
    protected new Info _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Info_QtyIssued")]
    protected new Info _QtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Info_ToLocation")]
    protected new Info _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Info_FromLocation")]
    protected Info _FromLocation;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Info_Product")]
    protected new Info _Product;

    public new Info Qty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Issued), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2Issued));
      }
    }

    public Info FromCarrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromCarrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromCarrier));
      }
    }

    public Info FromBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromBatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromBatch));
      }
    }

    public Info FromContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromContainer));
      }
    }

    public new Info ToContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToContainer));
      }
    }

    public new Info QtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyIssued), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyIssued));
      }
    }

    public new Info ToLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToLocation));
      }
    }

    public Info FromLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromLocation));
      }
    }

    public new Info Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Product));
      }
    }
  }
}
