// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureCauseData_Info
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
  public class FailureCauseData_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseData_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseData_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseData_Info_Cause")]
    protected Info _Cause;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseData_Info_FailurePlans")]
    protected FailurePlanData_Info _FailurePlans;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseData_Info_RootCauseConfirmed")]
    protected Info _RootCauseConfirmed;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseData_Info_IsFrozen")]
    protected Info _IsFrozen;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Info Cause
    {
      [param: In] set
      {
        this.PropertySet(nameof (Cause), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Cause));
      }
    }

    public FailurePlanData_Info FailurePlans
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailurePlans), (object) value);
      }
      get
      {
        return (FailurePlanData_Info) this.PropertyGet(nameof (FailurePlans));
      }
    }

    public Info RootCauseConfirmed
    {
      [param: In] set
      {
        this.PropertySet(nameof (RootCauseConfirmed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RootCauseConfirmed));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
