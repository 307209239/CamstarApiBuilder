// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageFlowStateChanges_Info
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
  public class UIPageFlowStateChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Info_Content")]
    protected Info _Content;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Info_PageFlowActivities")]
    protected UIPageFlowActivityChanges_Info _PageFlowActivities;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Info_QualityObjectType")]
    protected Info _QualityObjectType;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Info_Owner")]
    protected Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Info_QualityObjectName")]
    protected Info _QualityObjectName;

    public Info Content
    {
      [param: In] set
      {
        this.PropertySet(nameof (Content), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Content));
      }
    }

    public UIPageFlowActivityChanges_Info PageFlowActivities
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageFlowActivities), (object) value);
      }
      get
      {
        return (UIPageFlowActivityChanges_Info) this.PropertyGet(nameof (PageFlowActivities));
      }
    }

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

    public Info QualityObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObjectType));
      }
    }

    public Info Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Owner));
      }
    }

    public Info QualityObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObjectName));
      }
    }
  }
}
