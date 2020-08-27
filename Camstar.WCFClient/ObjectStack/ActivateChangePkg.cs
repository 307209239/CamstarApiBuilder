// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivateChangePkg
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
  public class ActivateChangePkg : ChangeMgtTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_ImportSetName")]
    protected Primitive<string> _ImportSetName;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_OverrideComments")]
    protected Primitive<string> _OverrideComments;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_ExportImportName")]
    protected Primitive<string> _ExportImportName;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_ModelingImportFile")]
    protected Primitive<string> _ModelingImportFile;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_ChangePackage")]
    protected new NamedObjectRef _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_OverrideExecuted")]
    protected Primitive<bool> _OverrideExecuted;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_ImportAction")]
    protected Primitive<int> _ImportAction;
    [DataMember(EmitDefaultValue = false, Name = "ActivateChangePkg_PreReqsActivatedFlag")]
    protected Primitive<bool> _PreReqsActivatedFlag;

    public override bool Equals(object obj)
    {
      return obj is ActivateChangePkg && object.Equals((object) this._ImportSetName, (object) ((ActivateChangePkg) obj)._ImportSetName) && (object.Equals((object) this._OverrideComments, (object) ((ActivateChangePkg) obj)._OverrideComments) && object.Equals((object) this._ExportImportName, (object) ((ActivateChangePkg) obj)._ExportImportName)) && (object.Equals((object) this._ModelingImportFile, (object) ((ActivateChangePkg) obj)._ModelingImportFile) && object.Equals((object) this._ChangePackage, (object) ((ActivateChangePkg) obj)._ChangePackage) && (object.Equals((object) this._OverrideExecuted, (object) ((ActivateChangePkg) obj)._OverrideExecuted) && object.Equals((object) this._ImportAction, (object) ((ActivateChangePkg) obj)._ImportAction))) && object.Equals((object) this._PreReqsActivatedFlag, (object) ((ActivateChangePkg) obj)._PreReqsActivatedFlag) && base.Equals(obj);
    }

    public Primitive<string> ImportSetName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportSetName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ImportSetName));
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

    public new NamedObjectRef ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ChangePackage));
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

    public Primitive<bool> PreReqsActivatedFlag
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreReqsActivatedFlag), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (PreReqsActivatedFlag));
      }
    }
  }
}
