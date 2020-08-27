// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BonusDetails_Environment
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
  public class BonusDetails_Environment : ChangeQtyDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "BonusDetails_Environment_Qty2")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1052578, false, false, false, null)]
    protected new Environment _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "BonusDetails_Environment_ReasonCode")]
    [Metadata("The user code for bonus reason.", "BonusReason", false, true, false, "NamedObjectRef", 1048635, false, false, true, null)]
    protected new Environment _ReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "BonusDetails_Environment_CountsAgainstProduction")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049368, false, false, false, "1")]
    protected new Environment _CountsAgainstProduction;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052571, false, false, false, "20")]
    [DataMember(EmitDefaultValue = false, Name = "BonusDetails_Environment_TypeSortOrder")]
    protected new Environment _TypeSortOrder;
    [DataMember(EmitDefaultValue = false, Name = "BonusDetails_Environment_ChangeQtyType")]
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1049353, false, false, true, "5")]
    protected new Environment _ChangeQtyType;
    [DataMember(EmitDefaultValue = false, Name = "BonusDetails_Environment_AdjustThruput")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049354, false, false, false, "1")]
    protected new Environment _AdjustThruput;
    [DataMember(EmitDefaultValue = false, Name = "BonusDetails_Environment_ChargeToStep")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1049822, false, false, true, null)]
    protected new Environment _ChargeToStep;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1052577, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BonusDetails_Environment_Qty")]
    protected new Environment _Qty;

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

    public new Environment CountsAgainstProduction
    {
      [param: In] set
      {
        this.PropertySet(nameof (CountsAgainstProduction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CountsAgainstProduction));
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
  }
}
