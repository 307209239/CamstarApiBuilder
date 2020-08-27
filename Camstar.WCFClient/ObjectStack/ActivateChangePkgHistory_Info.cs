// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivateChangePkgHistory_Info
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
  public class ActivateChangePkgHistory_Info : ChangePackageHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_Info_ExportImportName")]
    protected Info _ExportImportName;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_Info_OverrideComments")]
    protected Info _OverrideComments;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_Info_ModelingImportFile")]
    protected Info _ModelingImportFile;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_Info_HistoryDetails")]
    protected new ServiceHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_Info_ImportAction")]
    protected Info _ImportAction;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_Info_OverrideExecuted")]
    protected Info _OverrideExecuted;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_Info_ChangePackageName")]
    protected new Info _ChangePackageName;

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

    public Info ExportImportName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportName));
      }
    }

    public Info OverrideComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (OverrideComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OverrideComments));
      }
    }

    public Info ModelingImportFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingImportFile), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ModelingImportFile));
      }
    }

    public new ServiceHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
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

    public Info ImportAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ImportAction));
      }
    }

    public Info OverrideExecuted
    {
      [param: In] set
      {
        this.PropertySet(nameof (OverrideExecuted), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OverrideExecuted));
      }
    }

    public new Info ChangePackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangePackageName));
      }
    }
  }
}
