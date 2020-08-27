// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageMoveHistory_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (MoveNonStdChangePkgHistory_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MoveStdChangePkgHistory_Info))]
  [Serializable]
  public class ChangePackageMoveHistory_Info : TrackableObjectMovementHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageMoveHistory_Info_Path")]
    protected Info _Path;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageMoveHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageMoveHistory_Info_ToWorkflow")]
    protected Info _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageMoveHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageMoveHistory_Info_Step")]
    protected Info _Step;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageMoveHistory_Info_ToStep")]
    protected Info _ToStep;

    public Info Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Path));
      }
    }

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

    public Info ToWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToWorkflow));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Info Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Step));
      }
    }

    public Info ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToStep));
      }
    }
  }
}
