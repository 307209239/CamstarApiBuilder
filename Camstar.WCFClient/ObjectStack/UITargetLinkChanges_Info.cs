// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UITargetLinkChanges_Info
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
  public class UITargetLinkChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UITargetLinkChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UITargetLinkChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UITargetLinkChanges_Info_TargetMember")]
    protected Info _TargetMember;
    [DataMember(EmitDefaultValue = false, Name = "UITargetLinkChanges_Info_SourceMember")]
    protected Info _SourceMember;
    [DataMember(EmitDefaultValue = false, Name = "UITargetLinkChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
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

    public Info TargetMember
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetMember), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetMember));
      }
    }

    public Info SourceMember
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceMember), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SourceMember));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
