// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageFlowStateChanges
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
  public class UIPageFlowStateChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Content")]
    protected Primitive<string> _Content;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_PageFlowActivities")]
    protected UIPageFlowActivityChanges[] _PageFlowActivities;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_QualityObjectType")]
    protected Primitive<string> _QualityObjectType;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Owner")]
    protected NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_QualityObjectName")]
    protected Primitive<string> _QualityObjectName;

    public override bool Equals(object obj)
    {
      return obj is UIPageFlowStateChanges && object.Equals((object) this._Content, (object) ((UIPageFlowStateChanges) obj)._Content) && (this.CompareArrays((Array) this._PageFlowActivities, (Array) ((UIPageFlowStateChanges) obj)._PageFlowActivities) && object.Equals((object) this._ListItemToChange, (object) ((UIPageFlowStateChanges) obj)._ListItemToChange)) && (object.Equals((object) this._ObjectToChange, (object) ((UIPageFlowStateChanges) obj)._ObjectToChange) && object.Equals((object) this._Name, (object) ((UIPageFlowStateChanges) obj)._Name) && (object.Equals((object) this._QualityObjectType, (object) ((UIPageFlowStateChanges) obj)._QualityObjectType) && object.Equals((object) this._Owner, (object) ((UIPageFlowStateChanges) obj)._Owner))) && object.Equals((object) this._QualityObjectName, (object) ((UIPageFlowStateChanges) obj)._QualityObjectName) && base.Equals(obj);
    }

    public Primitive<string> Content
    {
      [param: In] set
      {
        this.PropertySet(nameof (Content), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Content));
      }
    }

    public UIPageFlowActivityChanges[] PageFlowActivities
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageFlowActivities), (object) value);
      }
      get
      {
        return (UIPageFlowActivityChanges[]) this.PropertyGet(nameof (PageFlowActivities));
      }
    }

    public NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
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

    public Primitive<string> QualityObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectType), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QualityObjectType));
      }
    }

    public NamedObjectRef Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Owner));
      }
    }

    public Primitive<string> QualityObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QualityObjectName));
      }
    }
  }
}
