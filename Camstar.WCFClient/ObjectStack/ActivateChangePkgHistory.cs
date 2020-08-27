// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivateChangePkgHistory
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
  public class ActivateChangePkgHistory : ChangePackageHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_ExportImportName")]
    protected Primitive<string> _ExportImportName;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_OverrideComments")]
    protected Primitive<string> _OverrideComments;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_ModelingImportFile")]
    protected Primitive<string> _ModelingImportFile;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_ImportAction")]
    protected Primitive<int> _ImportAction;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_OverrideExecuted")]
    protected Primitive<bool> _OverrideExecuted;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkgHistory_ChangePackageName")]
    protected new Primitive<string> _ChangePackageName;

    public override bool Equals(object obj)
    {
      return obj is ActivateChangePkgHistory && object.Equals((object) this._ExportImportKey, (object) ((ActivateChangePkgHistory) obj)._ExportImportKey) && (object.Equals((object) this._ExportImportName, (object) ((ActivateChangePkgHistory) obj)._ExportImportName) && object.Equals((object) this._OverrideComments, (object) ((ActivateChangePkgHistory) obj)._OverrideComments)) && (object.Equals((object) this._ModelingImportFile, (object) ((ActivateChangePkgHistory) obj)._ModelingImportFile) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((ActivateChangePkgHistory) obj)._HistoryDetails) && (object.Equals((object) this._HistoryId, (object) ((ActivateChangePkgHistory) obj)._HistoryId) && object.Equals((object) this._ImportAction, (object) ((ActivateChangePkgHistory) obj)._ImportAction))) && (object.Equals((object) this._OverrideExecuted, (object) ((ActivateChangePkgHistory) obj)._OverrideExecuted) && object.Equals((object) this._ChangePackageName, (object) ((ActivateChangePkgHistory) obj)._ChangePackageName)) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<string> ExportImportName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportName));
      }
    }

    public Primitive<string> OverrideComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (OverrideComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OverrideComments));
      }
    }

    public Primitive<string> ModelingImportFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingImportFile), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ModelingImportFile));
      }
    }

    public new ServiceHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<int> ImportAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportAction), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ImportAction));
      }
    }

    public Primitive<bool> OverrideExecuted
    {
      [param: In] set
      {
        this.PropertySet(nameof (OverrideExecuted), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OverrideExecuted));
      }
    }

    public new Primitive<string> ChangePackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ChangePackageName));
      }
    }
  }
}
