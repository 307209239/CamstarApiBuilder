// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteRecipeTaskHistory_Info
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
  public class ExecuteRecipeTaskHistory_Info : ExecuteTaskHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTaskHistory_Info_IssueDifferenceReason")]
    protected Info _IssueDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTaskHistory_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTaskHistory_Info_ElectronicProcedure")]
    protected new Info _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTaskHistory_Info_MaterialContainer")]
    protected Info _MaterialContainer;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTaskHistory_Info_Carrier")]
    protected Info _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTaskHistory_Info_CompleteTaskForBatch")]
    protected Info _CompleteTaskForBatch;

    public Info IssueDifferenceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDifferenceReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueDifferenceReason));
      }
    }

    public Info Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Spec));
      }
    }

    public new Info ElectronicProcedure
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElectronicProcedure), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ElectronicProcedure));
      }
    }

    public Info MaterialContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaterialContainer));
      }
    }

    public Info Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Carrier));
      }
    }

    public Info CompleteTaskForBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteTaskForBatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompleteTaskForBatch));
      }
    }
  }
}
