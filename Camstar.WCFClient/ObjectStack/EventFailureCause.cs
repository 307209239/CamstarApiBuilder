// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureCause
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
  public class EventFailureCause : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCause_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCause_CauseCode")]
    protected NamedObjectRef _CauseCode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCause_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCause_EventFailureActions")]
    protected EventFailureAction[] _EventFailureActions;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCause_IsRootCause")]
    protected Primitive<bool> _IsRootCause;

    public override bool Equals(object obj)
    {
      return obj is EventFailureCause && object.Equals((object) this._ExportImportKey, (object) ((EventFailureCause) obj)._ExportImportKey) && (object.Equals((object) this._CauseCode, (object) ((EventFailureCause) obj)._CauseCode) && object.Equals((object) this._Comments, (object) ((EventFailureCause) obj)._Comments)) && (this.CompareArrays((Array) this._EventFailureActions, (Array) ((EventFailureCause) obj)._EventFailureActions) && object.Equals((object) this._IsRootCause, (object) ((EventFailureCause) obj)._IsRootCause)) && base.Equals(obj);
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

    public NamedObjectRef CauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CauseCode));
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

    public EventFailureAction[] EventFailureActions
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureActions), (object) value);
      }
      get
      {
        return (EventFailureAction[]) this.PropertyGet(nameof (EventFailureActions));
      }
    }

    public Primitive<bool> IsRootCause
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRootCause), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRootCause));
      }
    }
  }
}
