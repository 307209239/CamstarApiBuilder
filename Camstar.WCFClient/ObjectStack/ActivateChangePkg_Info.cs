// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivateChangePkg_Info
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
  public class ActivateChangePkg_Info : ChangeMgtTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_Info_ImportSetName")]
    protected Info _ImportSetName;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_Info_OverrideComments")]
    protected Info _OverrideComments;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_Info_ExportImportName")]
    protected Info _ExportImportName;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_Info_ModelingImportFile")]
    protected Info _ModelingImportFile;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_Info_ChangePackage")]
    protected new Info _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_Info_OverrideExecuted")]
    protected Info _OverrideExecuted;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_Info_ImportAction")]
    protected Info _ImportAction;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_Info_PreReqsActivatedFlag")]
    protected Info _PreReqsActivatedFlag;

    public Info ImportSetName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportSetName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ImportSetName));
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

    public new Info ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangePackage));
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

    public Info PreReqsActivatedFlag
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreReqsActivatedFlag), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PreReqsActivatedFlag));
      }
    }
  }
}
