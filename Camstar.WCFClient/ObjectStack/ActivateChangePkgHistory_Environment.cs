// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivateChangePkgHistory_Environment
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
  public class ActivateChangePkgHistory_Environment : ChangePackageHistory_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_Environment_ExportImportName")]
    [Metadata("ExportImportName", "", false, false, true, "String", 1050821, false, false, false, null)]
    protected Environment _ExportImportName;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_Environment_OverrideComments")]
    [Metadata("Comments", "", false, false, true, "String", 16778976, false, false, false, null)]
    protected Environment _OverrideComments;
    [Metadata("URL", "", false, false, true, "String", 16777302, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_Environment_ModelingImportFile")]
    protected Environment _ModelingImportFile;
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_Environment_HistoryDetails")]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_Environment_ImportAction")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16777301, false, false, false, null)]
    protected Environment _ImportAction;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16778979, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_Environment_OverrideExecuted")]
    protected Environment _OverrideExecuted;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_Environment_ChangePackageName")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1053234, false, false, false, null)]
    protected new Environment _ChangePackageName;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment ExportImportName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportName));
      }
    }

    public Environment OverrideComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (OverrideComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OverrideComments));
      }
    }

    public Environment ModelingImportFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingImportFile), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ModelingImportFile));
      }
    }

    public new ServiceHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment ImportAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ImportAction));
      }
    }

    public Environment OverrideExecuted
    {
      [param: In] set
      {
        this.PropertySet(nameof (OverrideExecuted), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OverrideExecuted));
      }
    }

    public new Environment ChangePackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangePackageName));
      }
    }
  }
}
