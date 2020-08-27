// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteRecipeTaskHistory
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
  public class ExecuteRecipeTaskHistory : ExecuteTaskHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTaskHistory_IssueDifferenceReason")]
    protected NamedObjectRef _IssueDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTaskHistory_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTaskHistory_ElectronicProcedure")]
    protected new RevisionedObjectRef _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTaskHistory_MaterialContainer")]
    protected ContainerRef _MaterialContainer;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTaskHistory_Carrier")]
    protected NamedObjectRef _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTaskHistory_CompleteTaskForBatch")]
    protected Primitive<bool> _CompleteTaskForBatch;

    public override bool Equals(object obj)
    {
      return obj is ExecuteRecipeTaskHistory && object.Equals((object) this._IssueDifferenceReason, (object) ((ExecuteRecipeTaskHistory) obj)._IssueDifferenceReason) && (object.Equals((object) this._Spec, (object) ((ExecuteRecipeTaskHistory) obj)._Spec) && object.Equals((object) this._ElectronicProcedure, (object) ((ExecuteRecipeTaskHistory) obj)._ElectronicProcedure)) && (object.Equals((object) this._MaterialContainer, (object) ((ExecuteRecipeTaskHistory) obj)._MaterialContainer) && object.Equals((object) this._Carrier, (object) ((ExecuteRecipeTaskHistory) obj)._Carrier) && object.Equals((object) this._CompleteTaskForBatch, (object) ((ExecuteRecipeTaskHistory) obj)._CompleteTaskForBatch)) && base.Equals(obj);
    }

    public NamedObjectRef IssueDifferenceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDifferenceReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (IssueDifferenceReason));
      }
    }

    public RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
      }
    }

    public new RevisionedObjectRef ElectronicProcedure
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElectronicProcedure), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ElectronicProcedure));
      }
    }

    public ContainerRef MaterialContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (MaterialContainer));
      }
    }

    public NamedObjectRef Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Carrier));
      }
    }

    public Primitive<bool> CompleteTaskForBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteTaskForBatch), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CompleteTaskForBatch));
      }
    }
  }
}
