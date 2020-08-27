// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailure
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
  public class EventFailure : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailure_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventFailure_FailureSeverity")]
    protected NamedObjectRef _FailureSeverity;
    [DataMember(EmitDefaultValue = false, Name = "EventFailure_FailureType")]
    protected NamedObjectRef _FailureType;
    [DataMember(EmitDefaultValue = false, Name = "EventFailure_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailure_FailureMode")]
    protected NamedObjectRef _FailureMode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailure_Causes")]
    protected EventFailureCause[] _Causes;
    [DataMember(EmitDefaultValue = false, Name = "EventFailure_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is EventFailure && object.Equals((object) this._ExportImportKey, (object) ((EventFailure) obj)._ExportImportKey) && (object.Equals((object) this._FailureSeverity, (object) ((EventFailure) obj)._FailureSeverity) && object.Equals((object) this._FailureType, (object) ((EventFailure) obj)._FailureType)) && (object.Equals((object) this._Comments, (object) ((EventFailure) obj)._Comments) && object.Equals((object) this._FailureMode, (object) ((EventFailure) obj)._FailureMode) && (this.CompareArrays((Array) this._Causes, (Array) ((EventFailure) obj)._Causes) && object.Equals((object) this._Description, (object) ((EventFailure) obj)._Description))) && base.Equals(obj);
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

    public NamedObjectRef FailureSeverity
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureSeverity), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FailureSeverity));
      }
    }

    public NamedObjectRef FailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FailureType));
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

    public NamedObjectRef FailureMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureMode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FailureMode));
      }
    }

    public EventFailureCause[] Causes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Causes), (object) value);
      }
      get
      {
        return (EventFailureCause[]) this.PropertyGet(nameof (Causes));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }
  }
}
