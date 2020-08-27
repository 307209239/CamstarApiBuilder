// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerLevelChanges
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
  public class ContainerLevelChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_UIPreference")]
    protected NamedObjectRef _UIPreference;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_WIPMsgConfig")]
    protected WIPMsgConfigChanges _WIPMsgConfig;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Attributes")]
    protected UserAttributeChanges[] _Attributes;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_ContainerNumberingRule")]
    protected NamedObjectRef _ContainerNumberingRule;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_IsNameUnique")]
    protected Primitive<bool> _IsNameUnique;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_AllowMove")]
    protected Primitive<bool> _AllowMove;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_ChildLevels")]
    protected NamedObjectRef[] _ChildLevels;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_ParentLevels")]
    protected NamedObjectRef[] _ParentLevels;

    public override bool Equals(object obj)
    {
      return obj is ContainerLevelChanges && object.Equals((object) this._UIPreference, (object) ((ContainerLevelChanges) obj)._UIPreference) && (object.Equals((object) this._WIPMsgDefMgr, (object) ((ContainerLevelChanges) obj)._WIPMsgDefMgr) && object.Equals((object) this._WIPMsgConfig, (object) ((ContainerLevelChanges) obj)._WIPMsgConfig)) && (this.CompareArrays((Array) this._Attributes, (Array) ((ContainerLevelChanges) obj)._Attributes) && object.Equals((object) this._ContainerNumberingRule, (object) ((ContainerLevelChanges) obj)._ContainerNumberingRule) && (object.Equals((object) this._IsNameUnique, (object) ((ContainerLevelChanges) obj)._IsNameUnique) && object.Equals((object) this._AllowMove, (object) ((ContainerLevelChanges) obj)._AllowMove))) && (object.Equals((object) this._Name, (object) ((ContainerLevelChanges) obj)._Name) && object.Equals((object) this._ObjectToChange, (object) ((ContainerLevelChanges) obj)._ObjectToChange) && (this.CompareArrays((Array) this._ChildLevels, (Array) ((ContainerLevelChanges) obj)._ChildLevels) && this.CompareArrays((Array) this._ParentLevels, (Array) ((ContainerLevelChanges) obj)._ParentLevels))) && base.Equals(obj);
    }

    public NamedObjectRef UIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreference), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UIPreference));
      }
    }

    public WIPMsgDefMgrChanges WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public WIPMsgConfigChanges WIPMsgConfig
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgConfig), (object) value);
      }
      get
      {
        return (WIPMsgConfigChanges) this.PropertyGet(nameof (WIPMsgConfig));
      }
    }

    public UserAttributeChanges[] Attributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attributes), (object) value);
      }
      get
      {
        return (UserAttributeChanges[]) this.PropertyGet(nameof (Attributes));
      }
    }

    public NamedObjectRef ContainerNumberingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNumberingRule), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ContainerNumberingRule));
      }
    }

    public Primitive<bool> IsNameUnique
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsNameUnique), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsNameUnique));
      }
    }

    public Primitive<bool> AllowMove
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowMove), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowMove));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
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

    public NamedObjectRef[] ChildLevels
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildLevels), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ChildLevels));
      }
    }

    public NamedObjectRef[] ParentLevels
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentLevels), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ParentLevels));
      }
    }
  }
}
