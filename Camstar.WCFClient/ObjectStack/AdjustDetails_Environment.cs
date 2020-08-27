// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AdjustDetails_Environment
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
  public class AdjustDetails_Environment : ChangeQtyDetails_Environment
  {
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1052575, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AdjustDetails_Environment_Qty2")]
    protected new Environment _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "AdjustDetails_Environment_ReasonCode")]
    [Metadata("The user code for qty adjust reason.", "QtyAdjustReason", false, true, false, "NamedObjectRef", 1052573, false, false, true, null)]
    protected new Environment _ReasonCode;
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1049353, false, false, true, "4")]
    [DataMember(EmitDefaultValue = false, Name = "AdjustDetails_Environment_ChangeQtyType")]
    protected new Environment _ChangeQtyType;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049354, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "AdjustDetails_Environment_AdjustThruput")]
    protected new Environment _AdjustThruput;
    [DataMember(EmitDefaultValue = false, Name = "AdjustDetails_Environment_TypeSortOrder")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052571, false, false, false, "50")]
    protected new Environment _TypeSortOrder;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1052574, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AdjustDetails_Environment_Qty")]
    protected new Environment _Qty;
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1049822, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "AdjustDetails_Environment_ChargeToStep")]
    protected new Environment _ChargeToStep;

    public new Environment Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2));
      }
    }

    public new Environment ReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReasonCode));
      }
    }

    public new Environment ChangeQtyType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeQtyType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangeQtyType));
      }
    }

    public new Environment AdjustThruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdjustThruput), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AdjustThruput));
      }
    }

    public new Environment TypeSortOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (TypeSortOrder), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TypeSortOrder));
      }
    }

    public new Environment Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty));
      }
    }

    public new Environment ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChargeToStep));
      }
    }
  }
}
