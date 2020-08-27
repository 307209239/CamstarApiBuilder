// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureAction
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
  public class EventFailureAction : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailureAction_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureAction_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureAction_ActionType")]
    protected NamedObjectRef _ActionType;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureAction_CompletionDate")]
    protected Primitive<DateTime> _CompletionDate;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureAction_ActionOwner")]
    protected NamedObjectRef _ActionOwner;

    public override bool Equals(object obj)
    {
      return obj is EventFailureAction && object.Equals((object) this._ExportImportKey, (object) ((EventFailureAction) obj)._ExportImportKey) && (object.Equals((object) this._Comments, (object) ((EventFailureAction) obj)._Comments) && object.Equals((object) this._ActionType, (object) ((EventFailureAction) obj)._ActionType)) && (object.Equals((object) this._CompletionDate, (object) ((EventFailureAction) obj)._CompletionDate) && object.Equals((object) this._ActionOwner, (object) ((EventFailureAction) obj)._ActionOwner)) && base.Equals(obj);
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

    public NamedObjectRef ActionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ActionType));
      }
    }

    public Primitive<DateTime> CompletionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CompletionDate));
      }
    }

    public NamedObjectRef ActionOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionOwner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ActionOwner));
      }
    }
  }
}
