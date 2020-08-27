// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivateChangePkg_Environment
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
  public class ActivateChangePkg_Environment : ChangeMgtTxn_Environment
  {
    [Metadata("ExportImportName", "", false, false, false, "String", 1050828, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_Environment_ImportSetName")]
    protected Environment _ImportSetName;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_Environment_OverrideComments")]
    [Metadata("Comments", "", false, false, false, "String", 16778978, false, false, false, null)]
    protected Environment _OverrideComments;
    [Metadata("ExportImportName", "", false, false, false, "String", 1050821, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_Environment_ExportImportName")]
    protected Environment _ExportImportName;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_Environment_ModelingImportFile")]
    [Metadata("URL", "", false, false, false, "String", 16777302, false, false, false, null)]
    protected Environment _ModelingImportFile;
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, true, false, "NamedObjectRef", 1053240, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_Environment_ChangePackage")]
    protected new Environment _ChangePackage;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778979, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_Environment_OverrideExecuted")]
    protected Environment _OverrideExecuted;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16777301, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_Environment_ImportAction")]
    protected Environment _ImportAction;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_Environment_PreReqsActivatedFlag")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778977, false, false, false, "0")]
    protected Environment _PreReqsActivatedFlag;

    public Environment ImportSetName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportSetName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ImportSetName));
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

    public new Environment ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangePackage));
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

    public Environment PreReqsActivatedFlag
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreReqsActivatedFlag), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PreReqsActivatedFlag));
      }
    }
  }
}
