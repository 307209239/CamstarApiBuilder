// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalMessageCategoryChanges
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
  public class PortalMessageCategoryChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PortalMessageCategoryChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMessageCategoryChanges_CategoryNotificationMap")]
    protected CategoryNotificationMapChanges[] _CategoryNotificationMap;
    [DataMember(EmitDefaultValue = false, Name = "PortalMessageCategoryChanges_YellowMinRange")]
    protected Primitive<int> _YellowMinRange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMessageCategoryChanges_YellowMaxRange")]
    protected Primitive<int> _YellowMaxRange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMessageCategoryChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is PortalMessageCategoryChanges && object.Equals((object) this._ObjectToChange, (object) ((PortalMessageCategoryChanges) obj)._ObjectToChange) && (this.CompareArrays((Array) this._CategoryNotificationMap, (Array) ((PortalMessageCategoryChanges) obj)._CategoryNotificationMap) && object.Equals((object) this._YellowMinRange, (object) ((PortalMessageCategoryChanges) obj)._YellowMinRange)) && (object.Equals((object) this._YellowMaxRange, (object) ((PortalMessageCategoryChanges) obj)._YellowMaxRange) && object.Equals((object) this._Name, (object) ((PortalMessageCategoryChanges) obj)._Name)) && base.Equals(obj);
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

    public CategoryNotificationMapChanges[] CategoryNotificationMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryNotificationMap), (object) value);
      }
      get
      {
        return (CategoryNotificationMapChanges[]) this.PropertyGet(nameof (CategoryNotificationMap));
      }
    }

    public Primitive<int> YellowMinRange
    {
      [param: In] set
      {
        this.PropertySet(nameof (YellowMinRange), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (YellowMinRange));
      }
    }

    public Primitive<int> YellowMaxRange
    {
      [param: In] set
      {
        this.PropertySet(nameof (YellowMaxRange), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (YellowMaxRange));
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
  }
}
