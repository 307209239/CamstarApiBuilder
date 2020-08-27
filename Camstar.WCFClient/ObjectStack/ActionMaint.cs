// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionMaint
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
  public class ActionMaint : NamedDataObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ActionMaint_PageFilter")]
    protected NamedObjectRef _PageFilter;
    [DataMember(EmitDefaultValue = false, Name = "ActionMaint_Actions")]
    protected ActionDef[] _Actions;
    [DataMember(EmitDefaultValue = false, Name = "ActionMaint_ActionSource")]
    protected NamedObjectRef _ActionSource;
    [DataMember(EmitDefaultValue = false, Name = "ActionMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActionMaint_UIActionType")]
    protected Enumeration<UIActionTypeEnum, string> _UIActionType;
    [DataMember(EmitDefaultValue = false, Name = "ActionMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ActionMaint_ObjectChanges")]
    protected ActionDefChanges _ObjectChanges;

    public override bool Equals(object obj)
    {
      return obj is ActionMaint && object.Equals((object) this._PageFilter, (object) ((ActionMaint) obj)._PageFilter) && (this.CompareArrays((Array) this._Actions, (Array) ((ActionMaint) obj)._Actions) && object.Equals((object) this._ActionSource, (object) ((ActionMaint) obj)._ActionSource)) && (object.Equals((object) this._ObjectToChange, (object) ((ActionMaint) obj)._ObjectToChange) && object.Equals((object) this._UIActionType, (object) ((ActionMaint) obj)._UIActionType) && (this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ActionMaint) obj)._ObjectListInquiry) && object.Equals((object) this._ObjectChanges, (object) ((ActionMaint) obj)._ObjectChanges))) && base.Equals(obj);
    }

    public NamedObjectRef PageFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PageFilter));
      }
    }

    public ActionDef[] Actions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actions), (object) value);
      }
      get
      {
        return (ActionDef[]) this.PropertyGet(nameof (Actions));
      }
    }

    public NamedObjectRef ActionSource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionSource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ActionSource));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Enumeration<UIActionTypeEnum, string> UIActionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIActionType), (object) value);
      }
      get
      {
        return (Enumeration<UIActionTypeEnum, string>) this.PropertyGet(nameof (UIActionType));
      }
    }

    public new NamedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public ActionDefChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ActionDefChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
