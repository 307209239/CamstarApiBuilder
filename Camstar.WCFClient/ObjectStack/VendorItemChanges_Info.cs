// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.VendorItemChanges_Info
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
  public class VendorItemChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Info_MinOrderQty")]
    protected Info _MinOrderQty;
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Info_ItemName")]
    protected Info _ItemName;
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Info_LeadTime")]
    protected Info _LeadTime;
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Info_Cost")]
    protected Info _Cost;

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

    public Info MinOrderQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinOrderQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MinOrderQty));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public Info ItemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ItemName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ItemName));
      }
    }

    public Info LeadTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (LeadTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LeadTime));
      }
    }

    public Info Cost
    {
      [param: In] set
      {
        this.PropertySet(nameof (Cost), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Cost));
      }
    }
  }
}
