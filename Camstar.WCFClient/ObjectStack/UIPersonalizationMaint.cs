// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPersonalizationMaint
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
  public class UIPersonalizationMaint : SubentityMaintenance
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationMaint_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationMaint_ObjectChanges")]
    protected UIPersonalizationChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationMaint_ParentDataObject")]
    protected NamedObjectRef _ParentDataObject;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationMaint_ContentAction")]
    protected Enumeration<ContentActionEnum, int> _ContentAction;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationMaint_WorkspaceId")]
    protected Primitive<int> _WorkspaceId;

    public override bool Equals(object obj)
    {
      return obj is UIPersonalizationMaint && object.Equals((object) this._ObjectToChange, (object) ((UIPersonalizationMaint) obj)._ObjectToChange) && (object.Equals((object) this._ObjectChanges, (object) ((UIPersonalizationMaint) obj)._ObjectChanges) && object.Equals((object) this._ParentDataObject, (object) ((UIPersonalizationMaint) obj)._ParentDataObject)) && (object.Equals((object) this._ContentAction, (object) ((UIPersonalizationMaint) obj)._ContentAction) && object.Equals((object) this._WorkspaceId, (object) ((UIPersonalizationMaint) obj)._WorkspaceId)) && base.Equals(obj);
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public UIPersonalizationChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (UIPersonalizationChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public NamedObjectRef ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ParentDataObject));
      }
    }

    public Enumeration<ContentActionEnum, int> ContentAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContentAction), (object) value);
      }
      get
      {
        return (Enumeration<ContentActionEnum, int>) this.PropertyGet(nameof (ContentAction));
      }
    }

    public Primitive<int> WorkspaceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkspaceId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (WorkspaceId));
      }
    }
  }
}
