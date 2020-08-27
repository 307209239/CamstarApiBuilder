// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerLevelChanges_Info
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
  public class ContainerLevelChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Info_UIPreference")]
    protected Info _UIPreference;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Info_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges_Info _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Info_WIPMsgConfig")]
    protected WIPMsgConfigChanges_Info _WIPMsgConfig;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Info_Attributes")]
    protected UserAttributeChanges_Info _Attributes;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Info_ContainerNumberingRule")]
    protected Info _ContainerNumberingRule;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Info_IsNameUnique")]
    protected Info _IsNameUnique;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Info_AllowMove")]
    protected Info _AllowMove;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Info_ChildLevels")]
    protected Info _ChildLevels;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Info_ParentLevels")]
    protected Info _ParentLevels;

    public Info UIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreference), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UIPreference));
      }
    }

    public WIPMsgDefMgrChanges_Info WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Info) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public WIPMsgConfigChanges_Info WIPMsgConfig
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgConfig), (object) value);
      }
      get
      {
        return (WIPMsgConfigChanges_Info) this.PropertyGet(nameof (WIPMsgConfig));
      }
    }

    public UserAttributeChanges_Info Attributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attributes), (object) value);
      }
      get
      {
        return (UserAttributeChanges_Info) this.PropertyGet(nameof (Attributes));
      }
    }

    public Info ContainerNumberingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNumberingRule), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerNumberingRule));
      }
    }

    public Info IsNameUnique
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsNameUnique), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsNameUnique));
      }
    }

    public Info AllowMove
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowMove), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowMove));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info ChildLevels
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildLevels), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildLevels));
      }
    }

    public Info ParentLevels
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentLevels), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentLevels));
      }
    }
  }
}
