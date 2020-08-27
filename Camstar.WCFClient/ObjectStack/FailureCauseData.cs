// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureCauseData
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
  public class FailureCauseData : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseData_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseData_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseData_Cause")]
    protected NamedObjectRef _Cause;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseData_FailurePlans")]
    protected FailurePlanData[] _FailurePlans;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseData_RootCauseConfirmed")]
    protected Primitive<bool> _RootCauseConfirmed;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseData_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is FailureCauseData && object.Equals((object) this._ExportImportKey, (object) ((FailureCauseData) obj)._ExportImportKey) && (object.Equals((object) this._Comments, (object) ((FailureCauseData) obj)._Comments) && object.Equals((object) this._Cause, (object) ((FailureCauseData) obj)._Cause)) && (this.CompareArrays((Array) this._FailurePlans, (Array) ((FailureCauseData) obj)._FailurePlans) && object.Equals((object) this._RootCauseConfirmed, (object) ((FailureCauseData) obj)._RootCauseConfirmed) && object.Equals((object) this._IsFrozen, (object) ((FailureCauseData) obj)._IsFrozen)) && base.Equals(obj);
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

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public NamedObjectRef Cause
    {
      [param: In] set
      {
        this.PropertySet(nameof (Cause), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Cause));
      }
    }

    public FailurePlanData[] FailurePlans
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailurePlans), (object) value);
      }
      get
      {
        return (FailurePlanData[]) this.PropertyGet(nameof (FailurePlans));
      }
    }

    public Primitive<bool> RootCauseConfirmed
    {
      [param: In] set
      {
        this.PropertySet(nameof (RootCauseConfirmed), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RootCauseConfirmed));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
