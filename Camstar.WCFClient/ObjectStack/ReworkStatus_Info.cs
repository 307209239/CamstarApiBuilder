// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReworkStatus_Info
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
  public class ReworkStatus_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ReworkStatus_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ReworkStatus_Info_ReEntryWorkflowStack")]
    protected Info _ReEntryWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "ReworkStatus_Info_ReEntryStep")]
    protected Info _ReEntryStep;
    [DataMember(EmitDefaultValue = false, Name = "ReworkStatus_Info_ReworkReason")]
    protected Info _ReworkReason;
    [DataMember(EmitDefaultValue = false, Name = "ReworkStatus_Info_EndReworkStep")]
    protected Info _EndReworkStep;

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

    public Info ReEntryWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryWorkflowStack), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReEntryWorkflowStack));
      }
    }

    public Info ReEntryStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReEntryStep));
      }
    }

    public Info ReworkReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReworkReason));
      }
    }

    public Info EndReworkStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndReworkStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndReworkStep));
      }
    }
  }
}
