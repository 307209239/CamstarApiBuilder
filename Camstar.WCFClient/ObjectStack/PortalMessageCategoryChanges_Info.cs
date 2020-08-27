// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalMessageCategoryChanges_Info
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
  public class PortalMessageCategoryChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PortalMessageCategoryChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMessageCategoryChanges_Info_CategoryNotificationMap")]
    protected CategoryNotificationMapChanges_Info _CategoryNotificationMap;
    [DataMember(EmitDefaultValue = false, Name = "PortalMessageCategoryChanges_Info_YellowMinRange")]
    protected Info _YellowMinRange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMessageCategoryChanges_Info_YellowMaxRange")]
    protected Info _YellowMaxRange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMessageCategoryChanges_Info_Name")]
    protected new Info _Name;

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

    public CategoryNotificationMapChanges_Info CategoryNotificationMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryNotificationMap), (object) value);
      }
      get
      {
        return (CategoryNotificationMapChanges_Info) this.PropertyGet(nameof (CategoryNotificationMap));
      }
    }

    public Info YellowMinRange
    {
      [param: In] set
      {
        this.PropertySet(nameof (YellowMinRange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (YellowMinRange));
      }
    }

    public Info YellowMaxRange
    {
      [param: In] set
      {
        this.PropertySet(nameof (YellowMaxRange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (YellowMaxRange));
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
  }
}
